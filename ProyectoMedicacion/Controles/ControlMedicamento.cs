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
        
        public static void InsertarMedicamento(string NomMedic, string fechaEx, string Indica, string dosis, string Contenedor)
        {
            try
            {
                Data_Persistance.Conexion.CerrarConexion();
                Data_Persistance.Conexion.AbrirConexion();

                SqlCommand cmd = new SqlCommand("AgregarMedicamentoConRetorno", Data_Persistance.Conexion.conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Nombre_Medicamento", NomMedic));
                cmd.Parameters.Add(new SqlParameter(@"Fecha_Expiracion",fechaEx));
                cmd.Parameters.Add(new SqlParameter(@"Indicacion", Indica));
                cmd.Parameters.Add(new SqlParameter(@"Dosis", dosis));
                cmd.Parameters.Add(new SqlParameter(@"Contenedor_Medicamento", Contenedor));
                ///proceso para poder obtener ID DEL MEDICAMENTO//
                SqlParameter ReturnValue = new SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int);
                ReturnValue.Direction = System.Data.ParameterDirection.ReturnValue;
                ///FIN///
                cmd.Parameters.Add(ReturnValue);
                
                cmd.ExecuteNonQuery();

               Clases.Medicamento.IdMedicamento = (int)cmd.Parameters["@RETURN_VALUE"].Value;

             
            }
            catch (Exception)
            {

                throw;
            }
            finally { Data_Persistance.Conexion.CerrarConexion(); }
        }

    }
}
