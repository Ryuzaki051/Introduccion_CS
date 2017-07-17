using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion5
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (condicion) instrucciones a ejecutar
            int a;
            //if (args.Length > 0 && (int.TryParse(args[0], out a)))
            if (args.Length==0 || (!int.TryParse(args[0], out a)))
            {
                Console.WriteLine("No se especificaron argumentos o el primer argumento no es un entero");
                //Console.WriteLine("El usuario proporcionó {0} argumentos", args.Length);
                //Console.WriteLine("El primer argumento es: {0}", args[0]);
                //Console.WriteLine("El primer argumento es un entero");
            }
            Console.Write("Presione <Enter> para continuar...");
            Console.ReadLine();
        }
        // con el operador and && si la primera condicion a evaluar es falsa, las demas sentencias serán falsas

    }
}
