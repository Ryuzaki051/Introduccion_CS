using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //operador unarios
            int a = -5;
            a++; //incremento
            a--; //decremento

            int b = a + 1;
            int c = a - b;
            int d = a * c;

            int e = a > 15 ? 15 : a; //operador ternario
            //operador compuesto de asignacion
            a += 20; // a=a+20;
            a -= 20; // a=a-20;
            a *= 20; // a=a*20;
            a /= 20; // a=a/20;
            a %= 20; // a=a%20;

        }
    }
}
