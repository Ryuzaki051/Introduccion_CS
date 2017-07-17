using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosOpcionales
{
    class Program
    {
        static void Main(string[] args)
        {

            CalcularPromedio(10, 4);
            CalcularPromedio(10, 10, 4);

            Console.Write("Presione <Enter> para continuar");
            Console.ReadLine();
        }

        static void CalcularPromedio(int calificacion1,
            int calificacion2=0, int calificacion3=0)
        {
            Console.WriteLine("El promedio es : {0}",
                (calificacion1+calificacion2+calificacion3)/3);
        }

    }
}
