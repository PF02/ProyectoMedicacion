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
    public partial class AlergiasPersonas : Form
    {
        public AlergiasPersonas()
        {
            InitializeComponent();
        }

        private void AlergiasPersonas_Load(object sender, EventArgs e)
        {
            

        }

        private void textIdPersona_TextChanged(object sender, EventArgs e)
        {
            Controles.ControlAlergia.LlenarTablaAlergias(TablaAlergiasPersona, textIdPersona.Text);
        }

        private void buttonBuscarPersona_Click(object sender, EventArgs e)
        {
            SubVistas.PersonasEnAlergias pea = new SubVistas.PersonasEnAlergias();
            pea.ShowDialog();
            pea.Activate();
        }

        private void AlergiasPersonas_Activated(object sender, EventArgs e)
        {
            if (Clases.Alergia.IdPersona <=0)
            {
                //Que no se cargen los datos de la persona
            }
            else
            {
                textIdPersona.Text = Clases.Alergia.IdPersona.ToString();
                textBoxNombrePersona.Text = Clases.Alergia.NombrePersona;
            }
            if (Clases.Componente.IdComponente <=0)
            {
                //Que no se cargen los datos del componente
                
            }
            else
            {
                textBoxNombreComponente.Text = Clases.Componente.NombreComponente;
                textBoxIdComponente.Text = Clases.Componente.IdComponente.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubVistas.ComponentesEnAgregarMedicamentos ceam = new SubVistas.ComponentesEnAgregarMedicamentos();
            ceam.ShowDialog();
            ceam.Activate();
        }

        private void AlergiasPersonas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clases.Alergia.IdPersona = 0;
            Clases.Componente.IdComponente = 0;
            
        }
    }
}
