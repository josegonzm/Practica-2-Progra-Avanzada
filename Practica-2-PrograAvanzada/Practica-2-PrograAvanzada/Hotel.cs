using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_PrograAvanzada
{
    internal class Hotel
    {
        //Declaracion de variables
        public string NombreHotel {  get; set; }

        public List<Habitacion>HabitacionesTorre1 { get; set; }

        public List<Habitacion>HabitacionesTorre2 { get; set; }

        public List<Reservacion> ListaReservas {  get; set; }
 
        //Constructor
        public Hotel(string nombrehotel)
        { 
            NombreHotel = nombrehotel;
            this.HabitacionesTorre1 = new List<Habitacion>();
            this.HabitacionesTorre2 = new List<Habitacion>();
            ListaReservas = new List<Reservacion>();
        }
    }
}
