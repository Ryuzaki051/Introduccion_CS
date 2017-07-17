using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //casteo
            string NumeroTexto = Console.ReadLine();
            int Numero;

            //Conversion de numero a Entero 32 
            Numero = System.Convert.ToInt32(NumeroTexto);

            //Conversion de Numero a entero por parse
            Numero = int.Parse(NumeroTexto);
            
            //De cadena NumeroTexto a conversion de numero en toString
            NumeroTexto = Numero.ToString();

            if(int.TryParse(NumeroTexto, out Numero))
            {
                //Si intento convertir el tipo de dato cadena a numero
            }else{
            }

            int a = 5;
            long b = a;
            //
            a = (int)b;
        }
    }
}
