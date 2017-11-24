using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoMedicacion.Controles
{
    class ControlUsuario : ProyectoMedicacion.Clases.Usuario
    {
        public static ProyectoMedicacion.Data_Persistance.Conexion ClaseConexion = new Data_Persistance.Conexion();


        ///////////////////////////////LLENADO DE TABLAS REFERENTES A USUARIO////////////////////////////////// 

        public static void LlenarTablaPersonaEnAgregarUsuario(DataGridView grid)
        {
            string cmd = "SELECT ID_Persona AS 'Id Persona', Nombre_Persona AS 'Nombre' , Apellido_Persona AS 'Apellido' FROM Persona WHERE NOT EXISTS (SELECT *FROM Usuario WHERE Persona.Id_Persona = Usuario.Id_Persona) AND Persona.Tipo_Persona ='Empleado';";
            SqlCommand cm = new SqlCommand(cmd, ClaseConexion.ObtenerCadenaDeConexion());
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
        }

        public static void LlenarTablaUsuariosEnGestionUsuario(DataGridView grid)
        {
            string cmd = "SELECT Persona.Nombre_Persona AS 'Nombre', Persona.Apellido_Persona AS 'Apellido', Usuario.Nombre_Usuario AS 'Usuario', Usuario.Estado_Usuario AS 'Estado', Usuario.Id_Usuario AS'Id Usuario' , Persona.ID_Persona AS 'Id Persona' FROM Persona INNER JOIN Usuario ON Usuario.Id_Persona = Persona.Id_Persona AND Persona.Tipo_Persona='Empleado';";

            SqlCommand cm = new SqlCommand(cmd, ClaseConexion.ObtenerCadenaDeConexion());
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
        }

        /////////////////////METODOS Y PROCEDIMIENTOS DE BASE DE DATOS////////////////////////////////
        public static void AgregarUsuario(string nom, string pass, string sta, string idp)
        {

            try
            {
                ProyectoMedicacion.Data_Persistance.Conexion.ejecutaProcedure("AgregarUsuario",
               new List<System.Data.SqlClient.SqlParameter>(){
               new System.Data.SqlClient.SqlParameter("@NombreU",nom),
               new System.Data.SqlClient.SqlParameter("@ContrasenaU",pass),
               new System.Data.SqlClient.SqlParameter("@EstadoU",sta),
               new System.Data.SqlClient.SqlParameter("@IdP",idp)

          });
            }
            catch (System.Data.SqlClient.SqlException sqlex)
            {
                throw sqlex;
            }
        }

        public static void ActualizarUsuarioyContrasena(string idu, string Nomu, string pass, string esta, string idp)
        {
            try
            {
                ProyectoMedicacion.Data_Persistance.Conexion.ejecutaProcedure("ActualizarUsuario",
               new List<System.Data.SqlClient.SqlParameter>(){
               new System.Data.SqlClient.SqlParameter("@Id_U",idu),
               new System.Data.SqlClient.SqlParameter("@NombreU",Nomu),
               new System.Data.SqlClient.SqlParameter("@ContrasenaU",pass),
               new System.Data.SqlClient.SqlParameter("EstadoU",esta),
               new System.Data.SqlClient.SqlParameter("@IdP",idp)

          });
            }
            catch (System.Data.SqlClient.SqlException sqlex)
            {
                throw sqlex;
            }
        }

        public static void ActualizarUsuarioSinContrasena(string idu, string Nomu, string esta, string idp)
        {
            try
            {
                ProyectoMedicacion.Data_Persistance.Conexion.ejecutaProcedure("ActualizarUsuarioSinContrasena",
               new List<System.Data.SqlClient.SqlParameter>(){
               new System.Data.SqlClient.SqlParameter("@Id_U",idu),
               new System.Data.SqlClient.SqlParameter("@NombreU",Nomu),
               new System.Data.SqlClient.SqlParameter("EstadoU",esta),
               new System.Data.SqlClient.SqlParameter("@IdP",idp)

          });
            }
            catch (System.Data.SqlClient.SqlException sqlex)
            {
                throw sqlex;
            }
        }



    }
}
