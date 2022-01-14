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
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Enter {0} id", (i + 1));
                id[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter {0} price", (i + 1));
                price[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Less than 10$ : ");
            for(int i = 0; i < 1000; i ++)
            {
                if(price[i]<10)
                {
                    Console.Write(id[i]+" ");
                }
            }
            Console.WriteLine("More than 500$ : ");
            for (int i = 0; i < 1000; i++)
            {
                if (price[i] > 500)
                {
                    Console.Write(id[i] + " ");
                }
            }
        }
    }
}
