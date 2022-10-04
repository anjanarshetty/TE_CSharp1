using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class AccessSpecifiers
    {
        public static void Main()
        {
            AccessSpecifier accessSpecifier = new AccessSpecifier();
            accessSpecifier.StudentDetails(13060, "Anjana");
            int s = Convert.ToInt32(Console.ReadLine());
        }
    }
    public class AccessSpecifier
    {
        public int sid;
        public string sname;
        public void StudentDetails(int id, string name)
        {
            sid = id;
            sname = name;
            Console.WriteLine($"Student name={sname} and Student ID={sid}");
        }
    }
}
