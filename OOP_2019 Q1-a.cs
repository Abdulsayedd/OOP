using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class Sphere
    {
        const double pi = 3.14159265359;
        double S_Area, S_Volume;
        public void Calculate(int r)
        {
            S_Area = 4 * pi * r * r;
            S_Volume = (4 / 3) * pi * r * r * r;
            Print();
        }
        public void Print()
        {
            Console.WriteLine("Sphere Volume = " + S_Volume +"\nSphere Area = " + S_Area);
            
        }
    }
    public class Program
    {
        static void Main(string[] Args)
        {
            Sphere s = new Sphere();
            s.Calculate(3);
        }
    }
}
