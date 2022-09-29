using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class enumeration
    {
        enum concept
        {
            a,
            b = -5,
            e = 10,
            t = -10,
            c = 40
            
        }
        public static void Main()
        {
            Console.WriteLine("Enumeration Program \n");
            Console.WriteLine(concept.e); //e

            int s = (int)concept.t;
            Console.WriteLine(s); //-10

            int d = (int)concept.c;
            Console.WriteLine(d); //40

            var del = (concept)40;
            Console.WriteLine(del); //c

            int n = Convert.ToInt32(Console.ReadLine());
        }
    }
}
