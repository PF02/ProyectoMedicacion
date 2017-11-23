using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMedicacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new ProyectoMedicacion.Vistas.AgregarUsuario());
            
            //Application.Run(new Login());
           Application.Run(new ProyectoMedicacion.Vistas.GestionUsuarios());
            //Application.Run(new ProyectoMedicacion.Vistas.Home());
        }
    }
}
