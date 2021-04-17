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

            int loopAvion = 0;
            int loopAuto = 0;

            foreach (var item in transportes)
            {

                if (item.GetType().Name.ToString() == "Avion")
                {
                    loopAvion++;
                    Console.WriteLine("Avion {0}: " + item.Obtener_Pasajeros,loopAvion);
                                        
                }
                else
                {
                    loopAuto++;
                    Console.WriteLine("Automovil {0}: " + item.Obtener_Pasajeros, loopAuto);
                }
                
            }
            Console.ReadKey();
        }
        
    }
}

