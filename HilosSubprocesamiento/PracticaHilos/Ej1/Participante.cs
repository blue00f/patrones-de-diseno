using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    public class Participante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Pais { get; set; }
        public TimeSpan TiempoRegistrado { get; set; }
        public int PosicionDentroDelEquipo { get; set; }
        public int PosicionClasificacionGeneral { get; set; }
        public Participante(string nombre, string apellido, string pais)
        {
            Nombre = nombre;
            Apellido = apellido;
            Pais = pais;
        }
    }
}
