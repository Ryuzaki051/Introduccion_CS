using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentencias_Checked_Uncked
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = int.MaxValue;
            try
            {
                //checked
                unchecked
                {
                    Console.WriteLine("El valor de J:{0}", j);
                    j++;
                    // j=checked(j+1);
                    // j=unchecked(j+1);
                    Console.WriteLine("Valor de j: {0}", j);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverFlow Numerico");
            }

        }
    }
}
