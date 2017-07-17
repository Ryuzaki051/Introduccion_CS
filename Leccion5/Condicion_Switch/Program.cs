using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicion_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dia = 4;

            switch (Dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;

                case 2:
                    Console.WriteLine("Lunes");
                    break;

                case 3:
                    Console.WriteLine("Martes");
                    break;

                case 4:
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("Los dias Miercoles a Sabado no son validos");
                    break;

                default:
                    Console.WriteLine("Dia Desconocido");
                    break;
            }

            Console.WriteLine("Presione <Enter> para continuar");
            Console.ReadLine();
        }
    }
}
