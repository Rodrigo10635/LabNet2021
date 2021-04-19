using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_métodos_excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio1");
            try
            {

                Random random = new Random();

                int numero = random.Next(1, 100000);
                Console.Write("\nSe generará un número aleatorio para poder realizar la división: ");
                Console.WriteLine(numero);

                int numero1 = numero;

                Console.Write("\nIngrese un número: ");
                int numero2 = int.Parse(Console.ReadLine()); 

                operacion op = new operacion(); 

                op.dividir(numero1, numero2);

            }
            catch (FormatException ex)
            {

                Console.WriteLine("\nHa ingresado una letra o ha dejado el espacio en blanco");
                Console.WriteLine(ex.Message);
                

            }
            finally
            {
                Console.WriteLine("\noperacion finalizada");
            }
            Console.WriteLine("\n---------------------------------------------------------");





            Console.WriteLine("\nEjercicio2");
            try
            {
                Console.Write("\nIngrese un número: "); 

                int numero1 = int.Parse(Console.ReadLine()); 

                Console.Write("\nIngrese un número: "); 
                int numero2 = int.Parse(Console.ReadLine()); 

                operacion op = new operacion(); 

                op.Dividir(numero1, numero2);

            }
            catch (FormatException ex)
            {

                Console.WriteLine("\nHa ingresado una letra o ha dejado el espacio en blanco");
                Console.WriteLine(ex.Message);

            }
            Console.ReadKey();
            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("\nEjercicio3");
            try
            {
                Logic.DisparaUnaExcepcion();
            }
            catch (FormatException ex)
            {

                Console.WriteLine("\nEl mensaje de la Excepción es: {0} ",ex.Message);
                Console.WriteLine("\nEl tipo de la Excepción se llama: {0}",ex.GetType());
            }
            Console.ReadKey();
            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("\nEjercicio4");
            try
            {
                throw new Excepción_Personalizada();
            }
            catch (Exception ex)
            {

                Console.WriteLine("\nEl mensaje de la Excepción es: {0} ", ex.Message);
                Console.WriteLine("\nEl tipo de la Excepción se llama: {0}", ex.GetType());
            }

            Console.ReadKey();
        }
    }
}
