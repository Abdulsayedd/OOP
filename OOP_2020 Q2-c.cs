using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class Program
    { 
        static void Main(string[] Args)
        {
            string s1 = "welcome", s2 = " exam";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine(s2.Length);
            s3 = s3.ToUpper();
            Console.WriteLine(s3);
        }
    }
}
