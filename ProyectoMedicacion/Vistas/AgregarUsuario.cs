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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            Controles.ControlUsuario.LlenarTablaPersonaEnAgregarUsuario(dataGridView1);
            

        }

        private void TablaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TablaEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                textIdPersona.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                
                ///CREAR EL NOMBRE DE USUARIO A BASE DE NOMBRE Y APELLIDO////////////
                string IdPersona = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string Apellido = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                char Name = Nombre[0];
                char Lname = Apellido[0];
                string UserName = Name.ToString() + Lname.ToString() + IdPersona;
                textNombreUsuario.Text = UserName.ToUpper();
                ////////////////////////////////END////////////////////////////////
                textBoxNombreApellido.Text = Nombre +" "+Apellido;
            }
                catch(Exception a) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (textNombreUsuario.Text =="" || textIdPersona.Text=="")
                {
                    MessageBox.Show("Seleccione un empleado para asignarle un usuario.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
                else if (textContrasena.Text != textComfirmacionContrasena.Text)
                {
                     MessageBox.Show("Las contraseñas no coinciden.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else
                {
                ProyectoMedicacion.Data_Persistance.Conexion.AbrirConexion();
                Controles.ControlUsuario.AgregarUsuario(textNombreUsuario.Text, textContrasena.Text,TextEstadoUsuario.Text, textIdPersona.Text);

                MessageBox.Show("Usuario Creado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult dialogo = MessageBox.Show("Desea agregar otro Usuario?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogo == DialogResult.Yes)
                {
                    this.Refresh();
                    textContrasena.Clear();
                    textComfirmacionContrasena.Clear();
                    textBoxNombreApellido.Clear();
                    textIdPersona.Clear();
                    textNombreUsuario.Clear();
                    Controles.ControlUsuario.LlenarTablaPersonaEnAgregarUsuario(dataGridView1);
                    ProyectoMedicacion.Data_Persistance.Conexion.CerrarConexion();



                }
                else
                {
                    this.Dispose();

                }

            }
         }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    }

