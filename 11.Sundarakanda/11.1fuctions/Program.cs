using System;

namespace _11._1fuctions
{
    class Program
    {
       static double bankMinimumBalance=100;

       static  double userBalance;

        static void Main(string[] args)
        {
            string user1="Acc9390263961";
            string user2="Acc7386781965";
            string user3="Acc9100168663";
            double User1B=1000;
            double User2B=100;
            double User3B=500;
            Account(user1,User1B);
            Account(user2,User2B);
            Account(user3,User3B);
            
           
            
        }

        static void Account(string user,double userb)
        {
           Console.WriteLine();
           Console.WriteLine();
           Console.WriteLine("Welcome to Bank ");
           Console.WriteLine("----------------");
           Console.WriteLine();
           Console.WriteLine(" Account under Processing-----> "+user);
           Console.WriteLine("-------------------------------------");
           Console.WriteLine();
           Console.WriteLine("Below are the following services at the bank");
           Console.WriteLine("1.Deposit ");
           Console.WriteLine("2.Withdraw");
           Console.WriteLine("Please Enter the Option here---->");
           byte userOpt=byte.Parse(Console.ReadLine());
           if(userOpt==1)
           {
               Console.WriteLine();
               Console.WriteLine("Please Enter the amount ");
               double Useramount =double.Parse(Console.ReadLine());
               Deposit(user,userb,Useramount);
              
               Console.WriteLine();
               Console.WriteLine("------------------------------------------");
               Console.WriteLine();
           }
           else
           {
               double finalamount=0;
               Console.WriteLine();
               Console.WriteLine("Please Enter the amount ");
               double Useramount =double.Parse(Console.ReadLine());
               finalamount= WithDraw(user,userb,Useramount);
                
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(finalamount);
           }
        }

        static void Deposit(string user ,double userbalance, double useramount)
        {
            
             userBalance=useramount+userbalance ;
             Console.WriteLine("The Current Balance is----->"+userBalance); 
        }

        static double WithDraw(string user,double userbalance,double useramount)
        {
            double result=0;
            double  bCheck=userbalance-useramount;
           if(bCheck<bankMinimumBalance)
           {
               UserAmountValidation();
               userBalance=userbalance;
                Console.WriteLine("The Current Balance is----->"+userBalance);

           }
           else
           {
             userBalance=userbalance-useramount;
             result=userBalance;
             Console.WriteLine("The Current Balance is----->"+userBalance);
             
           }

           return result;
        }
        

        static void UserAmountValidation()
        {
            Console.WriteLine();
          Console.WriteLine("Entered amount is excedding minimum balance please maintain the sufficient balance to continue the service!!!!!!!!");
          
          Console.WriteLine( );
        }

        

    }
}
