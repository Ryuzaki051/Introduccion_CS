using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasoDeParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 5;

            Console.WriteLine("Valor de j antes de invocar la funcion: {0}",j);
            EscribirValor(j);

            Console.WriteLine("Valor de j despues de invocar la función {0}", j);

            Console.Write("Presione <Enter> para continuar");
            Console.ReadLine();
        }

        static void EscribirValor(int i)
        {
            i++;
            Console.WriteLine("Valor de i dentro de la función: {0}", i);
        }
    }
}
