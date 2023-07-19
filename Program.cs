using System;
using System.Diagnostics.Eventing.Reader;
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
            //Console.WriteLine("Enter FILE path"); //To find a file that exists 
            //string fPath = Console.ReadLine();
            //if(File.Exists(fPath))
            //{ 
            //    Console.WriteLine("File Already exists!!");  //In output Screen type C://second.txt

            //}
            //else
            //{
            //    StreamWriter sw = File.AppendText(fPath);
            //    sw.WriteLine("Welcome to Stream Writing Example");
            //    sw.Dispose();
            //    sw.Close();
            //    Console.WriteLine("Created and text is Written");
            //}
            //Console.ReadKey();

            //Example 3
            //StreamReader sr;
            //try
            //{
            //    string fpath = "C:\\Users\\aryar\\OneDrive\\Documents\\Sample Example";
            //    sr = new StreamReader(fpath);
            //    string text = "";
            //    while ((text = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(text); ;
            //    }
            //    sr.Close();
            //}
            //catch(Exception ex)
            //{ Console.WriteLine("Error!!!"+ex.Message); }
            //finally
            //{
            //    Console.ReadKey();
            //}

            //Example 4
            try
            {
                string path ="D:\\";
                Console.WriteLine("Enter File Name to read out from"); //In output screen type FileOne.txt
                string fName = Console.ReadLine();
                string fpath = path + fName;
                if (File.Exists(fpath))
                {
                    string[] lines = File.ReadAllLines(fpath);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else { Console.WriteLine("File does not exist"); }
                }
            catch (Exception ex)
            { Console.WriteLine("Error!!!" + ex.Message); }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
