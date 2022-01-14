using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class average
    {
        double sum = 0;
        public void avg(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            { sum += arr[i]; }
            sum /= 100;
            Console.WriteLine("Average = "+sum);
        }
        public void maxx(int[] arr)
        {
            int x = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(x<arr[i])
                {
                    x = arr[i];
                }
            }
            Console.WriteLine("Max = "+x);
        }
    }
    public class Program
    {
        static void Main(string[] Args)
        {
            int[] arr = new int[100];
            for(int i = 0; i < 100; i++)
            { arr[i] = int.Parse(Console.ReadLine()); }
            average a = new average();
            a.avg(arr);
            a.maxx(arr);
        }
    }
}
