 //Write a C# program which prints out the values 1 to 10 on separate lines (Use WHILE statement)\\
    public class Program
    {
        static void Main(string[] Args)
        {
            int n = 1;
            while(n<=10)
                {
                    Console.WriteLine(n++);
                }
        }
    }
    ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
 //Write a C# program which prints out the values 1 to 10 on separate lines (Use FOR statement)\\
    public class Program
    {
        static void Main(string[] Args)
        {
            for(int i = 1; i <= 10; i++)
            { Console.WriteLine(i); }
        }
    }
    ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
    /*Write a C# program which produces the following output : (hint: use two nested FOR loops)
      1
      22
      333
      4444*/
      
    public class Program
    {
        static void Main(string[] Args)
        {
            int n=int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                for(int j = 0; j<i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            
        }
    }
     ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
/*Write a program that reads in the Student ID(integer) and scores(double, out of 100) of 30 students and
stores them in two arrays.Then the programs adds 2 points to all students whose score are less than 50.
Next, the program displays the Student ID with the highest grade as well the percentage of students who
passed the course.*/
    public class Program
    {
        static void Main(string[] Args)
        {
            int[] id = new int[30];
            double[] grade = new double[30];
            int max = 0;
            for(int i = 0; i < 30; i++)
            {
                id[i] = int.Parse(Console.ReadLine());
                grade[i] = double.Parse(Console.ReadLine());
                if (grade[i] < 50)
                    grade[i] += 2;
                if (grade[max] < grade[i])
                    max = i;
            }
            Console.WriteLine("Max = " + id[max]);
            Console.WriteLine("passed :");
            for(int i = 0; i <30;i++)
            {
                if(grade[i]>50)
                {
                    Console.Write(id[i] + " - ");
                }
            }
            
        }
    }
    ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
    /*Write a program which prints the max value of array with size 1000.*/
    public class Program
    {
        static void Main(string[] Args)
        {
            int[] arr = new int[1000];
            int maxx = int.MinValue;
            for(int i = 0; i < 1000; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if(maxx<arr[i])
                {
                    maxx = arr[i];
                }
            }
            Console.WriteLine(maxx);
        }
    }
    ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
     /*Write a program calculate the average of subject grade of 100 students.*/
    public class Program
    {
        static void Main(string[] Args)
        {
            int[] subjects = new int[100];
            double sum = 0;
            for(int i = 0; i < 100; i++)
            {
                subjects[i] = int.Parse(Console.ReadLine());
                sum+=subjects[i];
            }
            Console.WriteLine(sum/100);
        }
    }
    ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
     /*Write a program to calculate the tip a waiter should get in a restaurant. The input to the
    program is the number of people in the group and the bill. The tip is calculated as follows: if the bill
    is less than 50 pounds then the tip is fixed at 2 pounds per person in the group. If the bill is
    between 50 and 300 pounds then the tip is 10% of the bill plus 3 pound per person. If the bill is above
    300 pounds then the tip is 15% of the bill. The output of the program should be the tip AND the total
    amount to be paid.*/
    public class Program
    {
        static void Main(string[] Args)
        {
            double bill, persons, tip;
            persons = double.Parse(Console.ReadLine());
            bill = double.Parse(Console.ReadLine());
            if(bill<50)
            {
                tip = 2 * persons;
            }
            else if(bill>=50 && bill<300)
            {
                tip = (3 * persons) + (0.1 * bill);
            }
            else
            {
                tip = 0.15 * bill;
            }
            Console.WriteLine("tip = "+ tip +" Total Amount = " + (tip+bill));
        }
    }
    ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
    /*Write a program which prints out the statement "GOOD result " 10 times on separate lines (Use FOR statement)*/
    public class Program
    {
        static void Main(string[] Args)
        {
              for(int i = 0; i < 10; i++)
                Console.WriteLine("GOOD result");
        }
    }
     ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
    /*Write a program to read in a positive number and print out its factorial.*/
    public class Program
    {
        static void Main(string[] Args)
        {
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= n;i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
    ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
    
