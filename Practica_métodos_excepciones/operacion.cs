using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_métodos_excepciones
{
    class operacion
    {
        //Metodo para el ejercicio numero 1
        public void dividir(int numero1, int numero2)
        {

            try
            {
                int division = numero1 / numero2;
                Console.WriteLine("\nla division es:{0}", division);
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
        
        //Metodo para el ejercicio numero 2
        public void Dividir(int numero1, int numero2)
        {

            try
            {
                int division = numero1 / numero2;
                Console.WriteLine("\nla division es:{0} ", division);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nsolo Chuck Norris puede dividir por cero");
                Console.WriteLine(ex.Message);
            }






        }
    }
}
