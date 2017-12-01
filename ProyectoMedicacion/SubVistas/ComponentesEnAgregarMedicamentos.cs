using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedicacion.SubVistas
{
    public partial class ComponentesEnAgregarMedicamentos : Form
    {
        public ComponentesEnAgregarMedicamentos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clases.Componente.IdComponente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Clases.Componente.NombreComponente = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.Close();
            
        }

        private void ComponentesEnAgregarMedicamentos_Load(object sender, EventArgs e)
        {
            Controles.ControlComponente.LlenarTablaComponentes(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textNombreNuevoComponente.Text=="")
            {
                MessageBox.Show("Rellene el campo vacio.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                              
            Controles.ControlComponente.InsertarComponente(textNombreNuevoComponente.Text);
            Controles.ControlComponente.LlenarTablaComponentes(dataGridView1);
                textNombreNuevoComponente.Clear();
            }
            
        }

        private void ComponentesEnAgregarMedicamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vistas.AgregarMedicamento am = new Vistas.AgregarMedicamento();
            am.Activate();
        }
    }
}
