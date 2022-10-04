using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TE_CSharp1
{
    public delegate void EmpDelegate(int empid, string empname);
    public delegate void EmpDelegate1(int empid, string empname);
    public class Employees
    { 
        public void GetITLeadDetails(int empid, string empname)
        {
            Console.WriteLine($"IT: {empid}:{empname}");
        }
        public void GetTestingLeadDetails(int empid, string empname)
        {
            Console.WriteLine($"Testing: {empid}:{empname}");
        }
    }
    internal class Delegates
    {
        public static void Main()
        {
            //instance for the class
            Employees employees = new Employees();
            //instance for the delegate EmpDelegate
            //Single-cast delegate -> hold only a single reference(one method at a time)
            EmpDelegate empDelegate = employees.GetITLeadDetails; //reference of the GetITLeadDetails()
            empDelegate(100, "John");
            empDelegate = employees.GetTestingLeadDetails;
            empDelegate(201, "Peter");
            //instance for the delegate EmpDelegate1
            //Multi-cast delegate - EmpDelegate1 - 2 references
            EmpDelegate1 empDelegate1 = employees.GetITLeadDetails;
            empDelegate1 += employees.GetTestingLeadDetails;
            Console.WriteLine("TEAM LEAD FOR IT AND TESTING");
            empDelegate1(101, "Sam");
            Console.WriteLine("PROJECT LEAD FOR IT");
            empDelegate1 -= employees.GetTestingLeadDetails;
            empDelegate1(105, "Jancy");
        }

    }
}