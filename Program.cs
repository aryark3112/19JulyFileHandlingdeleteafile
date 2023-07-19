using System;
using System.IO;

namespace _19July
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            //string path = @"C:\\";
            //string fname;
            //Console.WriteLine("Enter File name");
            //fname = Console.ReadLine();
            //string fPath = path + fname;
            //if(File.Exists(fPath))
            //{
            //    Console.WriteLine("The file already exist!!!");
            //}
            //else
            //{
            //    File.Create(fPath);
            //    Console.WriteLine("File Created !!!");
            //}
            //Console.ReadKey();

            //Example 2 
            Console.WriteLine("Enter FILE path"); //To find a file that exists 
            string fPath = Console.ReadLine();
            if(!File.Exists(fPath))
            { 
                Console.WriteLine("File Already exists!!");
                
            }
            else
            {
                StreamWriter sw = File.AppendText(fPath);
                sw.WriteLine("Welcome to Stream Writing Example");
                sw.Dispose();
                sw.Close();
                Console.WriteLine("Created and text is Written");
            }
            Console.ReadKey();
            

        }
    }
}
