using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    public class firstline
    {
        public static void Main()
        {
            string[] content;
            content = File.ReadAllLines(@"C:\Users\EI13060\Desktop\Screenshots and files\Assignments\filemult.txt");
            Console.WriteLine(content[0]);
            int t = Convert.ToInt32(Console.ReadLine());
        }
    }
}