using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 1)
                {
                    string Contenido;
                    Contenido = System.IO.File.ReadAllText(args[0]);
                    Console.WriteLine(Contenido);
                }
                else
                {
                    Console.WriteLine("Debe de proporcionar el nombre del archivo");
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("El archivo no existe!");
                Console.WriteLine(ex.FileName);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("El directorio no existe!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:", e);
            }

        }
    }
}
