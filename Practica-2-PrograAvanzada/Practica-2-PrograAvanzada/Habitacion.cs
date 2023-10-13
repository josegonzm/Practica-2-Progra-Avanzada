using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_PrograAvanzada
{
    internal class Habitacion
    {
        public int Piso {  get; set; }

        public int NumeroHabitacion {  get; set; }

        public int Torre {  get; set; }

        public Habitacion()
        {
            
        }

        public Habitacion(int piso, int numerohabitacion, int torre)
        {
            piso = Piso;
            numerohabitacion = NumeroHabitacion;
            torre = Torre;
        }
    }
}
