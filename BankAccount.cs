using System;

namespace engradwa
{
    class Date
    {
        private string day,month,year;

        public string Day { get => day; set => day = value; }
        public string Month { get => month; set => month = value; }
        public string Year { get => year; set => year = value; }

        public string date()
        {
            string daate = day + "/" + month + "/" + year;
            return daate;
        }
        public void display()
        {
            Console.WriteLine("Assigned date = {0}" , date());
        }
    }
    class BankAccount
    {
        private int accountNo, balance=0;
        private string accountOwner, openDate;

        public int AccountNo { get => accountNo; set => accountNo = value; }
        public int Balance { get => balance; set => balance = value; }
        public string AccountOwner { get => accountOwner; set => accountOwner = value; }
        public string OpenDate { get => openDate; set => openDate = value; }

        public BankAccount(int start)
        {
            balance = start;
        }
        public BankAccount()
        {}
        public void deposite(int n)
        {
            balance += n;
        }
        public void withdraw(int n)
        {
            balance -= n;
        }
        public void display()
        {
            Console.WriteLine("Your balance = {0}",balance);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            string error = "Error (day cannot be {0}), Enter the day again :";
            Console.WriteLine("Enter the day : " );
            string x;
            x = Console.ReadLine();
            while(int.Parse(x)>31)
            {
                Console.WriteLine(error,x);
                x = Console.ReadLine();
            }
            date.Day = x;
            //////////////////
            Console.WriteLine("Enter the month : ");
            x = Console.ReadLine();
            while (int.Parse(x) > 12)
            {
                Console.WriteLine(error, x);
                x = Console.ReadLine();
            }
            date.Month = x;
            //////////////////
            Console.WriteLine("Enter the year : ");
            x = Console.ReadLine();
            while (int.Parse(x) > 2022)
            {
                Console.WriteLine(error, x);
                x = Console.ReadLine();
            }
            date.Year = x;
            ////////////////////////
            ////////////////////////
            ////////////////////////
            Console.WriteLine("Do you want to add initial balance ? Y/N ");
            char p = char.Parse(Console.ReadLine());
            BankAccount BA;
            if (p=='Y' || p=='y')
            {
                Console.WriteLine("Enter initial balance :");
                int sal = int.Parse(Console.ReadLine());
                BA = new BankAccount(sal);
            }
            else
            {
               BA = new BankAccount();
            }
                Console.WriteLine("Account Created!");
            char m='0';
            while (m!='4')
            {
                Console.WriteLine("1.Display balance \n 2.withdraw \n 3.deposite \n 4.quit");
                m = char.Parse(Console.ReadLine());
                int n;
                switch (m)
                {
                    case '1':
                        BA.display();
                        break;
                    case '2':
                        Console.WriteLine("Enter the amount : " );
                        n = int.Parse(Console.ReadLine());
                        BA.withdraw(n);
                        break;
                    case '3':
                        Console.WriteLine("Enter the amount : ");
                        n = int.Parse(Console.ReadLine());
                        BA.deposite(n);
                        break;
                    case '4':
                        Console.WriteLine("Thank You!");
                        break;
                    default:
                        Console.WriteLine("Not a valid choice!");
                        break; 
                }
            }
            
            
        }
    }
}
