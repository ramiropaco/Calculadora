using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) {

            int[] precios = { 100, 200, 300 };
            string[] productos = { "vaso", "plato", "cuchara" };
            double resultado = 0;

            for (int i = 0; i < productos.Length; i++)
            {

                 resultado += Calculus.CalcularImpuesto(precios[i]);

                Console.WriteLine("Precio: " + precios[i]);
                Console.WriteLine("resultado: " + resultado);
                
            }

            Console.ReadKey();

        }


   
    }
}
