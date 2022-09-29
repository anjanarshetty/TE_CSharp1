using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class controlstatements
    {
        public static void Main()
        {
            Console.WriteLine("Control statements:");
            controlstatements t = new controlstatements();
            t.condition();
            conditional();           
        }
        public void condition()
        {
            int[] a = new int[] { 1, 2, 3 }; //Without specifying the size
            int[] b = new int[4] { 1, 2, 3, 4 }; //with specifying the size
            int[] c = { 1, 2, 3 };
            int sum = 0;
            Console.WriteLine("using for: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("using foreach: ");
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finding sum of the array elements");
            for (int i = 0; i < c.Length; i++)
            {
                sum = sum + c[i];
            }
            Console.WriteLine("Sum ={0}", sum);
            //int size;
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] s = new int[n];
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Enter array elements");
                s[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements in the Array");
            foreach (int j in s)
            {
                Console.WriteLine(j);
            }
        }
        public static void conditional()
        {
            int d;
            Console.WriteLine("To find whether the entered number is odd or even");
            Console.WriteLine("Enter the number: ");
            d = Convert.ToInt32(Console.ReadLine());
            if (d<=0)
            {
                Console.WriteLine("Invalid entered number");
            }
            else if (d % 2 == 0)
                Console.WriteLine("The number is even");
            else
                Console.WriteLine("The number is odd");
            int n = Convert.ToInt32(Console.ReadLine());
        }       
    }
}
