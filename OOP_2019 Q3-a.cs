using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class swapp
    {
        public void swap(ref int p1, ref int p2)
        {
            int temp;
            temp = p1;
            p1 = p2;
            p2 = temp;
        }
    }
    public class Program
    { 
        static void Main(string[] Args)
        {
            swapp s = new swapp();
            int first_num,second_num;
            Console.WriteLine("Enter the first number ");
            first_num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            second_num = int.Parse(Console.ReadLine());
            s.swap(ref first_num, ref second_num);
            Console.WriteLine("First Number = {0} , Second Number = {1}",first_num,second_num);

        }
    }
}
