using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ABC_EMPLEADOS.Datos;
using ABC_EMPLEADOS.Logica;

namespace ABC_EMPLEADOS.Presentacion
{
    public partial class Empleados : UserControl
    {
        public Empleados()
        {
            InitializeComponent();
        }
        public int Idempleado;
        private string fecha_nac;
        private string fecha_alta;

        private void btnGu_Click(object sender, EventArgs e)
        {
            InsertarEmpleado();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupGuardar.Visible = true;
            gpControles.Visible = false;
            LimpiarCampos();

        }


        private void Empleados_Load(object sender, EventArgs e)
        {
            Dempleados puesto = new Dempleados();
            //Cargamos los datos de empresa al comboboxPuesto
            cbxPuesto.DataSource = puesto.CargarComboPuesto();
            cbxPuesto.DisplayMember = "Puesto";
            cbxPuesto.ValueMember = "Id_Puesto";

            //Cargamos los datos de empresa al comboboxEmpresa
            cbxEmpresa.DataSource = puesto.CargarComboEmpresa();
            cbxEmpresa.DisplayMember = "Empresa";
            cbxEmpresa.ValueMember = "Id_Empresa";

            //Mostramos los empleados
            Mostrarempleados();

            gpControles.Visible = false;

        }



        private void LimpiarCampos()
        {
            txtNombre.Text = " ";
            txtApellidos.Text = " ";
            cbxSexo.Text = " ";
            cbxPuesto.Text = " ";
            txtDireccion.Text = " ";
            txtEmail.Text = " ";
            txtTelefono.Text = " ";
            cbxEmpresa.Text = " ";
        }



        private void Mostrarempleados()
        {
            Dempleados funcion = new Dempleados();
            DataTable dt = new DataTable();
            funcion.MostrarEmpleados(ref dt);
            dataEmpleados.DataSource = dt;
        }

        private void InsertarEmpleado()
        {


            Dempleados funcion = new Dempleados();
            Lempleados parametros = new Lempleados();
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellidos.Text)
                || cbxSexo.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("No debe dejar campos vacios");
            }
            else
            {
                if (!(dateFechaNac.Checked || dateFechaAlta.Checked))
                {
                    MessageBox.Show("Debe seleccionar una fecha");
                }
                else
                {
                    if (cbxPuesto.SelectedIndex.Equals(-1) || string.IsNullOrEmpty(txtDireccion.Text)
                        || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text)
                        || cbxEmpresa.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show("No debe dejar campos vacios");
                    }
                    else
                    {
                        parametros.Nombre = txtNombre.Text;
                        parametros.Apellidos = txtApellidos.Text;
                        parametros.Sexo = cbxSexo.GetItemText(cbxSexo.SelectedItem);
                        parametros.Fecha_Nacimiento = fecha_nac = Convert.ToString(dateFechaNac.Value.Date.ToString("yyyy-MM-dd"));
                        parametros.Fecha_Alta = fecha_alta = Convert.ToString(dateFechaAlta.Value.Date.ToString("yyyy-MM-dd"));
                        parametros.IdPuesto = Convert.ToInt16(cbxPuesto.SelectedValue);
                        parametros.Direccion = txtDireccion.Text;
                        parametros.Email = txtEmail.Text;
                        parametros.Telefono = txtTelefono.Text;
                        parametros.IdEmpresa = Convert.ToInt16(cbxEmpresa.SelectedValue);
                        funcion.Insertarempleados(parametros);
                        Mostrarempleados();
                        LimpiarCampos();

                    }

                }



            }


        }

        private void ActualizarEmpleado()
        {
            Dempleados funcion = new Dempleados();
            Lempleados parametros = new Lempleados();
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellidos.Text)
                || cbxSexo.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("No debe dejar campos vacios");
            }
            else
            {
                if (!(dateFechaNac.Checked || dateFechaAlta.Checked))
                {
                    MessageBox.Show("Debe seleccionar una fecha");
                }
                else
                {
                    if (cbxPuesto.SelectedIndex.Equals(-1) || string.IsNullOrEmpty(txtDireccion.Text)
                        || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text)
                        || cbxEmpresa.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show("No debe dejar campos vacios");
                    }
                    else
                    {
                        parametros.Id_Empleado = Idempleado;
                        parametros.Nombre = txtNombre.Text;
                        parametros.Apellidos = txtApellidos.Text;
                        parametros.Sexo = cbxSexo.GetItemText(cbxSexo.SelectedItem);
                        parametros.Fecha_Nacimiento = fecha_nac = Convert.ToString(dateFechaNac.Value.Date.ToString("yyyy-MM-dd"));
                        parametros.Fecha_Alta = fecha_alta = Convert.ToString(dateFechaAlta.Value.Date.ToString("yyyy-MM-dd"));
                        parametros.IdPuesto = Convert.ToInt16(cbxPuesto.SelectedValue);
                        parametros.Direccion = txtDireccion.Text;
                        parametros.Email = txtEmail.Text;
                        parametros.Telefono = txtTelefono.Text;
                        parametros.IdEmpresa = Convert.ToInt16(cbxEmpresa.SelectedValue);
                        funcion.Editarempleados(parametros);
                        LimpiarCampos();
                        gpControles.Visible = false;
                        Mostrarempleados();
                        groupGuardar.Visible = true;

                    }

                }



            }
        }

        private void EliminarEmpleado()
        {
            Dempleados funcion = new Dempleados();
            Lempleados parametros = new Lempleados();
            parametros.Id_Empleado = Idempleado;
            funcion.Eliminarempleado(parametros);
            LimpiarCampos();
            gpControles.Visible = false;
            Mostrarempleados();
            groupGuardar.Visible = true;

        }

        private void dataEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Idempleado = Convert.ToInt32(dataEmpleados.SelectedCells[0].Value.ToString());
            txtNombre.Text = dataEmpleados.SelectedCells[1].Value.ToString();
            txtApellidos.Text = dataEmpleados.SelectedCells[2].Value.ToString();
            cbxSexo.Text = dataEmpleados.SelectedCells[3].Value.ToString();
            dateFechaNac.Value = Convert.ToDateTime(dataEmpleados.SelectedCells[4].Value.ToString());
            dateFechaAlta.Value = Convert.ToDateTime(dataEmpleados.SelectedCells[5].Value.ToString());
            cbxPuesto.Text = dataEmpleados.SelectedCells[6].Value.ToString();
            txtDireccion.Text = dataEmpleados.SelectedCells[7].Value.ToString();
            txtEmail.Text = dataEmpleados.SelectedCells[8].Value.ToString();
            txtTelefono.Text = dataEmpleados.SelectedCells[9].Value.ToString();
            cbxEmpresa.Text = dataEmpleados.SelectedCells[10].Value.ToString();
            gpControles.Visible = true;
            groupGuardar.Visible = false;
        }

      
    }
}
