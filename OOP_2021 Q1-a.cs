using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class Program
    {
        static void Main(string[] Args)
        {
            int sum = 0;
            int[] arr = new int[100];
            for(int i = 0; i < 100;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            for(int i = 0; i < 100; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }
}
