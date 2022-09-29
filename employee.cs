using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class employee
    {
        public static void Main()
        {
            EmployeeDetails empDetails = new EmployeeDetails(01, "Anjana");
            empDetails.DisplayDetails();
        }
    }
    struct EmployeeDetails
    {
        public int empid;
        public string empname;
        public EmployeeDetails(int id, string name)
        {
            empid = id;
            empname = name;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID {empid} is {empname}");
            int n = Convert.ToInt32(Console.ReadLine());
        }

    }
}
