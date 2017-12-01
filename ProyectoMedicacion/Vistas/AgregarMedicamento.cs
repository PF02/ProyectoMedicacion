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
    public partial class AgregarMedicamento : Form
    {
        public AgregarMedicamento()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AgregarMedicamento_Load(object sender, EventArgs e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Controles.ControlMedicamento.InsertarMedicamento(textNombreMedicamento.Text, TextFechaExpiracion.Text, TextIndicacionesMedicamento.Text, TextDosisMedicamento.Text, TextContenedorMedicamento.Text);

            Controles.ControlSintoma.AgregarSintomasAMedicamento(ListaSintomas, Clases.Medicamento.IdMedicamento);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubVistas.ComponentesEnAgregarMedicamentos ceam = new SubVistas.ComponentesEnAgregarMedicamentos();
            ceam.Activate();
            ceam.ShowDialog();
        }

        public void AgregarComponenteATabla(string IdCom, string NomCom)
        {
            dataGridView1.Rows.Add(IdCom, NomCom);
        }

        private void AgregarMedicamento_Activated(object sender, EventArgs e)
        {
            if (Clases.Componente.IdComponente<=0)
            {
                //que no haga nada
            }
            
            else
            {
                textBoxComponenteAAgregar.Text = Clases.Componente.NombreComponente;
            }
            
        }

        public bool VerificarExistenciaDeComponenteAgregados()
        {
            bool resultado =false;
            DataGridView Tablatemp = new DataGridView();
            Controles.ControlComponente.LlenarTablaComponentes(Tablatemp);
            int i = -1;
            foreach (DataGridViewRow componentes in dataGridView1.Rows)
            {
                i++;
                if (componentes.Cells[i].Value.ToString() == Clases.Componente.NombreComponente)
                {
                    resultado = true;

                    break;
                }
                else
                {

                    resultado = false;
                    break;
                }

            }

            return resultado;

         }

        private void buttonAgregarComponenteALista_Click(object sender, EventArgs e)
        {
            if (textBoxComponenteAAgregar.Text =="")
            {
                MessageBox.Show("Debe buscar un componente para agregarlo a la lista.", "Busque un Componente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool ExistenciaDeComponente = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    object val = row.Cells[1].Value;
                    if (val.ToString() == textBoxComponenteAAgregar.Text)
                    {
                        MessageBox.Show("Este elemento ya está en al lista.", "El componente está agregado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        ExistenciaDeComponente = true;
                        textBoxComponenteAAgregar.Clear();
                        break;
                    }
                }
                if (!ExistenciaDeComponente)
                {
                    dataGridView1.Rows.Add(Clases.Componente.IdComponente, Clases.Componente.NombreComponente);
                    textBoxComponenteAAgregar.Clear();
                }

            
            }

            
        }

        private void textBoxComponenteAAgregar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxComponenteAAgregar.Text=="")
            {
                buttonAgregarComponenteALista.Enabled = false;
                buttonBuscarComponente.Enabled = true;
            }
            else
            {
                buttonAgregarComponenteALista.Enabled = true;
                buttonBuscarComponente.Enabled = false;
            }
        }
    }
    }

