using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{

    internal class Inheritance
    {
        public class Bonus
        {
            protected int bonus;
        }
        public class Staff:Bonus
        {
            protected int sal=30000;
            public void StaffBonus()
            {
                bonus=3*sal;
                Console.WriteLine($"Staff salary: {sal} and Bonus= {bonus}");
            }
        }
        public class NonStaff:Staff
        {
            protected int sal=15000;
            public void NonStaffBonus()
            {
                bonus=2*sal;
                Console.WriteLine($"Non-Staff Salary: {sal} and Bonus= {bonus}");
            }
        }
        internal class inheritance
        {
            class Program
            {
                public static void Main()
                {
                    Staff s=new Staff();
                    s.StaffBonus();
                    NonStaff n=new NonStaff();
                    n.NonStaffBonus();
                    int t=Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}