using System;

namespace IntroCS
{
    class Program
    {
        /*
         *El metodo Main es el punto de inicio de todas 
         *las aplicaciones ejecutables en .NET
         */
        static void Main(string[] args)
        {
            //El metodo clear limpia la consola
            Console.Clear();
            int i = Console.Read(); // leer el caracter y esperar enter
            Console.Write("Caracter Leido:");
            Console.WriteLine(i);

            string linea = Console.ReadLine();
            Console.WriteLine("Linea Leida:" + linea);

            Console.Write("Presione cualquier tecla para terminar");
            ConsoleKeyInfo ki = Console.ReadKey();
            Console.WriteLine();
            Console.Write("Tecla Presionada");
            Console.WriteLine(ki.Key);

            Demo.Operaciones.Sumar(5, 6);
            
        }
    }
}
