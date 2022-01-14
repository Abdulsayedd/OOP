using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    public class Animal
    {
        public int age;
        public string gender;
        public void ismamal()
        {
           
        }
        public void mate()
        {

        }
    }
    public class Duck : Animal
    {
        public string beakColor = "Yellow";
        public void swim()
        {

        }
        public void quack()
        {

        }
    }
    public class Fish : Animal
    {
        public int SizeInFt;
        public bool CanEat;
        public void swim()
        {

        }

    }
    public class Zebra : Animal
    {
        public bool is_wild;
        public void run()
        {

        }

    }
    public class Program
    { 
        static void Main(string[] Args)
        {
            Fish f = new Fish();
            f.SizeInFt = 3;
            f.CanEat = true;
            f.swim();
        }
    }
}
