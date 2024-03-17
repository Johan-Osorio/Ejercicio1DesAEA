using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Operacion
    {
        public int ValorA { get; set; }
        public int ValorB { get; set; }
        public int ValorC { get; set; }


        public int Sumar()
        {
            return ValorA + ValorB;
        }
        public int Restar()
        {
            return ValorA - ValorB;
        }

    }
}
