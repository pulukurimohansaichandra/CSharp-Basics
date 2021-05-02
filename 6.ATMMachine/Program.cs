using System;

namespace _6.ATMMachine
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine(); 
             Console.WriteLine(); 
             Greetings();
        }

         static void Greetings()
         {
             Console.WriteLine(); 
             Console.WriteLine(); 
             Console.WriteLine("         Welcome to AXIS Bank ATM            "); 
              Console.WriteLine("*********************************************");
              Console.WriteLine(); 
             Console.WriteLine(); 
              LanguageSelection();
         }

        static void LanguageSelection()
        {
            Console.WriteLine(); 
            Console.WriteLine(); 
            Console.WriteLine("*********************************");
            Console.WriteLine();
            Console.WriteLine("  Pick language of your choice   ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine(" -------------------------------");
            Console.WriteLine("| Marathi       |       English |");
            Console.WriteLine("|-------------------------------|");
            Console.WriteLine("| Kannada       |         Hindi |");
            Console.WriteLine("|-------------------------------|");
            Console.WriteLine("| Oriya         |        Telugu |");
            Console.WriteLine("|-------------------------------|");
            Console.WriteLine("| Cancel                        |"); 
            Console.WriteLine(" ------------------------------- ");
            Console.WriteLine(); 
            Console.Write("Enter the selected language here --->  ");
            string Language=Console.ReadLine();
            Console.WriteLine(); 
            Console.WriteLine(); 
            Service();
        }

        static void Service()
        {
            Console.WriteLine(); 
            Console.WriteLine(); 
             Console.WriteLine("************************************************");
            Console.WriteLine(); 
            Console.WriteLine("                  Select a Service               ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" ----------------------------------------------- ");
            Console.WriteLine("|                             | CASH WITHDRAWAL |");
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("|                             | BALANCE ENQUIRY |");
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("|                             |  MINI STATEMENT |");
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("| MOBILE NUMBER UPDATE        |     PIN CHANGE  |");
            Console.WriteLine(" ----------------------------------------------- ");
            Console.WriteLine(); 
            Console.Write("Enter the selected Service here --->  ");
            string Service=Console.ReadLine();
            Console.WriteLine(); 
            Console.WriteLine(); 
             AccountType();
        }

       static void AccountType()
       {
            Console.WriteLine(); 
            Console.WriteLine(); 
            Console.WriteLine("*******************************************************");
            Console.WriteLine();
            Console.WriteLine("   Select your transaction by selecting account type    ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("              -------------------------------");
            Console.WriteLine("             |               |      CURRENT  |");
            Console.WriteLine("             |-------------------------------|");
            Console.WriteLine("             |               |      SAVINGS  |");
            Console.WriteLine("             |-------------------------------|");
            Console.WriteLine("             |               |  CREDIT CARD  |");
            Console.WriteLine("              ------------------------------- ");
            
            Console.WriteLine(); 
            Console.Write("Enter the selected Account Type here --->  ");
            string accType=Console.ReadLine();
            Console.WriteLine(); 
            Console.WriteLine(); 
            PinValidation();
       }

       static void PinValidation()
       {
          Console.WriteLine(); 
            Console.WriteLine();
            
            Console.Write("  Enter your PIN number ---> "); 
            string PIN=Console.ReadLine();
            Console.WriteLine(); 
            Console.WriteLine();
            Conformation();
       }

       static void Conformation()
       {
           Console.WriteLine(); 
            Console.WriteLine();
            
            Console.WriteLine(" Your Transaction is processing...........");
             Console.WriteLine();
            Console.WriteLine(" Your Transaction is Succesfull !");
             Console.WriteLine();
            Console.WriteLine(" Thank you visit again !");
           Console.WriteLine(); 
            Console.WriteLine(); 

       }


    }
}
