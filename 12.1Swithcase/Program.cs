using System;

namespace _12._1Swithcase
{
    class Program
    {
        const double minBalace=100;
        static double Userbalance;
        static void Main(string[] args)
        {
            string userone="acc9390263961";
            string usertwo="acc7386781965";
            string userthree="acc9100168663";
            double acc9390263961=1000;
            double acc7386781965=100;
            double acc9100168663=500;
            Accountant(acc9390263961,userone);
            Console.WriteLine();
            Accountant(acc7386781965,usertwo);
            Console.WriteLine();
            Accountant(acc9100168663,userthree);
            Console.WriteLine();

        }

        static void Accountant(double accountBalance,string user)
        {
            int userOption=UserOption(user);
            switch(userOption)
            {
                case 1:
                {

                    Console.WriteLine("Please Enter the Ammount");
                    double userAmount=double.Parse(Console.ReadLine());
                    Deposit(accountBalance,userAmount);
                    Console.WriteLine("The Updated Balance is "+Userbalance);
                    Greetings();
                }break;

                case 2:
                {
                  Console.WriteLine("Please Enter the Ammount");
                  double userAmount=double.Parse(Console.ReadLine());
                  WithDrawal(accountBalance,userAmount);
                  Console.WriteLine("The Updated Balance is "+Userbalance);
                  Greetings();
                }break;
            }
        }

        static void Lines()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }

        static int UserOption(string user)
        {
            Lines();
            Console.WriteLine("               Welcome to Indian Bank                ");
            Lines();
            Console.WriteLine("    Processing for the current user-->"+user);
            Lines();
            Console.WriteLine("            The Services at the Bank are ");
            Lines();
            
            Console.WriteLine("             1.Press 1 for Deposit ");
            Console.WriteLine("             2.Press 2 for Withdrawal ");
            Console.WriteLine();
            Console.Write("Please enter the option here-------->");
            int userOption=int.Parse(Console.ReadLine());
            Lines();
            
            Console.WriteLine();
            return userOption ;
        }

        static void Deposit(double userBalance,double userAmount)
        {
            Userbalance=userBalance+userAmount;
            
        }

        static void WithDrawal(double userBalance,double userAmount)
        {
        double balanceChecker=userBalance-userAmount;
        if(balanceChecker<minBalace)
        {
            AmountValidation();
            Userbalance=userBalance;
            
        }
        else
        {
            Userbalance= userBalance-userAmount;
            
        }
        }

        static void AmountValidation()
        {
            Console.WriteLine("Further Deduction of amount will falls the balance below the account limit");
            Console.WriteLine("Transction unsuccusfull");
        }

        static void Greetings()
        {
            Lines();
            Console.WriteLine("Thanks for Using Services Please Visit Again!!!!! :) ");
            Lines();
        }
    }

}
