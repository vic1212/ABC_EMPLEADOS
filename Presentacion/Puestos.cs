using ABC_EMPLEADOS.Datos;
using ABC_EMPLEADOS.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABC_EMPLEADOS.Presentacion
{
    public partial class Puestos : UserControl
    {
        public Puestos()
        {
            InitializeComponent();
        }
        private int IdPuesto;
        private void Puestos_Load(object sender, EventArgs e)
        {
            Mostrarpuestos();
            gpControles.Visible = false;
        }



       

        private void btnGu_Click(object sender, EventArgs e)
        {
            InsertarPuesto();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarPuesto();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            gpControles.Visible = false;
            groupGuardar.Visible = true;

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPuesto();
        }

        private void Mostrarpuestos()
        {
            Dpuesto funcion = new Dpuesto();
            DataTable dt = new DataTable();
            funcion.MostrarPuestos(ref dt);
            dataPuestos.DataSource = dt;
        }

        private void LimpiarCampos()
        {
            txtPuesto.Text = "";
        }


        private void InsertarPuesto()
        {
            Dpuesto funcion = new Dpuesto();
            Lpuestos parametros = new Lpuestos();

            if (string.IsNullOrEmpty(txtPuesto.Text))
            {
                MessageBox.Show("No debe dejar campos vacios");
            }
            else
            {
                parametros.Puesto = txtPuesto.Text;
                funcion.Insertarpuesto(parametros);
                Mostrarpuestos();
                LimpiarCampos();
            }
        }

        private void ActualizarPuesto()
        {
            Dpuesto funcion = new Dpuesto();
            Lpuestos parametros = new Lpuestos();

            if (string.IsNullOrEmpty(txtPuesto.Text))
            {
                MessageBox.Show("No debe dejar campos vacios");
            }
            else
            {
                parametros.IdPuesto = IdPuesto;
                parametros.Puesto = txtPuesto.Text;
                funcion.Editarpuesto(parametros);
                LimpiarCampos();
                gpControles.Visible = false;
                Mostrarpuestos();
                groupGuardar.Visible = true;

      
            }
        }
        private void EliminarPuesto()
        {
            Dpuesto funcion = new Dpuesto();
            Lpuestos parametros = new Lpuestos();
            parametros.IdPuesto = IdPuesto;
            funcion.Eliminarpusto(parametros);
            LimpiarCampos();
            gpControles.Visible = false;
            Mostrarpuestos();
            groupGuardar.Visible = true;

        }

        private void dataPuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdPuesto = Convert.ToInt32(dataPuestos.SelectedCells[0].Value.ToString());
            txtPuesto.Text = dataPuestos.SelectedCells[1].Value.ToString();
            gpControles.Visible = true;
            groupGuardar.Visible = false;

        }

      
    }
}
