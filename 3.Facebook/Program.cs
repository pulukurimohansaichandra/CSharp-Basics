using System;

namespace _3.Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
           LineBreaks();
           FBGreetings();
           LoginDetails();
           LineBreaks();
           TwitterGreetings();
           LoginDetails();
           LineBreaks();

        }

        static void FBGreetings()
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("|                                Facebook                               |");
            Console.WriteLine("|  Facebook helps you connect and share with the people in your life    |");
             Console.WriteLine("------------------------------------------------------------------------");
        }

         static void TwitterGreetings()
        {
             Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("|                                  Twitter Icon                           |");
            Console.WriteLine("|                                  Twitter                                |");
           
            Console.WriteLine("---------------------------------------------------------------------------");
        }

        static void LoginDetails()
        {
            Console.WriteLine("|                          Enter Username Or Email                     |");
            Console.WriteLine("|                         Password                                     |");
            Console.WriteLine("------------------------------------------------------------------------");
        }

        static void  LineBreaks()
        {
          Console.WriteLine();
          Console.WriteLine();

        }

    }
}
