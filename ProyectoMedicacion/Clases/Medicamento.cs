using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMedicacion.Clases
{
    class Medicamento
    {
        public static int IdMedicamento { get; set; }

        public static string Nombre { get; set; }
        public static DateTime FechaExpiracion {get; set;}
        public static string Indicacion{ get; set;}
        public static string Dosis { get; set; }
        public static string Contededor{ get; set; }
    }
}
