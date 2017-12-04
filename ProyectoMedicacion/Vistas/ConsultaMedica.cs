using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedicacion.Vistas
{
    public partial class ConsultaMedica : Form
    {
        public ConsultaMedica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubVistas.PersonasEnAlergias spea = new SubVistas.PersonasEnAlergias();
            spea.ShowDialog();
            spea.Activate();
        }

        private void ConsultaMedica_Activated(object sender, EventArgs e)
        {
            if (Clases.Alergia.IdPersona <= 0)
            {
                //Que no se cargen los datos de la persona
            }
            else
            {
                textIdPersona.Text = Clases.Alergia.IdPersona.ToString();
                textBoxNombrePersona.Text = Clases.Alergia.NombrePersona;
                
            }
        }

        private void textIdPersona_TextChanged(object sender, EventArgs e)
        {
            Controles.ControlAlergia.LlenarTablaTodasLasAlergiasDeUnaPersona(dataGridView1, textIdPersona.Text);
        }
    }
}
