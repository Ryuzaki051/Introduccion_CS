using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarSoloLectura
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Demo
    {
        readonly byte HorasDelDia = 24;
        readonly int VelocidadDeLaLuz;
        readonly short GradosDeUnCirculo;
        readonly DateTime FechaYHoraActual = DateTime.Now;

        public Demo(int velocidadDeLaLuz, short gradosDeUnCirculo)
        {
            this.VelocidadDeLaLuz = velocidadDeLaLuz;
            this.GradosDeUnCirculo = gradosDeUnCirculo;
        }

        void Metodo()
        {
            //VelocidadDeLaLuz = 0;
        }
    }
}