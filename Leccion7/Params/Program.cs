using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcularPromedio(10,10,7));

            Console.WriteLine(CalcularPromedio(8, 6));

            Console.WriteLine(CalcularPromedio(10,10,7,8,9,5));

            Console.Write("Presione <Enter> para continuar");
            Console.ReadLine();
        }

        static int CalcularPromedio(params int[] numerosAPromediar)
        {
            int Suma = 0;
            int TotalDeNumeros = numerosAPromediar.Length;

            foreach (int i in numerosAPromediar)
            {
                Suma += i;
            }
            return Suma / TotalDeNumeros;
        }
    }
}
