using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class Program
    {
        static void Main(string[] Args)
        {
            int[] students = new int[50];
            int[] grade = new int[50];
            int maxgrade = 0;
            for(int i = 0; i < 50; i++)
            {
                students[i] = int.Parse(Console.ReadLine());
                grade[i] = int.Parse(Console.ReadLine());
                if(grade[i] > grade[maxgrade])
                    maxgrade = i;
            }
            for(int i = 0; i < 50; i++)
            {
                if(grade[i]<50)
                {
                    grade[i] += 5;
                }
            }
            Console.WriteLine(students[maxgrade]);
        }
    }
}
