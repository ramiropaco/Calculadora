using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculus
    {
        public static double CalcularImpuesto(int precio) {
            double impuesto = .16;
            double resultado = 0;

            resultado = (precio * impuesto) + precio;

            return resultado;
        }
    }
}
