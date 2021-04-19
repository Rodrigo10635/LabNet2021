using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_métodos_excepciones
{
    public class Excepción_Personalizada : Exception
    {
        public Excepción_Personalizada():base("Hola instructores")
        {

        }
    }
}
