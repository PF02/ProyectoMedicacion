using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedicacion.Controles
{
    public class ControlPermiso
    {
        public List<string> LPermisos = new List<string>();
        public static List<string> PermisosUsuario;



        public void CargarPermisosUsuario()
        {
            Controles.ControlPermiso P= new ControlPermiso();
            int a = Convert.ToInt32(Clases.Usuario.IdUsuario);
            try
            {
               
                //P.LPermisos.Clear();
                P.LPermisos = new List<string>();
                SqlCommand comm = new SqlCommand("SELECT permiso.Nombre_Permiso FROM Permiso JOIN Permiso_Usuario ON Permiso_Usuario.Id_Permiso = Permiso.Id_Permiso WHERE Permiso_Usuario.Id_Usuario ='"+a+"';", Data_Persistance.Conexion.conn);

                SqlDataReader reader = comm.ExecuteReader();


                while (reader.Read())
                {
                    P.LPermisos.Add(reader.GetString(0));

                }               
                    PermisosUsuario = P.LPermisos;
                
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Data_Persistance.Conexion.CerrarConexion();
            }


        }

        public static bool ComprobarPermisosUsuario(string NUsu, string NPerm, string IdUsu)
        {
            Data_Persistance.Conexion.CerrarConexion();
            Data_Persistance.Conexion.AbrirConexion();

            string Sentencia = "SELECT COUNT(*) FROM Permiso_Usuario INNER JOIN Usuario ON Permiso_Usuario.Id_Usuario = Usuario.Id_Usuario INNER JOIN Permiso ON Permiso_Usuario.Id_Permiso = Permiso.Id_Permiso WHERE Nombre_Permiso = '"+NPerm+"' AND  Nombre_Usuario = '"+NUsu+"' AND Permiso_Usuario.Id_Usuario ='"+IdUsu+"';";
            SqlCommand Comando = new SqlCommand(Sentencia, Data_Persistance.Conexion.conn);
            var resultado = Comando.ExecuteScalar();
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




    }
}
