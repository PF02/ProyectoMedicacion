using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoMedicacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //INSTANCIA CLASE CONEXION//
        ProyectoMedicacion.Data_Persistance.Conexion ClaseConexion= new Data_Persistance.Conexion();
        //
        public void MensajeBienvienida()
        {
            try
            {
                SqlConnection Con = ClaseConexion.ObtenerCadenaDeConexion();
                Con.Close();
                Con.Open();

                SqlCommand ComandoSQL2 = new SqlCommand("SELECT Nombre_Persona, Apellido_Persona from Persona, Usuario WHERE Usuario.Id_Persona = '" + Convert.ToInt32(Clases.Usuario.IdPersona) + "' AND Persona.Id_Persona = '" + Clases.Usuario.IdPersona + "'", Con);
                              
                ComandoSQL2.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(ComandoSQL2);
                da.Fill(ds, "Usuario");
                DataRow dro;
                dro = ds.Tables["Usuario"].Rows[0];
                    
                string NombreEmpleado = dro["Nombre_Persona"].ToString() +" "+dro["Apellido_Persona"];

                MessageBox.Show("Bienvenido, "+NombreEmpleado+"", "Usuario Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = ClaseConexion.ObtenerCadenaDeConexion();
            Controles.ControlPermiso Permiso = new Controles.ControlPermiso();
            
            try
            {
                SqlCommand ComandoSQL = new SqlCommand("SELECT * FROM Usuario WHERE Nombre_Usuario ='" + textBoxUsuario.Text + "' AND Contrasena_Usuario ='" + textBoxContrasena.Text + "'", Conexion);

                Conexion.Close();
                Conexion.Open();

                ComandoSQL.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(ComandoSQL);
                da.Fill(ds, "Usuario");
                DataRow dro;
                dro = ds.Tables["Usuario"].Rows[0];
               

                //////////////////////////////////////VER SI EL USUARIO ESTA ACTIVO/////////////////////////////////

                if (dro["Estado_Usuario"].ToString() == "Inactivo")
                {
                    MessageBox.Show("Este Usuario está bloqueado. Consulte al Administrador del Sistema.", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                //////////////////////////////////////////COMPROBAR DATOS DEL USUARIO/////////////////////////////////
                else if (textBoxUsuario.Text == dro["Nombre_Usuario"].ToString() || (textBoxContrasena.Text == dro["Contrasena_Usuario"].ToString() ))
                {
                                   //PASAR VALORES DEL USUARIO DESDE LA BASE DE DATOS A LA CLASE LOCAL//
                    Clases.Usuario.IdUsuario = Convert.ToInt32(dro["Id_Usuario"].ToString());
                    Clases.Usuario.Nombre = dro["Nombre_Usuario"].ToString();
                    Clases.Usuario.Contrasena = dro["Contrasena_Usuario"].ToString();
                    Clases.Usuario.Estado = dro["Estado_Usuario"].ToString();
                    Clases.Usuario.IdPersona = Convert.ToInt32(dro["Id_Persona"].ToString());
                                                    
                    MensajeBienvienida();
                    Vistas.Home h = new Vistas.Home();
                    h.Show();
                    this.Hide();
                               

                }
                                                          
                
                //////////////////////////////////////////////////RESULTADO FINAL///////////////////////////////////////
                else
                {
                    MessageBox.Show("Nombre de Usuario no existe o Contraseña incorrecta.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString(), "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                   MessageBox.Show("Nombre de Usuario no existe o Contraseña incorrecta.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw ex;
            }
            finally { Conexion.Close(); textBoxContrasena.Clear(); }



        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
