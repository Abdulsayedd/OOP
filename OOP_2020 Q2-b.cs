using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class Program
    { 
        static void Main(string[] Args)
        {
            int[] arr = new int[100];
            double sum = 0;
            int maxx = 0;
            for(int i = 0; i < 100; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
                maxx=Math.Max(maxx, arr[i]);
            }
            sum /= 100;
            Console.WriteLine("Average = {0} , Max = {1}",sum,maxx);

        }
    }
}
