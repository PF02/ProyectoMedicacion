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
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            ProyectoMedicacion.Controles.ControlUsuario.LlenarTablaUsuariosEnGestionUsuario(TablaUsuarios);
        }

        public void LlenarCheckPermisos()
        {
            bool ModuloUsuarios = Controles.ControlPermiso.ComprobarPermisosUsuario(textNombreUsuario.Text, "Usuarios", textIdUsuario.Text);

            if ( ModuloUsuarios == true)
            {
                ListPermisos.SetItemChecked(0, true);
            }
            else
            {
                ListPermisos.SetItemChecked(0, false);
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void TablaUsuarios_Click(object sender, EventArgs e)
        {
            textNombreEmpleado.Text = TablaUsuarios.CurrentRow.Cells[0].Value.ToString() +" "+TablaUsuarios.CurrentRow.Cells[1].Value.ToString(); 
            textNombreUsuario.Text = TablaUsuarios.CurrentRow.Cells[2].Value.ToString();
            textEstadoUsuario.Text = TablaUsuarios.CurrentRow.Cells[3].Value.ToString();
            textIdUsuario.Text= TablaUsuarios.CurrentRow.Cells[4].Value.ToString();
            textIdPersona.Text = TablaUsuarios.CurrentRow.Cells[5].Value.ToString();
            LlenarCheckPermisos();
        }
    }
}
