using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_métodos_excepciones
{
    public static class Logic
    {
        public static void DisparaUnaExcepcion ()
        {
            Console.WriteLine("\nEstoy tirando una Excepción");
            throw new FormatException();
        }
    }
}
