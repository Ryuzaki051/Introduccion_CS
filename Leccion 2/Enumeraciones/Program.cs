using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Solo aplican a nivel de clase y nivel de nameespace
namespace Enumeraciones
{
    class Program
    {
        enum DiasDeLaSemana //: byte
        {
            // 0         1      2        3         4           5         6
            Domingo=20, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado=100
        }
        static void Main(string[] args)
        {
            DiasDeLaSemana PrimerDia = DiasDeLaSemana.Domingo;
            DiasDeLaSemana InicioSemana = DiasDeLaSemana.Lunes;
            DiasDeLaSemana MitadSemana = DiasDeLaSemana.Miercoles;
            DiasDeLaSemana UltimoDia = DiasDeLaSemana.Sabado;

            Console.WriteLine((int)PrimerDia);
            Console.WriteLine(MitadSemana);
            Console.WriteLine((byte)UltimoDia);
            
            DiasDeLaSemana otrodia = InicioSemana;
            otrodia++;
            Console.WriteLine(otrodia);

            otrodia = DiasDeLaSemana.Viernes;
            otrodia--;
            Console.WriteLine(otrodia);

        }
    }
}
