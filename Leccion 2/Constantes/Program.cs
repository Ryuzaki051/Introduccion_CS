using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Demo
    {
        const byte HorasDelDia=24;
        //No es permitido
        //const DateTime FechaYHoraActual = DateTime.Now;

        void Metodo()
        {
            const double PI = 3.141592;
            //HorasDelDia = 0;
        }

    }
}
