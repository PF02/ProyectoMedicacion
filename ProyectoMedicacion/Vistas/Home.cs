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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void DesbloquearModulos()
        {
            //string Modulo = Controles.ControlPermiso.PermisosUsuario[0].ToString();
            int totalpermisos = Controles.ControlPermiso.PermisosUsuario.Count();
            for (int i = 0; i < totalpermisos; i++)
            {
                if (Controles.ControlPermiso.PermisosUsuario[i] == "Módulo de Usuarios")
                {
                    panelUsuarios.Enabled = true;
                }

                if (Controles.ControlPermiso.PermisosUsuario[i] == "Módulo de Personas y Alergias")
                {
                    panelPersonasAlergias.Enabled = true;
                }

                if (Controles.ControlPermiso.PermisosUsuario[i] == "Módulo de Medicamentos y Composión")
                {
                    panelMedicamentosComposicion.Enabled = true;
                }

                if (Controles.ControlPermiso.PermisosUsuario[i] == "Módulo de Consulta Médica")
                {
                    panelConsultaMedica.Enabled = true;
                }

                if (Controles.ControlPermiso.PermisosUsuario[i] == "Módulo de Proveedores")
                {
                    panelProveedores.Enabled = true;
                }
                if (Controles.ControlPermiso.PermisosUsuario[i] == "Módulo de Compras")
                {
                    panelCompras.Enabled = true;
                }

            }

        }


        private void Home_Load(object sender, EventArgs e)
        {
           Controles.ControlPermiso cp = new Controles.ControlPermiso();
           cp.CargarPermisosUsuario();
           DesbloquearModulos();

        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            Vistas.AgregarUsuario au = new Vistas.AgregarUsuario();
            au.ShowDialog();
            
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vistas.GestionUsuarios gu = new Vistas.GestionUsuarios();
            gu.ShowDialog();

        }
    }
}
