using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_PrograAvanzada
{
    internal class Menu
    {
        public void MostrarMenu()
        {

            while (true)
            {
                Console.WriteLine("Menu Hoteles \n" +
                    "1- Listar Hoteles  \n" +
                    "2- Listar habitaciones disponibles por hotel ?\n" +
                    "3- Registrar reservación a cliente automáticamente \n" +
                    "4- Registrar reservación a cliente manualmente \n" +
                    "5- Eliminar reservación ?\n" +
                    "6- Eliminar todas las reservaciones por hotel ?\n" +
                    "7- Buscar persona por número de cédula o pasaporte \n" +
                    "8- Validar disponibilidad de habitación en hotel \n" +
                    "9- Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        
                        break;
                    case "2":
                        subMenuOpcion2();
                        break;
                    case "3":
                        
                        break;
                    case "4":
                        
                        String nombreHotel = Console.ReadLine();
                        switch (nombreHotel)
                        {
                            case "Hotel New York":
                                
                                break;

                            case "Hotel Continental de Roma":

                                break;
                            case "Hotel Continental de Marruecos":

                                break;

                            case "Hotel Continental de Osaka Tokio":
                                break;

                            default:
                                Console.WriteLine("El hotel seleccionado no existe");
                                break;
                        }

                        break;
                    case "5":
                        Console.WriteLine("Opcion 5");
                        break;
                    case "6":
                        Console.WriteLine("Opcion 6");
                        break;
                    case "7":
                        Console.WriteLine("Opcion 7");
                        break;
                    case "8":
                        Console.WriteLine("Opcion 8");
                        break;
                    case "9":
                        Console.WriteLine("Hasta luego");
                        return;
                    default:
                        Console.WriteLine("Incorrecto");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        private void subMenuOpcion2()
        {
            while (true)
            {
                Console.WriteLine("Submenú #1 \n" +
                    "1- Listar Hotel Continental de New York\n" +
                    "2- Listar Hotel Continental de Roma\n" +
                    "3- Listar Hotel Continental de Marruecos\n" +
                    "4- Listar Hotel Continental de Osaka Tokyo\n" +
                    "5- Listar todos los hoteles\n" +
                    "6- Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                       
                        break;
                    case "2":
                        
                        break;
                    case "3":
                        
                        break;
                    case "4":
                        
                        break;
                    case "5":
                        
                        break;

                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
