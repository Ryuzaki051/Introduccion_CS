using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Presione <Enter> para continuar");
            Console.ReadLine();

        }

        static int Sumar(int primerNumero, int segundoNumero)
        {
            int C = primerNumero + segundoNumero;
            return C;
        }

        static void EscribirMensaje(string mensajeAEscribir)
        {
            Console.WriteLine(mensajeAEscribir);
        }

        /* No es recomendable
        static void main(string[] args)
        {
        }
         * */
    }
}
