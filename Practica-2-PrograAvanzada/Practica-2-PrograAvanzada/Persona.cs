using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_PrograAvanzada
{
    internal class Persona
    {
        public String Nombre {  get; set; }
        public string PrimerApellido {  get; set; }
        public string SegundoApellido { get; set; }
        public string Cedula {  get; set; }
        public string Nacionalidad {  get; set; }
        public string Telefono {  get; set; }
        public string Correo {  get; set; }
        public string Habitacion {  get; set; }
        public String  Torre { get; set; }
        public String Piso {  get; set; }
        public String Hotel { get; set; }
        public bool Disponibilidad { get; set; }

        public Persona(string nombre, string primerApellido, string segundoApellido, string cedula,String torre,bool Disponibilidad,String Piso,String Hotel, string nacionalidad, string telefono, string correo, string habitacion)
        {
            this.Nombre = nombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
            this.Cedula = cedula;
            this.Nacionalidad = nacionalidad;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Habitacion = habitacion;
            this.Torre = Torre;
            this.Piso = Piso;
            this.Hotel = Hotel;
            this.Disponibilidad = Disponibilidad;



        }
        public Persona()
        {
            this.Nombre = "";
            this.PrimerApellido ="";
            this.SegundoApellido = "";
            this.Cedula = "";
            this.Nacionalidad = "";
            this.Telefono = "";
            this.Correo = "";
            this.Habitacion = "";
            this.Torre = "";
            this.Piso = "";
            this.Hotel = "";
            this.Disponibilidad = true;
        }

    }

}
