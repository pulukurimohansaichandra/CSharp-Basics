using System;

namespace _14.BankProject
{
    class Program
    {
        const int PinNumber=5456,minimumbankbalance=500;
        static double UserBalace=1000;
        static void Main(string[] args)
        {
            MainService();
        }

        static void MainService()
        {
            char userServiceRequest;
           byte userChoice=0;
            do{
               
               userChoice=Greetings();
               ServiceProcessing(userChoice);
               userServiceRequest=UserServiceRequest();
               
            }while(userServiceRequest=='A');
            
        }

        static byte Greetings()
        {
            Console.WriteLine($" -------------------------------------------");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"|            Welcome to SBI ATM             |");
            Console.WriteLine($"|            ------------------             |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"| Please Enter the PIN Number               |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($" -------------------------------------------");
            Console.WriteLine();
            byte userchoice=PinValidation();
            return userchoice;
        }

        static byte PinValidation()
        {
            byte userchoice=0;
            Console.Write($" Enter the Here-----> ");
            int userPin=int.Parse(Console.ReadLine());
            if(userPin==PinNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome Mr Pulukuri Mohan Sai Chandra");
                Console.WriteLine($"------------------------------------");
                Console.WriteLine();
               userchoice= Services();
            }
            else 
            {
                Console.WriteLine("Please Enter the Valid PIN number!!");
                
            }

            return userchoice; 
        }

        static byte Services()
        {
            Console.WriteLine($" ----------------------------------------------------------------");
            Console.WriteLine($"|                                                                |");
            Console.WriteLine($"|                            SERVICES                            |");
            Console.WriteLine($"|                        ------------------                      |");
            Console.WriteLine($"|                                                                |");
            Console.WriteLine($"|---> 1.DEPOSIT                                                  |");
            Console.WriteLine($"|---> 2.WITHDRAWAL                                               |");
            Console.WriteLine($"|---> 3.BALANCE ENQUIRY                                          |");
            Console.WriteLine($"|                                                                |");
            Console.WriteLine($"|                                                                |");                    
            Console.WriteLine($"|                                                                |");
            Console.WriteLine($" ----------------------------------------------------------------");

             Console.WriteLine($" Please Enter the Choice-------->");
             byte userChoice=byte.Parse(Console.ReadLine());
            return userChoice;
        }

        static void ServiceProcessing(byte userchoice)
        {
            
            switch(userchoice)
            {
                case 1:
                {
                    Deposit();
                    Console.WriteLine($"Balance is {UserBalace}");
                }break;
                case 2:
                {
                     Withdrawal();
                    Console.WriteLine($"Balance is {UserBalace}");
                }break;
                case 3:
                {
                    BalanceEnquiry();
                }break;
            }

        }

        static void Deposit()
        {
            Console.WriteLine($" -------------------------------------------");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"|                  DEPOSIT                  |");
            Console.WriteLine($"|            ------------------             |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"| Please Enter The Amount                   |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($" -------------------------------------------");
            Console.WriteLine("Enter the ammout here");
            double amount = double.Parse(Console.ReadLine());
            UserBalace+=amount;
        }

        static void  Withdrawal()
        {
           Console.WriteLine($" -------------------------------------------");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"|                WITHDRAWAL                 |");
            Console.WriteLine($"|            ------------------             |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"| Please Enter The Amount                   |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($" -------------------------------------------");
            Console.WriteLine("Enter the ammout here");
            double amount = double.Parse(Console.ReadLine());
            if((UserBalace-amount)<minimumbankbalance)
            {
                Console.WriteLine("Amount falls under minimum bank balance limit!!");
            }
            else if(amount>UserBalace)
            {
               Console.WriteLine("Insufficent balance ");
            } 
            else
            {
              UserBalace-=amount;
            }
        }

        static void BalanceEnquiry()
        {
            Console.WriteLine($" -------------------------------------------");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"|              BALANCE ENQUIRY              |");
            Console.WriteLine($"|            -------------------            |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"| Balance {UserBalace}                      |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($" -------------------------------------------");
        }

        static char UserServiceRequest()
        {
            Console.WriteLine($" -------------------------------------------");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"|    THANK YOU FOR USING SERVICES :)        |");
            Console.WriteLine($"|    -------------------------------        |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($"| Press A for Another Transaction           |");
            Console.WriteLine($"| Press E for Exit                          |");
            Console.WriteLine($"|                                           |");
            Console.WriteLine($" -------------------------------------------");
            Char userChoice=Char.Parse(Console.ReadLine());
            return userChoice;
        }
    }
}
