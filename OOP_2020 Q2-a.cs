using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class Program
    { 
        static void Main(string[] Args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
