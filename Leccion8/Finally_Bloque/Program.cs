using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally_Bloque
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter sw = null;

            try
            {
                sw = new System.IO.StreamWriter("c:\\demo.txt");
                sw.WriteLine("Esta es una linea de texto");
                sw.WriteLine("Este es un argumento: {0}", args[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sw.Close();
            }


        }
    }
}