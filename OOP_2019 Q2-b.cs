using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class Program
    {
        static void Main(string[] Args)
        {
            int[] id = new int[1000];
            int[] price = new int[1000];
            int max = 0;
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Enter {0} id",(i+1));
                id[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter {0} price", (i + 1));
                price[i] = int.Parse(Console.ReadLine());
                if (price[max] < price[i])
                    max = i;
            }
            Console.WriteLine("Max id = "+id[max]);
        }
    }
}
