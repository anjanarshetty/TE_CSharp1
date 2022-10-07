using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class fileoperations
    {
        public static void Main()
        {
            //move
         
            string source = @"C:\Users\EI13060\Desktop\Screenshots and files\Assignments\fileop.txt";
            string destination = @"C:\Users\EI13060\Desktop\Screenshots and files\Assignments\File\fileop.txt";
            File.Move(source, destination);
            File.Move(@"C:\Users\EI13060\Desktop\Screenshots and files\Assignments\fileop.txt", @"C:\Users\EI13060\Desktop\Screenshots and files\Assignments\File");
         
            
            //copy
           
            string source_path = @"C:\Users\EI13060\Desktop\Screenshots and files\Assignments\filemult.txt";
            string dest_path = @"C:\Users\EI13060\Desktop\Screenshots and files\Assignments\File\filemult.txt";
            File.Copy(source_path, dest_path);
           
          
            //delete
            string path = @"C:\Users\EI13060\Desktop\Screenshots and files\Assignments\file1.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
                try
                {
                    File.Delete(path);
                }
                catch
                {
                    Console.WriteLine("Not Happening!");
                }
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }
            int t = Convert.ToInt32(Console.ReadLine());
        }
    }
}