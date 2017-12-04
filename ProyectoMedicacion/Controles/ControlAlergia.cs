using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoMedicacion.Controles
{
    public class ControlAlergia
    {
        public static void LlenarTablaAlergias(DataGridView TablaAlergia, string IdPersona )
        {
            Data_Persistance.Conexion.CerrarConexion();
            Data_Persistance.Conexion.AbrirConexion();

            string cmd = "SELECT Componente.Id_Componente, Componente  FROM Componente JOIN Alergia ON Alergia.Id_Componente = Componente.Id_Componente JOIN Persona ON Alergia.Id_Persona = Persona.Id_Persona WHERE Persona.Id_Persona= " + IdPersona + ";";
            SqlCommand cm = new SqlCommand(cmd, Data_Persistance.Conexion.conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TablaAlergia.DataSource = dt;
            Data_Persistance.Conexion.CerrarConexion();

        }

        public static void LlenarTablaTodasLasAlergiasDeUnaPersona(DataGridView Tabla, string IdPersona)
        {
            Data_Persistance.Conexion.CerrarConexion();
            Data_Persistance.Conexion.AbrirConexion();

            string cmd = "SELECT Componente.Id_Componente, Componente FROM Componente JOIN Alergia ON Alergia.Id_Componente = Componente.Id_Componente JOIN Persona ON Alergia.Id_Persona = Persona.Id_Persona WHERE Persona.Id_Persona= " + IdPersona + ";";
            SqlCommand cm = new SqlCommand(cmd, Data_Persistance.Conexion.conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Tabla.DataSource = dt;
            Data_Persistance.Conexion.CerrarConexion();
        }

        public static bool ComprobarExistenciaDeAlergia(string idcomponente, string idpersona)
        {
            try
            {
                SqlCommand ComandoSQL = new SqlCommand("SELECT COUNT(*)FROM Alergia WHERE Id_Componente ='" + idcomponente+ "' AND Id_Persona = '"+idpersona+"';", Data_Persistance.Conexion.conn);

                Data_Persistance.Conexion.CerrarConexion();
                Data_Persistance.Conexion.AbrirConexion();

                var resultado = ComandoSQL.ExecuteScalar();
                int i = Convert.ToInt32(resultado);

                if (i == 0)
                {
                    Data_Persistance.Conexion.CerrarConexion();
                    return false;

                }
                else
                {
                    Data_Persistance.Conexion.CerrarConexion();
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public static void GuardarAlergia(string idpersona, string idcomponente)
        {
            try
            {
                ProyectoMedicacion.Data_Persistance.Conexion.ejecutaProcedure("Insertar_Alergia",
               new List<System.Data.SqlClient.SqlParameter>(){
               new System.Data.SqlClient.SqlParameter("@Id_Persona",idpersona),
               new System.Data.SqlClient.SqlParameter("@Id_Componente",idcomponente)
               

          });
            }
            catch (System.Data.SqlClient.SqlException sqlex)
            {
                throw sqlex;
            }
            finally { Data_Persistance.Conexion.CerrarConexion(); }
        }

        public static void EliminarAlergia(string idpersona, string idcomponente)
        {
            try
            {
                ProyectoMedicacion.Data_Persistance.Conexion.ejecutaProcedure("EliminarAlergia",
               new List<System.Data.SqlClient.SqlParameter>(){
               new System.Data.SqlClient.SqlParameter("@IdPersona",idpersona),
               new System.Data.SqlClient.SqlParameter("@IdComponente",idcomponente)


          });
            }
            catch (System.Data.SqlClient.SqlException sqlex)
            {
                throw sqlex;
            }
            finally { Data_Persistance.Conexion.CerrarConexion(); }

        }
    }
}
