using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Inicializando arreglos

namespace Leccion4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una dimension de caracteres e instanciando en la misma linea
            string[] NombresDeAlumnos=new string[3]; 
            
            int[,] Calificaciones;//dos dimensiones de enteros
            int[, ,] CalificacionesPorGrupos=new int[3,2,4];//Tres dimensiones de enteros

            Calificaciones = new int[3, 2];//Instanciando objeto calificaciones con 3 columnas 2 filas

            int[,] Calificaciones2 = new int[,] { {8,10}, {5,7}, {9,10} };

            int[, ,] CalificacionPorGrupos2 = new int[,,]
            {
                { {7,9,5,8}, {5,8,10,8} },
                { {1,4,5,6}, {5,7,10,8} },
                { {8,9,5,8}, {3,8,10,5} }
            };

            string[][] ArregloDeCalificaciones;
            ArregloDeCalificaciones=new string[3][];

            ArregloDeCalificaciones[0] = new string[2];
            ArregloDeCalificaciones[2] = new string[5];

        }
    }
}
