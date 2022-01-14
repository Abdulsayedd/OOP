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
        private int SizeInFt;
        private bool CanEat;
        public int SIZEINFT
        {
            set { SizeInFt = value; }
            get { return SizeInFt; }
        }
        public bool CANEAT
        {
            set { CanEat = value; }
            get { return CanEat; }
        }

        private void swim()
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
            f.CANEAT = true;
            f.SIZEINFT = 3;
            f.swim();
        }
    }
}
