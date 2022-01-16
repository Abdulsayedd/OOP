   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
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
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
    //Write a C# program which prints out the values 1 to 10 on separate lines (Use FOR statement)\\
    public class Program
    {
        static void Main(string[] Args)
        {
            for(int i = 1; i <= 10; i++)
            { Console.WriteLine(i); }
        }
    }
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
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
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
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
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
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
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
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
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
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
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
       /*Write a program which prints out the statement "GOOD result " 10 times on separate lines (Use FOR statement)*/
    public class Program
    {
        static void Main(string[] Args)
        {
              for(int i = 0; i < 10; i++)
                Console.WriteLine("GOOD result");
        }
    }
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
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
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
     /*write a program that reads in the grades of 50 students in a course (out of 100 points each ) and
    then count the number of A students ( grade >= 85 ) and the number of B students (75<= grade <85)*/
    public class Program
    {
        static void Main(string[] Args)
        {
            int[] grade = new int[50];
            int a = 0, b = 0;
            for(int i = 0; i < 50; i++)
            {
                grade[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A Students : ");
            for(int i = 0; i < 50; i++)
            {
                if (grade[i] >= 85)
                    a++;
            }
            Console.WriteLine(a);
            Console.WriteLine("B Students : ");
            for (int i = 0; i < 50; i++)
            {
                if (grade[i] >= 75 && grade[i]<85)
                    b++;
            }
            Console.WriteLine(b);

        }
    }
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
   /*Write a C program that calculate the total price of a certain purchase. There is a discount and shipping
        cost:
        ● The discount rate is 20% and the shipping is 10.00 if purchase is over 200.00.
        ● Otherwise, The discount rate is 15% and the shipping is 5.00 pounds*/
    public class Program
    {
        static void Main(string[] Args)
        {
           double purchase = double.Parse(Console.ReadLine());
            if(purchase > 200)
            {
                Console.WriteLine(purchase-(0.2*purchase)+10 + "$");
            }
            else
            {
                Console.WriteLine(purchase - (0.15 * purchase) + 5 +"$");
            }

        }
    }
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
    /*Write a C program that calculate the average score of a class scores of one subject and the max – min scores*/
    public class Program
    {
        static void Main(string[] Args)
        {
           int n = int.Parse(Console.ReadLine());
           int[] arr = new int[n];
           double sum=0,maxx=int.MinValue,minn=int.MaxValue;
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
                if(maxx<arr[i])
                    maxx = arr[i];
                if(minn>arr[i])
                    minn = arr[i];
            }
            Console.WriteLine("avg : "+(double)sum/n + " max = " + maxx + " min = " + minn);

        }
    }
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
    /*Write a program to calculate the salary of a waiter should get in a restaurant. The input to the program
    is the number of hours. The salary is calculated as follows: if he work up to 150 hours then the rate is
    fixed at 10 pounds per hour and if he work more than 150 hours then the overtime rate is 15 pound per
    hour. There is a tip for %10 from his salary.*/
    public class Program
    {
        static void Main(string[] Args)
        {
            double h = int.Parse(Console.ReadLine());
            double sal = 0;
            if (h <= 150)
            {
                sal = h * 10;
                Console.WriteLine(sal);
            }
            else
            {
                sal = 1500;
                sal += (h - 150) * 15;
                sal += sal * 0.1;
                Console.WriteLine(sal);
            }

        }
    }
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
    /*Write a program to ask a student for his grades in 5 exams ( each out of 100 ) , 
     * get their total and inform the student by (his/her) average*/
    public class Program
    {
        static void Main(string[] Args)
        {
            double e1, e2, e3, e4, e5;
            Console.WriteLine("Exam 1 : ");
            e1= double.Parse(Console.ReadLine());
            Console.WriteLine("Exam 2 : ");
            e2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Exam 3 : ");
            e3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Exam 4 : ");
            e4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Exam 5 : ");
            e5 = double.Parse(Console.ReadLine());
            Console.WriteLine("The Average is = " + ((e1+e2+e3+e4+e5)/5));

        }
    }
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
     /*Write a program which calculate the area of a circle.*/
    public class Program
    {
        static void Main(string[] Args)
        {
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine((double)3.14*r*r);
        }
    }
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
  /*Write a program to calculate the total salary of an employee with tax rate 10% if his income is less than
    20000 pounds and the tax rate is 15% if the income is between 20000 and 25000 pounds, otherwise the
    tax rate is 20%.*/
    public class Program
    {
        static void Main(string[] Args)
        {
            double sal = double.Parse(Console.ReadLine());
            if(sal<20000)
                Console.WriteLine(sal-(sal*0.1));
            else if(sal>=20000 && sal<25000)
                Console.WriteLine(sal-(sal*0.15));
            else
                Console.WriteLine(sal - (sal * 0.2));
        }
    }
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
    /*Write a C# program to calculate the electricity bill. Given the current and previous readings, such that
    there are 3 categories:
    (1) If the consuming kilowatts less than 100 then the price/kilowatt = 10 p,
    (2) If the consuming kilowatts between 100 and 150 then the price/kilowatt =15 p,
    (3) If the consuming kilowatts between 150 and 200 then the price/kilowatt =20 p,
    (4) If the consuming kilowatts greater than 200 then the price/kilowatt = 25p*/
    public class Program
    {
        static void Main(string[] Args)
        {
            double kw = double.Parse(Console.ReadLine());
            if (kw < 100)
                Console.WriteLine(kw * 10);
            else if (kw < 150 && kw >= 100)
                Console.WriteLine(kw * 15);
            else if (kw < 200 && kw >= 150)
                Console.WriteLine(kw * 20);
            else
                Console.WriteLine(kw * 25);

        }
    }
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
    /*Write a program to get the roots of a quadratic equation, given the 3 coefficients a, b, and c*/
    public class Program
    {
        static void Main(string[] Args)
        {
            double a, b, c,bst,mkam;
            a=double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            bst = (-b) + Math.Sqrt((b * b) - (4 * a * c));
            mkam = 2 * a;
            Console.WriteLine("Plus = " + (bst/mkam));
            bst = (-b) - Math.Sqrt((b * b) - (4 * a * c));
            mkam = 2 * a;
            Console.WriteLine("Minus = " + (bst / mkam));
        }
    }
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
/*Write a program to create a function to calculate the area of rectangle and then use this function to get
    the area of rectangles of dimensions:
    a- l=5 w=10
    b- l=10 w= 15
    c- l=7 w=11*/
    public class Program
    {
        static double rectarea(int l , int w)
        {
            return 0.5 * w * l;
        }
        static void Main(string[] Args)
        {
            Console.WriteLine(rectarea(5, 10));
            Console.WriteLine(rectarea(10, 15));
            Console.WriteLine(rectarea(7, 11));
        }
    }
   ▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄
   ▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀▀█▄▄█▀
