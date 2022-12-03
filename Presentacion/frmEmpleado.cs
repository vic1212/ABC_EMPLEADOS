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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }
       
       

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
           
        }

   
       
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            MostrarPanelEmpleados();
        }

     

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            MostrarPanelPuestos();
        }

        private void MostrarPanelEmpleados()
        {
            panelVisor.Controls.Clear();
            Empleados emp = new Empleados();
            panelVisor.Controls.Add(emp);
            emp.Show();
        }
        private void MostrarPanelPuestos()
        {
            panelVisor.Controls.Clear();
            Puestos puestos = new Puestos();
            panelVisor.Controls.Add(puestos);
            puestos.Show();
        }
    }
}
