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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }
        private string fecha_nac;
        private string fecha_alta;
        Dempleados puesto = new Dempleados();
        private void frmEmpleado_Load(object sender, EventArgs e)
        {
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



        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarClientes();
        }


        private  void InsertarClientes()
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
                        //MessageBox.Show(fecha_alta);
                        funcion.InsertarEmpleados(parametros);
                        Mostrarempleados();

                    }
                   
                }

             

            }


        }

        private void Mostrarempleados()
        {
            Dempleados funcion = new Dempleados();
            DataTable dt = new DataTable();
            funcion.MostrarEmpleados(ref dt);
            dataEmpleados.DataSource = dt;
        } 
    }
}
