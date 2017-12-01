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
            bool ModuloUsuarios = Controles.ControlPermiso.ComprobarPermisosUsuario(textNombreUsuario.Text, "Módulo de Usuarios", textIdUsuario.Text);

            bool ModuloPersonas= Controles.ControlPermiso.ComprobarPermisosUsuario(textNombreUsuario.Text, "Módulo de Personas", textIdUsuario.Text);

            bool ModuloMedicamentoComposicion = Controles.ControlPermiso.ComprobarPermisosUsuario(textNombreUsuario.Text, "Módulo de Medicamentos y Composión", textIdUsuario.Text);

            bool ModuloConsultaMedica = Controles.ControlPermiso.ComprobarPermisosUsuario(textNombreUsuario.Text, "Módulo de Consulta Médica", textIdUsuario.Text);

            bool ModuloProveedores = Controles.ControlPermiso.ComprobarPermisosUsuario(textNombreUsuario.Text, "Módulo de Proveedores", textIdUsuario.Text);

            bool ModuloCompras= Controles.ControlPermiso.ComprobarPermisosUsuario(textNombreUsuario.Text, "Módulo de Compras", textIdUsuario.Text);

            bool ModuloInventario = Controles.ControlPermiso.ComprobarPermisosUsuario(textNombreUsuario.Text, "Módulo de Inventario", textIdUsuario.Text);

            ////////////////////////////////////////////////////////////////////////
            if ( ModuloUsuarios == true)
            {
                ListPermisos.SetItemChecked(0, true);
            }
            else
            {
                ListPermisos.SetItemChecked(0, false);
            }
            /////////////////////////////////////////////////////////////////////
            if (ModuloPersonas == true)
            {
                ListPermisos.SetItemChecked(1, true);
            }
            else
            {
                ListPermisos.SetItemChecked(1, false);
            }
            /////////////////////////////////////////////////////////////////////
            if (ModuloMedicamentoComposicion == true)
            {
                ListPermisos.SetItemChecked(2, true);
            }
            else
            {
                ListPermisos.SetItemChecked(2, false);
            }
            /////////////////////////////////////////////////////////////////////
            if (ModuloConsultaMedica == true)
            {
                ListPermisos.SetItemChecked(3, true);
            }
            else
            {
                ListPermisos.SetItemChecked(3, false);
            }
            /////////////////////////////////////////////////////////////////////
            if (ModuloProveedores == true)
            {
                ListPermisos.SetItemChecked(4, true);
            }
            else
            {
                ListPermisos.SetItemChecked(4, false);
            }
            /////////////////////////////////////////////////////////////////////
            if (ModuloCompras == true)
            {
                ListPermisos.SetItemChecked(5, true);
            }
            else
            {
                ListPermisos.SetItemChecked(5, false);
            }
            if (ModuloInventario== true)
            {
                ListPermisos.SetItemChecked(6, true);
            }
            else
            {
                ListPermisos.SetItemChecked(6, false);
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

        public void ActualizarPermisos()
        {
            Controles.ControlPermiso.ActualizarPermisosEnBase(ListPermisos, textIdUsuario.Text);
            LlenarCheckPermisos();
        }
        public void LimpiarCampos()
        {
            textIdPersona.Clear();
            textIdUsuario.Clear();
            textNombreEmpleado.Clear();
            textNombreUsuario.Clear();
            textContrasena.Clear();
            textConfirmacionCon.Clear();
            radioButtonNO.Checked = true;
            for (int i = 0; i < ListPermisos.Items.Count; i++)
            {
                ListPermisos.SetItemChecked(i, false);
            }
        }
        private void buttonGuardarCambios_Click(object sender, EventArgs e)
        {
            ////////////////VALIDACIONES////////////////////////
            if (textNombreEmpleado.Text == "" || textIdPersona.Text == "")
            {
                MessageBox.Show("Seleccione un empleado para modificar sus credenciales.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textContrasena.Text != textConfirmacionCon.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //////////////////////PROCESO DE ACTUALIZAR EL USUARIO//////////////////////////
            else if (radioButtonNO.Checked == true && radioButtonSI.Checked == false)
            {
                ///SE ACTUALIZA EL USUARIO SIN CONTRASENA
                ProyectoMedicacion.Data_Persistance.Conexion.AbrirConexion();

                Controles.ControlUsuario.ActualizarUsuarioSinContrasena(textIdUsuario.Text, textNombreUsuario.Text, textEstadoUsuario.Text, textIdPersona.Text);

                MessageBox.Show("Usuario Actualizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ProyectoMedicacion.Controles.ControlUsuario.LlenarTablaUsuariosEnGestionUsuario(TablaUsuarios);
                ActualizarPermisos();
                LimpiarCampos();
                ProyectoMedicacion.Data_Persistance.Conexion.CerrarConexion();
            }
            else if (radioButtonNO.Checked == false && radioButtonSI.Checked == true)
            {
                //SE ACTUALIZA EL USUARIO CON CONTRASENA
                ProyectoMedicacion.Data_Persistance.Conexion.AbrirConexion();

                Controles.ControlUsuario.ActualizarUsuarioyContrasena(textIdUsuario.Text, textNombreUsuario.Text, textContrasena.Text, textEstadoUsuario.Text, textIdPersona.Text);

                MessageBox.Show("Usuario Actualizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ProyectoMedicacion.Controles.ControlUsuario.LlenarTablaUsuariosEnGestionUsuario(TablaUsuarios);
                ActualizarPermisos();
                LimpiarCampos();

                ProyectoMedicacion.Data_Persistance.Conexion.CerrarConexion();
            }
            

        }

        private void radioButtonSI_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSI.Checked == true)
            {
                textContrasena.Enabled = true;
                textConfirmacionCon.Enabled = true;
            }
            else
            {
                textContrasena.Enabled = false;
                textConfirmacionCon.Enabled = false;
            }
        }

        private void radioButtonNO_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNO.Checked == true)
            {
                textContrasena.Enabled = false;
                textConfirmacionCon.Enabled = false;
                
            }
            else
            {
                textContrasena.Enabled = true;
                textConfirmacionCon.Enabled = true;
            }
        }

        private void GestionUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vistas.Home h = new Home();
            h.Activate();
        }

        private void TablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
