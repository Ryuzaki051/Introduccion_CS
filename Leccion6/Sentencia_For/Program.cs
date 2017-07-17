using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentencia_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int Suma = 0;
            int Numero;
            string ValorLeido;

            for (int i = 1; i < 4; i++)
            {
                Console.Write("Numero {0}: ", i);
                ValorLeido = Console.ReadLine();
                if (int.TryParse(ValorLeido, out Numero))
                {
                    Suma += Numero;
                    //continue;
                }
            }
            Console.WriteLine("Promedio: {0}", Suma / 3);
            Console.WriteLine("Presione <Enter> para continuar...");
            Console.ReadLine();
        }
    }
}
