using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentencia_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            var Enumerador = args.GetEnumerator();
            while (Enumerador.MoveNext())
            {
                Console.WriteLine(Enumerador.Current);
            }
            * /
            /**/
            foreach (string elemento in args)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
