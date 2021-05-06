using System;

namespace BankApplicationUsingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            IndianBank user1 = new IndianBank();
            Console.WriteLine("Welcome to Indian Bank");
            Console.WriteLine("----------------------");
            Console.WriteLine("Please Enter the Initial Amount for your Account");
            int initAmount = int.Parse(Console.ReadLine());
            user1.InitialBalance=initAmount;


            char UserChoice;
            do
            {
                Console.WriteLine("Below are the services Offered By the bank now");

                Console.WriteLine("Press 1 for Deposit");
                Console.WriteLine("Press 2 for WithDraw");
                Console.WriteLine("Press 3 for PrintingStatement");
                Console.WriteLine("Enter Here");
                byte userSelection = byte.Parse(Console.ReadLine());
                switch (userSelection)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the amount to Deposit");
                            int userAmount = int.Parse(Console.ReadLine());
                            user1.Deposit(userAmount);


                        }
                        break;
                    case 2:
                        {

                            Console.WriteLine("Enter the amount to WithDraw");
                            int userAmount = int.Parse(Console.ReadLine());
                            user1.WithDraw(userAmount);

                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Printing Your AccountStatement");
                            user1.PrintingStatement();
                        }
                        break;



                }
                Console.WriteLine("Do Perform Another Transaction");
                UserChoice = char.Parse(Console.ReadLine());
            } while (UserChoice == 'y');
        }
    }
}
