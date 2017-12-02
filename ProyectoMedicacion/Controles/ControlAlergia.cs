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
    }
}
