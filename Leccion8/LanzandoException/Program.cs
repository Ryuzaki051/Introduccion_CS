using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzandoException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EscribirLaSuma("2", "3");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("Presione <Enter> para continuar...");
            Console.ReadLine();
        }

        static void EscribirLaSuma(string a, string b)
        {
            try
            {
                int C = Sumar(a, b);
                Console.WriteLine(C);
            }
            catch (FormatException ex)
            {
                //throw; //JAMAS SE EJECUTARA LA EXCEPCION
                Console.WriteLine("Error ",ex.Message);
            }
        }

        static int Sumar(string numeroA, string numeroB)
        {
            int A, B, C;
            if(int.TryParse(numeroA, out A) && int.TryParse(numeroB, out B))
            {
                C = A + B;
            }
            else
            {
                C=0;
                //Exception ex = new Exception();
                FormatException ex = 
                    new FormatException("El formato de los datos no es numérico");
                throw (ex);
            }
            return C;
        }

    }
}
