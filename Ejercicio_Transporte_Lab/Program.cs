using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Transporte_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Transporte> transportes = new List<Transporte> // Estoy creando una lista de objetos de mi clase Transporte llamada transportes.
            {
                new Avion(100),              
                new Avion(30),
                new Avion(10),
                new Avion(80),
                new Avion(60),
               
                new Automovil(4),
                new Automovil(2),
                new Automovil(10),
                new Automovil(8),
                new Automovil(6)
            };

            int Cantidad_Avion = 0;
            int Cantidad_Auto = 0;

            foreach (var item in transportes)
            {

                if (item.GetType().Name.ToString() == "Avion")
                {
                    Cantidad_Avion++;
                    Console.WriteLine("Avion {0}: " + item.Obtener_Pasajeros + " pasajeros",Cantidad_Avion);
                                        
                }
                else
                {
                    Cantidad_Auto++;
                    Console.WriteLine("Automovil {0}: " + item.Obtener_Pasajeros + " pasajeros", Cantidad_Auto);
                }
                
            }
            Console.ReadKey();
        }
        
    }
}

