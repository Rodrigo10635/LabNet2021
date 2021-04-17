using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Transporte_Lab
{
    class Avion : Transporte 
    {
        public Avion(int pasajeros) : base(pasajeros) //constructor.
        {

        }

        public override void Avanzar()    //método de la clase abstracta.
        {
            throw new NotImplementedException();
        }

        public override void Detenerse()  //método de la clase abstracta.
        {
            throw new NotImplementedException();
        }
    }
}
