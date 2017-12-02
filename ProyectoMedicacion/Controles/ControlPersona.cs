using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedicacion.Controles
{
    public class ControlPersona : ProyectoMedicacion.Clases.Persona
    {
        
        public static void LlenarTablaPersonaEnAlergias(DataGridView TablaPersona)
        {
            Data_Persistance.Conexion.CerrarConexion();
            Data_Persistance.Conexion.AbrirConexion();

            string cmd = "SELECT * FROM Persona";
            SqlCommand cm = new SqlCommand(cmd, Data_Persistance.Conexion.conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TablaPersona.DataSource = dt;
            Data_Persistance.Conexion.CerrarConexion();

        }

    }
}
