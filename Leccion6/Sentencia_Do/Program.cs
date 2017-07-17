using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentencia_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            string Clave;
            do
            {
                Console.Write("Escriba la clave de acceso correcta: ");
                Clave = Console.ReadLine();
                if (Clave == "")
                {
                    Console.WriteLine("Debe de proporcionar una clave no vacía");
                    //break;
                    continue;
                }
                Console.WriteLine("Validando la clave de acceso...");
            } while (Clave != "Password");
        }
    }
}
