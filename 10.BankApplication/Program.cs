using System;

namespace _10.BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           Greetings();
        }


        static void LineBreaks()
        {
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Greetings()
        {
            LineBreaks();
            LineBreaks();
            Console.WriteLine("****************************************");
            LineBreaks();
            Console.WriteLine("        Welcome to Indian Bank"          );
            LineBreaks();
            Console.WriteLine("****************************************");
            LineBreaks();
           
           UserValidation();
        
        }

        static void UserValidation()
        {
           
            Console.WriteLine("****************************************");
            LineBreaks();
            Console.WriteLine("    Please Enter Your Account Number "   );
            LineBreaks();
            Console.WriteLine("****************************************");
            LineBreaks();
            Console.Write("Please Enter Here ------> ");
            LineBreaks();
            double accountNumber = double.Parse(Console.ReadLine());
            LineBreaks();
            Console.WriteLine("Welcome Mohan Sai Chandra"+"("+accountNumber+")");
            Services();
        }
        static void Services()
        {
            
            LineBreaks();
            Console.WriteLine("         Services You Can Opt             ");
            LineBreaks();
            Console.WriteLine("******************************************");
            LineBreaks();
            Console.WriteLine("         Press 1 For Deposit              ");
            Console.WriteLine();
            Console.WriteLine("         Press 2  For Cash WithDrawal     ");
            Console.WriteLine();
            Console.WriteLine("******************************************");
            int baseAmount=1500;
            int userAmount;
            Console.WriteLine("Please Enter Your Option Here");
            int selection= int.Parse(Console.ReadLine());
            if(selection==1)
            {
                Console.WriteLine("  Please Enter Your Amount  ");
                LineBreaks();
                userAmount=int.Parse(Console.ReadLine());
                LineBreaks();
                int  modifiedAmount=userAmount+baseAmount;
                LineBreaks();
                Console.WriteLine("Your Balance is  "+modifiedAmount);
                LineBreaks();
                Console.WriteLine("****Thank You Visit Again****");
                LineBreaks();
            }
            else if(selection==2)
            {
                Console.WriteLine("  Please Enter Your Amount  ");
                LineBreaks();
                 userAmount=int.Parse(Console.ReadLine());
                 LineBreaks();
                int modifiedAmount=baseAmount-userAmount;
                LineBreaks();
                Console.WriteLine("Your Balance is  "+modifiedAmount);
                LineBreaks();
                Console.WriteLine("****Thank You Visit Again****");
                LineBreaks();
            }
            else
            {
                LineBreaks();
                Console.WriteLine("******************************************");
                Console.WriteLine();
                Console.WriteLine("     Please Enter Correct Option !!!!");
                Console.WriteLine();
                Console.WriteLine("******************************************");
                LineBreaks();
            }
        }
    }
}
