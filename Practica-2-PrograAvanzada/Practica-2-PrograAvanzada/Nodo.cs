using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_PrograAvanzada
{
    internal class Nodo
    {
        private Persona persona;
        private Nodo siguiente;
        private Nodo anterior;

        public Nodo()
        {
            this.siguiente = null;
            this.anterior = null;
        }

        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }


    }
}
