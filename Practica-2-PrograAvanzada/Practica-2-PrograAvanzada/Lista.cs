using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_PrograAvanzada
{
    internal class Lista
    {

        private Nodo inicio;
        private Nodo fin;

        public Lista()
        {
            this.inicio = null;
            this.fin = null;
        }

        public bool Vacia()
        {
            return inicio == null;
        }

        public void InsertarReserva()
        {
                Reservacion l = new Reservacion();

            Console.Write("Ingrese el cliente a reservar: ");
            l.Persona.Nombre = Console.ReadLine();

            Console.Write("Digite el apellido: ");
            l.PrimerApellido = Console.ReadLine();

            Console.Write("Digite el Segundo Apellido: ");
            l.SegundoApellido = Console.ReadLine();

            Console.Write("Digite la cedula: ");
            l.Cedula = Console.ReadLine();

            Console.Write("Digite la cedula: ");
            l.Cedula = Console.ReadLine();


            Nodo nuevo = new Nodo();
            nuevo.Persona = l;

            if (Vacia())
            {
                inicio = nuevo;
                fin = nuevo;
                fin.Siguiente = inicio;
                inicio.Anterior = fin;
            }
            else if (string.Compare(l.Cedula, inicio.Persona.Cedula) < 0)
            {
                nuevo.Siguiente = inicio;
                inicio = nuevo;
                fin.Siguiente = inicio;
                inicio.Anterior = fin;
            }
            else if (string.Compare(l.Cedula, fin.Persona.Cedula) > 0)
            {
                fin.Siguiente = nuevo;
                fin = fin.Siguiente;
                fin.Siguiente = inicio;
                inicio.Anterior = fin;
            }
            else
            {
                Nodo aux = inicio;
                while (string.Compare(aux.Siguiente.Persona.Cedula, l.Cedula) < 0)
                {
                    aux = aux.Siguiente;
                }
                nuevo.Siguiente = aux.Siguiente;
                nuevo.Anterior = aux;
                aux.Siguiente = nuevo;
                nuevo.Siguiente.Anterior = nuevo;
            }
        }
        public bool BuscarCliente()
        {
            Nodo actual = inicio;

            Console.Write("Ingrese el nombre del cliente que quiere buscar: ");
            string buscarNombre = Console.ReadLine();

            if (inicio != null)
            {
                do
                {
                    if (actual.Persona.Nombre.Equals(buscarNombre, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Nombre: {actual.Persona.Nombre} {actual.Persona.PrimerApellido}\nCedula: {actual.Persona.Cedula}");
                        return true;
                    }

                    actual = actual.Siguiente;
                } while (actual != inicio);
            }
            else
            {
                Console.WriteLine("Lista vacia");
                return false;
            }

            return false;
        }




    }





}
