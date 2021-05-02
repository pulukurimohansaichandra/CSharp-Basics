using System;

namespace _13._5Additonandmultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            char userChoice='y';
            Console.WriteLine($"Addition and Multiplication of numbers");
            Console.WriteLine("---------------------------------------");
            while(userChoice!='n')
            {
            Console.WriteLine($"Press 1 for Addition");
            Console.WriteLine($"Press 2 for Multiplication");
            byte userOption=byte.Parse(Console.ReadLine());
            switch(userOption)
            {
               case 1:
               {
                   Console.WriteLine("Please Enter the first number");
                   int  num1=UserInput("First Number");
                   int  num2=UserInput("Second Number");
                   Console.WriteLine($" Sum of the given two numbers is {num1+num2}");
                   Console.WriteLine("Do You Wish to continue(y/n)");
                   userChoice=Char.Parse(Console.ReadLine());
               }break;  
                case 2:
                {
                  Console.WriteLine("Please Enter the first number");
                   int  num1=UserInput("First Number");
                   int  num2=UserInput("Second Number");
                   Console.WriteLine($" multiplication of the given two numbers is {num1*num2}");
                   Console.WriteLine("Do You Wish to continue(y/n)");
                   userChoice=Char.Parse(Console.ReadLine());  
                }break;
            }

            }   
            
        } 

        static int  UserInput(string name)
        {
            Console.WriteLine($"Please Enter the {name}");
            int num=int.Parse(Console.ReadLine());
            return num;
        }
    }
}
