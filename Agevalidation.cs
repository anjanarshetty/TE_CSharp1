using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    
    internal class Agevalidation
    {
        static void Validate(int age)
        {
            if (age<22)
            {
                throw new InvalidAgeException("Age must be atleast 22 years old.");
            }
            else
            {
                Console.WriteLine("Valid");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age");
                var age = Convert.ToInt32(Console.ReadLine());
                Validate(age);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e);

            }
        }
    }
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message) : base(message)
        {
        }
    }
}