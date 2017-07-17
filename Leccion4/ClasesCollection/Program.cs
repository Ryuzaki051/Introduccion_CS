using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList al = new System.Collections.ArrayList();
            al.Add("uno");
            al.Add(2);
            al.Add(DateTime.Now);


            var s = al[0];
            var i = al[1];
            var d = al[2];

            al.RemoveAt(1);
            al.Remove(s);//Eliminar por elemento

        }
    }
}
