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

            Console.Write("Ingrese el nombre del cliente a reservar: ");
            String nombreCliente = Console.ReadLine();
            l.Persona.Nombre = nombreCliente;

            Console.Write("Digite el apellido: ");
            String apellido = Console.ReadLine();
            l.Persona.PrimerApellido = apellido;

            Console.Write("Digite el Segundo Apellido: ");
            String segundoApellido = Console.ReadLine();
            l.Persona.SegundoApellido = segundoApellido;

            Console.Write("Digite la cedula: ");
            String cedula = Console.ReadLine();
            l.Persona.Cedula = cedula;

            Console.WriteLine("Digite el nombre del hotel a hacer la reservacion: ");
            string nombreHotel = Console.ReadLine();
            l.Hotel.NombreHotel = nombreHotel;

            Console.WriteLine("Digite el numero de torre a realizar la reservacion: ");
            String numTorre = Console.ReadLine();
            int NumeroTorre;
            int.TryParse(numTorre, out NumeroTorre);
            l.Habitacion.Torre = NumeroTorre;
            try
            {
                if (NumeroTorre == 1)
                {
                    Console.WriteLine("Ingrese el numero de piso donde quiere reservar");
                    String numPiso = Console.ReadLine();
                    int NumeroPiso;
                    int.TryParse(numPiso, out NumeroPiso);
                    l.Habitacion.Piso = NumeroPiso;

                    Console.WriteLine("Ingrese la habitacion donde quiere reservar: ");
                    String numHabitacion = Console.ReadLine();
                    int NumeroHabitacion;
                    int.TryParse(numHabitacion, out NumeroHabitacion);
                    l.Habitacion.NumeroHabitacion = NumeroHabitacion;

                    Console.WriteLine("Ingrese la fecha que desea reservar: ");
                    String fechaReserva = Console.ReadLine();
                    l.FechaReserva = fechaReserva;
                }
                if (NumeroTorre == 2)
                {
                    Console.WriteLine("Ingrese el numero de piso donde quiere reservar");
                    String numPiso = Console.ReadLine();
                    int NumeroPiso;
                    int.TryParse(numPiso, out NumeroPiso);
                    l.Habitacion.Piso = NumeroPiso;

                    Console.WriteLine("Ingrese la habitacion donde quiere reservar: ");
                    String numHabitacion = Console.ReadLine();
                    int NumeroHabitacion;
                    int.TryParse(numHabitacion, out NumeroHabitacion);
                    l.Habitacion.NumeroHabitacion = NumeroHabitacion;

                    Console.WriteLine("Ingrese la fecha que desea reservar: ");
                    String fechaReserva = Console.ReadLine();
                    l.FechaReserva = fechaReserva;
                }
            }catch (Exception ex1)
            {
                Console.WriteLine("Numero de Torre no valido");
            }
            

            Nodo nuevo = new Nodo();
            nuevo.Reservacion = l;

            if (Vacia())
            {
                inicio = nuevo;
                fin = nuevo;
                fin.Siguiente = inicio;
                inicio.Anterior = fin;
            }
            else if (string.Compare(l.Persona.Cedula, inicio.Persona.Cedula) < 0)
            {
                nuevo.Siguiente = inicio;
                inicio = nuevo;
                fin.Siguiente = inicio;
                inicio.Anterior = fin;
            }
            else if (string.Compare(l.Persona.Cedula, fin.Persona.Cedula) > 0)
            {
                fin.Siguiente = nuevo;
                fin = fin.Siguiente;
                fin.Siguiente = inicio;
                inicio.Anterior = fin;
            }
            else
            {
                Nodo aux = inicio;
                while (string.Compare(aux.Siguiente.Persona.Cedula, l.Persona.Cedula) < 0)
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
