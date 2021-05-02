using System;

namespace _1.WelcomePrograme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("--------------------------------------------");
            Greetings();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            UserValidation();
            Console.WriteLine();
         
            DisplayBasicUserInfo();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

     
        }


        static void Greetings()
        {
            Console.WriteLine("        Welcome To Indian Railways");
         

        }
        static void DisplayBasicUserInfo()
        {
            int userId=63961;
            string name="Pulukuri Mohan Sai Chandra";
            Console.WriteLine("    Hello"+" "+name+"("+userId+")");
 
        }


        static void UserValidation()
        {
            Console.WriteLine("       User Succesfully Validated");
            Console.WriteLine();
        }
    }


}
