using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ABC_EMPLEADOS.Presentacion;

namespace ABC_EMPLEADOS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// Pasos para ejecutar la aplicacion.
        /// 1 - Cargar el backup de la carpeta db a la base de datos de sql server
        /// 2 - Ejecutar el proyecto.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmEmpleado());
        }
    }
}
