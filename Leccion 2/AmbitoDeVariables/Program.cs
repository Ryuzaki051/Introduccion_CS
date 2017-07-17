using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbitoDeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //bloque
            if (Console.ReadLine() == "Continuar")
            {
                int a = 5;
            }
            //No reconoce la variable que se declara fuera del bloque
            //Console.WriteLine(a);
        }

        static void Saluda()
        {
            DateTime FechaActual = DateTime.Now;
            Console.WriteLine(FechaActual);
        }

    }
}
