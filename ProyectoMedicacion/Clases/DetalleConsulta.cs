using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMedicacion.Clases
{
    public class DetalleConsulta
    {
        public static int IdDetalleConsulta { get; set; }
        public static int IdConsultaMedica { get; set; }
        public static List<int> IdSintoma { get; set; }
    }
}
