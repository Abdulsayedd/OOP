using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class Program
    {
        static void Main(string[] Args)
        {
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
