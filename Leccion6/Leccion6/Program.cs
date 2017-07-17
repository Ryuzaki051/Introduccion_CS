using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero = 0;
            int Suma = 0;
            
            while(Numero!=-1)
            {
                Suma += Numero;
                Console.Write("Numero a sumar: ");
                if (!int.TryParse(Console.ReadLine(), out Numero))
                {
                    Console.WriteLine("Los valores deben ser numéricos");
                    break;
                }
                //Numero = int.Parse(Console.ReadLine());
            }
        }
    }
}
