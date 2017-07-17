using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                Console.WriteLine("A: {0}, B: {1}", args[0], args[1]);
                int A, B;
                string Mensaje;
                /*
                if (int.TryParse(args[0], out A) && int.TryParse(args[1], out B))
                {
                    Mensaje = string.Format("{0} + {1} = {2}", A, B, A + B);
                }
                else
                {
                    Mensaje = "Debe de Proporcionar valores numéricos";
                }
                */


                //                        IF      ELSE
                //variable = Condición ? Valor : Valor
                Mensaje = (int.TryParse(args[0], out A) && int.TryParse(args[1], out B))
                    ?
                    string.Format("{0} + {1} = {2}", A, B, A + B)
                    :
                    "Debe de Proporcionar valores numéricos";


                Console.WriteLine(Mensaje);
            }
            else
            {
                Console.WriteLine("Debe de especificar dos numeros enteros");
            }
            Console.Write("Presione <Enter> para continuar...");
            Console.ReadLine();
        }
    }
}
