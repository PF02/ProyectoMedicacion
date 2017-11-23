using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoMedicacion.Data_Persistance
{
    public class Conexion
    {
        static private SqlCommand comando;

        static public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ProyectoMedicacion\ProyectoMedicacion\Medicacion.mdf;Integrated Security=True; Connect Timeout = 30;MultipleActiveResultSets=True;");

        
        // MultipleActiveResultSets=True; se utiliza para resolver el error: DataReader abierto asociado a un comando

                        
        public static List<object[]> ejecutaProcedure(string nombProcedure, List<SqlParameter> pars)
        {
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = nombProcedure;
            comando.Connection = conn;
            SqlDataReader reader;
            comando.Parameters.Clear();
            try
            {
                comando.Parameters.AddRange(pars.ToArray());
            }
            catch { }
            comando.Connection.Close();
            comando.Connection.Open();

            List<object[]> lista = new List<object[]>();

            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                object[] objetos = new object[reader.FieldCount];
                reader.GetValues(objetos);
                lista.Add(objetos);
            }
            return lista;
        }

        /////////////METODOS AUXILIARES////////////////

        public SqlConnection ObtenerCadenaDeConexion()
        {
            return conn;
        }

        public static void CerrarConexion()
        {
            conn.Close();
        }

        public static void AbrirConexion()
        {
            conn.Open();
        }
    }
}


