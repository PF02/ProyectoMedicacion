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
                if (Controles.ControlPermiso.PermisosUsuario[i] == "Usuarios")
                {
                 buttonUsuarios.Enabled = true;
                }
            }

        }


        private void Home_Load(object sender, EventArgs e)
        {
           Controles.ControlPermiso cp = new Controles.ControlPermiso();
           cp.CargarPermisosUsuario();
           DesbloquearModulos();

        }
    }
}
