using System;

namespace _13._4loops
{
    class Program
    {
        const int maxCount=1000;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
          int userNumber=int.Parse(Console.ReadLine());
          int count =1;
          for(;count<=1000;count++)
          {
              Console.WriteLine(count);
              if(count==userNumber)
              {

                  Console.Write($"{userNumber}---> Match Found. Stopping the loop");
                  break;
              }
          }

        }
    }
}
