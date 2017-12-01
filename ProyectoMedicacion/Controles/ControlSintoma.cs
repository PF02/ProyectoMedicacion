using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoMedicacion.Controles
{
    public class ControlSintoma
    {
        public static void AgregarSintomasAMedicamento(CheckedListBox CheckSintomas, int IdMedicamento)
        {
            try
            {
                Data_Persistance.Conexion.CerrarConexion();
                Data_Persistance.Conexion.AbrirConexion();
                

                

                for (int i = 1; i < CheckSintomas.Items.Count + 1; i++)
                {
                    if (CheckSintomas.GetItemChecked(i - 1) == true)
                    {
                        SqlCommand cm = new SqlCommand("Insertar_Sintoma_Medicamento", Data_Persistance.Conexion.conn);
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.Add(new SqlParameter("@Id_Sintoma", i));
                        cm.Parameters.Add(new SqlParameter(@"Id_Medicamento", IdMedicamento));

                        cm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { Data_Persistance.Conexion.CerrarConexion(); }
            
        
        }
    }
}
