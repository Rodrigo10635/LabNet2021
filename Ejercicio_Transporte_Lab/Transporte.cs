using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Transporte_Lab
{
    abstract class Transporte
    {
        private int pasajeros;  

        protected Transporte(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public int Obtener_Pasajeros { get { return pasajeros; } } 

        public abstract void Avanzar();  

        public abstract void Detenerse(); 


       


        
    }
}
