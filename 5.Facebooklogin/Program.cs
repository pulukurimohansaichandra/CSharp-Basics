using System;

namespace _5.Facebooklogin
{
    class Program
    {
        static void Main(string[] args)
        {
           LineBreaks();
   FBGreetings();
   LineBreaks();
   Console.WriteLine("Enter the Login Credentials");
      Console.WriteLine("Enter Username");
      

   string emailOrPhone=Console.ReadLine();
   Console.WriteLine("Enter Password");  
   string Password=Console.ReadLine();
   if(emailOrPhone=="")
   {
     emailOrPhone="Invalid Username ";
   }
   if(Password=="")
   {
    Password="Invalid Password ";
   }
    Console.WriteLine(" _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
    Console.WriteLine("|  _ _ _ _ _ _ _ _ _ _ _ _ _ _  |");
    Console.WriteLine($"{"|"}  {"|"}  {emailOrPhone} {"|"} {"|"}");          
    Console.WriteLine("| | _ _ _ _ _ _ _ _ _ _ _ _ _ | |");
    Console.WriteLine("|  _ _ _ _ _ _ _ _ _ _ _ _ _ _  |");
    Console.WriteLine("| "+"|" +     Password+"|"+" |");
    Console.WriteLine("| |_ _ _ _ _ _ _ _ _ _ _ _ _ _| |");
   
    Console.WriteLine("|  _ _ _ _ _ _ _ _ _ _ _ _ _ _  |");
    Console.WriteLine("| |           Log In         |  |");
    Console.WriteLine("| |_ _ _ _ _ _ _ _ _ _ _ _ _ |  |");

    Console.WriteLine("|                               |"  );
    Console.WriteLine("|       forgot password?        |");
    Console.WriteLine("|_______________________________|");
    Console.WriteLine("|  _ _ _ _ _ _ _ _ _ _ _ _ _ _  |");
    Console.WriteLine("| |     Create New Account   |  |");
    Console.WriteLine("| |_ _ _ _ _ _ _ _ _ _ _ _ _ |  |");
    Console.WriteLine("| _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ |");
    LineBreaks();
        }
    
      static void FBGreetings()
      {
           Console.WriteLine("            facebook            ");
           Console.WriteLine();
    Console.WriteLine("Facebook helps you connect and share  ");
    Console.WriteLine(" with the people in your life.");
        }
      

      static void  LineBreaks()
      {
        Console.WriteLine();
        Console.WriteLine();



      }

  
     
}

}
