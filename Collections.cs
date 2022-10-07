using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TE_CSharp1
{
    internal class Collections
    {
        public static void Dictionary()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "HTML");
            d.Add(2, "ANGULAR");
            d.Add(3, "C#");
            d.Add(4, "JAVASCRIPT");
            Console.WriteLine("DICTIONARY");
            foreach (var i in d)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Retriving all the values:");
            var values = new List<string>(d.Values);
            foreach (var i in values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Retriving all the keys:");
            var key = new List<int>(d.Keys);
            foreach (var i in key)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Retriving the value of the specified key:");
            Console.WriteLine($"Value: {d[1]}"); 
        }
        public static void Hashtable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,"C#");
            ht.Add(2,123);
            ht.Add(3,"C#123");
            ht.Add(4,456);
            ht.Add(5,"C#456");
            Console.WriteLine("HASHTABLE");
            ICollection key = ht.Keys;
            foreach (var i in key)
            {
                Console.WriteLine(ht[i]);
            }
            Console.WriteLine($"Value: {ht[1]}");
            Console.WriteLine($"Value: {ht[2]}");
            Console.WriteLine($"Value: {ht[3]}");
        }
        public static void Main()
        {
            //DICTIONARY
            Dictionary();
            Console.WriteLine("\n");
            //HASHTABLE
            Hashtable();
            int t = Convert.ToInt32(Console.ReadLine());
        }
    }
}