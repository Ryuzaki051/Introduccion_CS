using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicializadorDeColeccion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si soporta Inicializador
            System.Collections.ArrayList al = new
            System.Collections.ArrayList { 1, 2, 3, 4, 5};

            /* No soporta Inicializadores de objetos
            System.Collections.Queue q = new 
            System.Collections.Queue { 1, 2, 3, 4, 5}; */

            //Si soporta Inicializador
            System.Collections.Hashtable ht = new
                System.Collections.Hashtable
                {
                    {1,"Maria"},
                    {2,"Pedro"}
                };
            //Si soporta Inicializador
            System.Collections.SortedList sl = new
                System.Collections.SortedList
                {
                    {1,"Maria"},
                    {2,"Pedro"}
                };
        }
    }
}
