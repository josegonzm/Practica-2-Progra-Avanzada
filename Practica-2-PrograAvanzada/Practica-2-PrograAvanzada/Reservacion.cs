using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_PrograAvanzada
{
    internal class Reservacion
    {
        public Hotel Hotel {  get; set; }

        public Habitacion Habitacion { get; set; }

        public string FechaReserva {  get; set; }

        public Persona Persona { get; set; }
    }
}
