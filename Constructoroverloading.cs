using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Constructoroverloading
    {
        public static void Main()
        {
            Console.WriteLine("Constructor overloading for add(int,int)");
            Addition add = new Addition(10);
            Console.WriteLine("Constructor overloading for add(float,float)");
            Addition add1 = new Addition(1.5,1.5);
            Console.WriteLine("Constructor overloading for add(string,string)");
            Addition add2 = new Addition("Anjana", "Shetty");
            int s = Convert.ToInt32(Console.ReadLine());
        }
    }
    public class Addition
    {
        public int num2;
        public Addition(int num1)
        {
            num2 = 20;
            Console.WriteLine($"{num2}+{num1}={num1+num2}");
        }
        public float num3;
        public float num4;
        public Addition(double num3,double num4)
        {
            Console.WriteLine($"{num3}+{num4}={num4+num3}");
        }
        public string str1;
        public string str2;
        public Addition(string str1, string str2)
        {
            Console.WriteLine($"{str1} {str2}");
        }
    }
}