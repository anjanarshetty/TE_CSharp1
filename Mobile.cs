using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TE_CSharp1
{
    internal class Mobile
    {
        public static void Main()
        {
            Console.WriteLine("mobile validation");
            string mobile = "9-23445-6890";
            var validate_mobile = Regex.IsMatch(mobile, @"^\(?([7-9]{1})\)?[-. ]?([0-9]{5})[-. ]?([0-9]{4})$");
            Console.WriteLine(validate_mobile);

            int s = Convert.ToInt32(Console.ReadLine());

        }

    }
}