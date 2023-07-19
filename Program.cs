using System;
using System.IO;

namespace _19July
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\";
            string fname;
            Console.WriteLine("Enter File name");
            fname = Console.ReadLine();
            string fPath = path + fname;
            if(File.Exists(fPath))
            {
                Console.WriteLine("The file already exist!!!");
            }
            else
            {
                File.Create(fPath);
                Console.WriteLine("File Created !!!");
            }
            Console.ReadKey();
        }
    }
}
