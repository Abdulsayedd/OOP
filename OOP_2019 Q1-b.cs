using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class odven
    {
        
        public void fun(int p1,int p2)
        {
            if ((p1 % 2 == 0 && p2 % 2 == 0) || (p1 % 2 == 1 && p2 % 2 == 1))
                print(true);
            else
                print(false);
        }
        public void print(bool h)
        {
            Console.WriteLine(h);
        }
    }
    public class Program
    {
        static void Main(string[] Args)
        {
            odven s = new odven();
            s.fun(3,3);
            s.fun(3, 4);
            s.fun(6, 5);
            s.fun(22, 2);
        }
    }
}
