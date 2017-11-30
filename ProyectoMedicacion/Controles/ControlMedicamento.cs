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
    public class ControlMedicamento
    {
        public static void InsertarMedicamento()
        {
            try
            {
                Data_Persistance.Conexion.CerrarConexion();
                Data_Persistance.Conexion.AbrirConexion();

                SqlCommand cmd = new SqlCommand("AgregarMedicamentoConRetorno", Data_Persistance.Conexion.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                
                

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
