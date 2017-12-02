using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoMedicacion.Controles
{
    public class ControlComponente
    {
        public static void LlenarTablaComponentes(DataGridView tablaComponente)
        {
            string cmd = "SELECT  Id_Componente AS 'Id', Componente AS 'Componentes' FROM Componente;";
            SqlCommand cm = new SqlCommand(cmd, Data_Persistance.Conexion.conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            tablaComponente.DataSource = dt;
           
            
            Data_Persistance.Conexion.CerrarConexion();

        }

       

        public static void InsertarComponente(string Componente)
        {
            
            if (ComprobarExistenciaDeComponente(Componente)== true)
            {
                MessageBox.Show("Este componente ya existe.", "Alerta",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (ComprobarExistenciaDeComponente(Componente)== false)
            {
                try
                {
                    ProyectoMedicacion.Data_Persistance.Conexion.ejecutaProcedure("Insertar_Componente",
                   new List<System.Data.SqlClient.SqlParameter>(){
               new System.Data.SqlClient.SqlParameter("@Componente",Componente)


                    });

                }
                catch (Exception)
                {

                    throw;
                }
                finally { Data_Persistance.Conexion.CerrarConexion(); }
            }
            
           
        }

        public static void InsertarComponenteAMedicamento(DataGridView tablacomponentes, string IdMedi)
        {
            try
            {
                Data_Persistance.Conexion.CerrarConexion();
                Data_Persistance.Conexion.AbrirConexion();
                

                for (int i = 0; i < tablacomponentes.RowCount; i++)
                {
                string cmd = "INSERT INTO Composicion_Medicamento VALUES" +
                        "("+IdMedi+", "+tablacomponentes.Rows[i].Cells["IdComponente"].Value.ToString()+");";

                 SqlCommand comn = new SqlCommand(cmd,Data_Persistance.Conexion.conn);
                    comn.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { Data_Persistance.Conexion.CerrarConexion(); }
        }


        public static bool ComprobarExistenciaDeComponente(string nomComponente)
        {
            try
            {
                SqlCommand ComandoSQL = new SqlCommand("SELECT COUNT(*)FROM Componente WHERE Componente ='"+nomComponente+"';", Data_Persistance.Conexion.conn);

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
    }
}
