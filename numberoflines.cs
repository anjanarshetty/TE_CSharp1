using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class numberoflines
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            foreach (string line in File.ReadLines(@"C:\Users\EI13060\Desktop\Screenshots and files\Assignments\File\filemult.txt"))
            {
                Console.WriteLine(line);
                counter++;
            }
            Console.WriteLine("There are {0} lines", counter);
        }
    }
}