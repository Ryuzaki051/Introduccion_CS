using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionComunes
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Collections.Stack s = new System.Collections.Stack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);

            var o = s.Pop();
            var o2 = s.Peek();


            System.Collections.Hashtable h = new System.Collections.Hashtable();
            h.Add("U1", "Jose");
            h.Add("U2", "Abraham");
            h.Add("U3", "Andrea");
            h.Add("U4", "Raquel");


            System.Collections.SortedList sl = new System.Collections.SortedList();
            sl.Add("U5", "Jose");
            sl.Add("U2", "Abraham");
            sl.Add("U3", "Andrea");
            sl.Add("U4", "Raquel");
            sl.Add("U1", "Paco");

            var s3 = sl["U5"];
            var s2 = sl["U5"];

            s3 = sl.GetByIndex(0);
            s2 = sl.GetByIndex(2);

            sl.Remove("U2");
            sl.RemoveAt(2);


            /*
            System.Collections.ArrayList al = new System.Collections.ArrayList();
            al.Add("Cero");
            al.Add("Uno");
            al.Add("Dos");
            al.Add("Tres");

            al.Remove("Dos");
            al.RemoveAt(0);

            var c = al[0];

            al.Capacity = 50;

            var n = al.Count;

            al.TrimToSize();

            System.Collections.Queue q = new System.Collections.Queue();
            q.Enqueue("Cero");
            q.Enqueue("Uno");
            q.Enqueue("Dos");

            var o = q.Dequeue();

            o = q.Peek(); 
             */
        }
    }
}
