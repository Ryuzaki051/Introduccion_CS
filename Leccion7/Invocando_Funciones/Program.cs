using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invocando_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int Resultado = Sumar(3, 6);
            EscribirMensaje(Resultado.ToString());

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


    }
}
