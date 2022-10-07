using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class GenericDelegates
    {
        // Declare Generic Delegate
        public delegate T SampleDelegate<T>(T a);
        class MathOperations
        {
            public int Square(int a)
            {
                return a * a;
            }
            public int Cube(int x)
            {
                return x * x * x;
            }
            public int Circle(int y)
            {
                return 2 * 3 * y;
            }

            public double Square(double a)
            {
                return a * a;
            }
            public double Cube(double x)
            {
                return x * x * x;
            }
            public double Circle(double y)
            {
                double res = 2 * 3.14 * y;
                return res;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(" Calculating the area of a square, cube and circle by creating a Generic Delegate.");
                MathOperations m = new MathOperations();
                SampleDelegate<int> dlgt = new SampleDelegate<int>(m.Square);
                Console.WriteLine("Area of the Square(int): " + dlgt(5));
                dlgt = m.Cube;
                Console.WriteLine("Area of the Cube(int):" + dlgt(10));
                dlgt = m.Circle;
                Console.WriteLine("Area of circle(int):" + dlgt(1));
                Console.WriteLine("------------------------------");

                SampleDelegate<double> dlgt1 = new SampleDelegate<double>(m.Square);
                Console.WriteLine("Area of the Square(float): " + dlgt1(2.5));
                dlgt1 = m.Cube;
                Console.WriteLine("Area of the Cube(float): " + dlgt1(10.2));
                dlgt1 = m.Circle;
                Console.WriteLine("Area of the Circle(float): " + dlgt1(1.0));
                Console.ReadLine();
            }
        }
    }
}