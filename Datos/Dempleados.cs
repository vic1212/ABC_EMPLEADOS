using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ABC_EMPLEADOS.Logica;
using System.Windows.Forms;

namespace ABC_EMPLEADOS.Datos
{
    public class Dempleados
    {


        public DataTable CargarComboPuesto()
        {
            CONEXIONSQLSERVER.abrir();
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarComboBoxPuesto", CONEXIONSQLSERVER.conectar);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
           // CONEXIONSQLSERVER.cerrar();

        }

        public DataTable CargarComboEmpresa()
        {
            CONEXIONSQLSERVER.abrir();
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarComboboxEmpresa", CONEXIONSQLSERVER.conectar);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            //CONEXIONSQLSERVER.cerrar();

        }

        public void MostrarEmpleados(ref DataTable dt)
        {
            try
            {
                CONEXIONSQLSERVER.abrir();
                SqlDataAdapter da = new SqlDataAdapter("SP_ConsultarEmpleados", CONEXIONSQLSERVER.conectar);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONSQLSERVER.cerrar();
            }

        }
         public void InsertarEmpleados(Lempleados parametros)
        {
            try
            {
                CONEXIONSQLSERVER.abrir();
                SqlCommand cmd = new SqlCommand("SP_InsertarEmpleado", CONEXIONSQLSERVER.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOMBRE", parametros.Nombre);
                cmd.Parameters.AddWithValue("@APELLIDOS", parametros.Apellidos);
                cmd.Parameters.AddWithValue("@SEXO", parametros.Sexo);
                cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", parametros.Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@FECHA_ALTA", parametros.Fecha_Alta);
                cmd.Parameters.AddWithValue("@ID_PUESTO", parametros.IdPuesto);
                cmd.Parameters.AddWithValue("@DIRECCION", parametros.Direccion);
                cmd.Parameters.AddWithValue("@EMAIL", parametros.Email);
                cmd.Parameters.AddWithValue("@TELEFONO", parametros.Telefono);
                cmd.Parameters.AddWithValue("@ID_EMPRESA", parametros.IdEmpresa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado Registrado");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONSQLSERVER.cerrar();
            }
        }
    }
}
