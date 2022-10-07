using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TE_CSharp1
{
    public delegate void EmpDelegate1(string bankname, float interest1, float interest2);
    public delegate void EmpDelegate2(string bankname,float interest);
    public class Employees
    { 
        public void GetBankDetails1(string bankname,float interest)
        {
            Console.WriteLine($"Bank Name: {bankname} , Interest Rate:{interest}%");
        }
        public void GetBankDetails2(string bankname, float interest1,float interest2)
        {
            Console.WriteLine($"Bank Name: {bankname} , Interest Rate:{interest1}% -{interest2}%");
        }
      
    }
    internal class Delegates
    {
        public static void Main()
        {
            //instance for the class
            Employees employees = new Employees();
            EmpDelegate1 empDelegate1 = employees.GetBankDetails2;
            empDelegate1("HDFC Bank",3.0f,3.50f);
            empDelegate1("Axis Bank", 3.0f, 3.50f);
            empDelegate1("ICICI Bank", 3.0f, 3.50f);
            EmpDelegate2 empDelegate2 = employees.GetBankDetails1;
            empDelegate2("SBI", 2.70f);
            empDelegate2("Kotak Mahindra Bank", 3.50f);
            int s = Convert.ToInt32(Console.ReadLine());
        }

    }
}