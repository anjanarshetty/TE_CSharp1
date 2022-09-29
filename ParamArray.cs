using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class ParamArray
    {
        public static void Main()
        {
            int[] n = new int[] {1,2,3,4,5,6};
            int array1=mul(n);
            Console.WriteLine("The multiplication of the Param Array1 is= " + array1); 
            int array2 = mul(1,2,3,4,5);
            Console.WriteLine("The multiplication of the Param Array2 is= " +array2);
            int s = Convert.ToInt32(Console.ReadLine());
        }
        public static int mul(params int[] numbers)
        {
            int mul=1;
            foreach (int i in numbers)
            {
                mul = mul * i;
            }
            return mul;
        }
    }
}