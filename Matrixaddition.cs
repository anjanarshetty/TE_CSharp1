using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class MatrixAddition
    {
        public static void Main()
        {
            array_2D();
            int s = Convert.ToInt32(Console.ReadLine());
        }
        public static void array_2D()
        {
            int i, j;
            Console.WriteLine("Enter the number of columns and rows of the matrix: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array1 = new int[2, 2];
            int[,] array2 = new int[2, 2];
            int[,] array3 = new int[2, 2];
            Console.WriteLine("Enter the elements of array 1:");
            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    array1[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the elements of array 2:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    array3[i, j] = array1[i, j] + array2[i, j];
            Console.WriteLine("Addition of two matrix is: ");
            for(i=0; i < n; i++)
            {
                Console.WriteLine("\t");
                for (j = 0; j < n; j++)
                    Console.WriteLine("{0} \t", array3[i, j]);
            }
            Console.WriteLine("\n");
        }
    }
}