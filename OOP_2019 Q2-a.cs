using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class Program
    {
        static void Main(string[] Args)
        {
            double sum = 0,num;
            double avg;
            for(int i = 0; i < 10; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
            }
            avg = sum / 10;
            Console.WriteLine("sum = {0}  ,  average = {1}",sum,avg);
        }
    }
}
