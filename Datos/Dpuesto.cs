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
   public class Dpuesto
    {

        //Metodo para mostrar puestos
        public void MostrarPuestos(ref DataTable dt)
        {
            try
            {
                CONEXIONSQLSERVER.abrir();
                SqlDataAdapter da = new SqlDataAdapter("SP_ConsultarPuestos", CONEXIONSQLSERVER.conectar);
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

        //Metodo para insertar puestos
        public void Insertarpuesto(Lpuestos parametros)
        {
            try
            {
                CONEXIONSQLSERVER.abrir();
                SqlCommand cmd = new SqlCommand("SP_InsertarPuesto", CONEXIONSQLSERVER.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PUESTO", parametros.Puesto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Puesto Registrado");
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

        //Metodo para editar puestos
        public void Editarpuesto(Lpuestos parametros)
        {
            try
            {
                CONEXIONSQLSERVER.abrir();
                SqlCommand cmd = new SqlCommand("SP_EditarPuesto", CONEXIONSQLSERVER.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_PUESTO", parametros.IdPuesto);
                cmd.Parameters.AddWithValue("@PUESTO", parametros.Puesto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Puesto Actualizado");
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

        //Metodo para eliminar puestos
        public void Eliminarpusto(Lpuestos parametros)
        {
            try
            {
                CONEXIONSQLSERVER.abrir();
                SqlCommand cmd = new SqlCommand("SP_EliminarPuesto", CONEXIONSQLSERVER.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Puesto", parametros.IdPuesto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Puesto Eliminado");
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
    }
}
