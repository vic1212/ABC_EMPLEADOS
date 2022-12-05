using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace ABC_EMPLEADOS.Datos
{
   public class CONEXIONSQLSERVER
    {
        //Clase para hacer la conexion a sql server
        public static string conexion = "Data source=DESKTOP-GR1CKGU; Initial Catalog=bdabc_empleados; Integrated Security=true";
        public static SqlConnection conectar = new SqlConnection(conexion);

        //Metodo para abrir una conexion
        public static void abrir()
        {
            if (conectar.State==ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        //Metodo para cerrar una conexion
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }


    }
}
