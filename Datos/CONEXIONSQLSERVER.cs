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
        //Nunca va a cambar static
        public static string conexion = "Data source=DESKTOP-GR1CKGU; Initial Catalog=bdabc_empleados; Integrated Security=true";
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if (conectar.State==ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }


    }
}
