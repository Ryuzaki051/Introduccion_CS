using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Anidado
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dia = 1;

            if (Dia == 1)
            {
                Console.WriteLine("Domingo");
            }
            else
            {
                if (Dia == 2)
                {
                    Console.WriteLine("Lunes");
                }
                else
                {
                    if (Dia == 3)
                    {
                        Console.WriteLine("Martes");
                    }
                    else
                    {
                        Console.WriteLine("Dia desconocido con if anidado");
                    }

                }
            }


            if (Dia == 1)
            {
                Console.WriteLine("Domingo");
            }
            else if (Dia == 2)
            {
                Console.WriteLine("Lunes");
            }
            else if (Dia == 3)
            {
                Console.WriteLine("Martes");
            }
            else
            {
                Console.WriteLine("Dia Desconocido con else if");
            }

            Console.Write("Presione <Enter> para continuar...");
            Console.ReadLine();
        }
    }
}
