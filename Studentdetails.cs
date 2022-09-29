using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    /// <summary>
    /// out keyword - return more than value to the calling method
    /// return keyword - one value
    /// </summary>
    internal class Studentdetails
    {
        public static void Main()
        {
            int sid = 1;
            string sname = "Anjana";
            string sdept = "CSE";
            details(out sid, out sname, out sdept);
            /*int i;
            int j;
            add(out i, out j);
            Console.WriteLine(i + " " + j); //20 40
            int s = Convert.ToInt32(Console.ReadLine());*/
            int s = Convert.ToInt32(Console.ReadLine());
        }
        public static void details(out int sid, out string sname, out string sdept)
        {
            Console.WriteLine("Employee ID: " + sid);
            Console.WriteLine("Employee Name: " + sname);
            Console.WriteLine("Employee Dept : " + sdept);
            /* a = 10;
             b = 20;
             a += a;//20
             b += b;//40*/
        }
    }
}