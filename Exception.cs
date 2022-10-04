/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class Exception
    {
        public static void Main()
        {
            Exception_Demo ex = new Exception_Demo();
            Console.WriteLine("Division by zero try catch method:");
            ex.divide(10, 0);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Index out of range method:");
            ex.array();
            Console.WriteLine("-------------------------------------------");
            ex.MultipleCatch();
            int s = Convert.ToInt32(Console.ReadLine());
        }
    }
    public class Exception_Demo
    {
        float res= 0;
        public void divide(float num1, float num2)
        {
            try
            {
                res=num1/num2;
                if (float.IsInfinity(res))
                {
                    Console.WriteLine("Division by zero is not allowed");
                }

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Result="+res);
            }

        }
        public void array()
        {
            try
            {
                int[] a={1,2,3,4,5};
                Console.WriteLine(a[6]);
            }
            catch (IndexOutOfRangeException e)
            {
               
                Console.WriteLine(e.Message);
            }

        }
        public void MultipleCatch()
        {
            int[] a={100,30,10,9,2};
            int[] b={2,9,0,3};
            for (int i=0;i<a.Length;i++)
            {
                try
                {
                    Console.WriteLine(a[i]/b[i]);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
*/