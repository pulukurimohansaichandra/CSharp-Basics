using System;

namespace _13._3squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int number=UserInput("Number");
            PrintingSquare(number);
        }

        static void PrintingSquare(int number)
        {
            int row;
            int coloum;
            for(row=0;row<number;row++)
            {
                for(coloum=0;coloum<number;coloum++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    
        static int UserInput(string variable)
        {

         Console.WriteLine($"Enter the {variable}");
         int number =int.Parse(Console.ReadLine());
           return number;
        }
    }

}
