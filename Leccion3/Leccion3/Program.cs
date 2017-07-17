using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre="Juan";

            int a = 20;

            int b = a;
            
            DateTime FechaHora = DateTime.Now;

            string c = a.ToString();

            var Coseno = System.Math.Cos(90);

            int d = a + b;

            string NombreCompleto = Nombre + "Perez";

            var r = a + b * d / 45;
            var r2 = a > 5 && b > 6;
            var r3 = a >> 4;

            var e = 5.0 / 2;
        }
    }
}
