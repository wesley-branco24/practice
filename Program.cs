using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(10);
            a1.Add(22.45);
            a1.Add("Wesley");
            a1.Add(56);

            foreach(var obj in a1)
            {
                Console.WriteLine(obj);
            }

            for(int i = 0;i < a1.Count;i++)
            {
                Console.WriteLine(a1[i]);
            }
            Console.ReadLine();
            // Method to delete the value 22.45

        }
    }
}
