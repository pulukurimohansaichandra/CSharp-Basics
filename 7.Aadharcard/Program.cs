using System;

namespace _7.Aadharcard
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInformation();
        }

        static void UserInformation()
        {
            string firstName;
            string lastName;
            char initial;
            int age;
            float weigth;
            float height;
            string address;
            int zipCode=0;
            double phoneNumber=0;
            Console.WriteLine();
            Console.WriteLine("Enter the Firstname");
            firstName=Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the Lastname");
            lastName=Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the Initial");
            initial=Char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the Age");
            age= int .Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the Weight");
            weigth= float .Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the Height");
            height= float .Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the Address");
            address= Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the Zipcode");
            zipCode=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the Phonenumber");
            phoneNumber=double.Parse(Console.ReadLine());
            Console.WriteLine();
    
          Console.WriteLine("              User Information             ");
          Console.WriteLine("*******************************************");
          Console.Write("Your full name is  "+initial+" "+firstName+" "+lastName);
          Console.WriteLine();
           Console.Write("Your Age --->");
          Console.Write(age);
          Console.WriteLine();
          Console.WriteLine("Your Weigth--->");
          Console.Write(weigth);
          Console.WriteLine();
          Console.WriteLine("Your Height --->");
          Console.Write(height);
          Console.WriteLine();
           Console.WriteLine("Your Address --->");
          Console.Write(address);
          Console.WriteLine();
           Console.WriteLine("Your Zip Code --->");
          Console.Write(zipCode);
          Console.WriteLine();
          Console.WriteLine("Your Phone Number  --->");
          Console.Write(phoneNumber);
          Console.WriteLine();
          Console.WriteLine("*******************************************");

        }
    }
}
