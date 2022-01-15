using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class Program
    {
        static void read(string path)//2 read all lines and store it in string array
        {
            string[] lines;
            lines = File.ReadAllLines(path);
            for(int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
        static void Main(string[] Args)
        {
            string path = @"d:\test.txt";
            bool exist = false;
            if(File.Exists(path))//1 exists?
            {
                exist = true;
            }
            if (exist)
            {
                read(path);//2
                File.Copy(path, @"G:\test.txt");//3 copy to another txt file
            }
            else
                Console.WriteLine("File Not Found!");
        }
    }
}
