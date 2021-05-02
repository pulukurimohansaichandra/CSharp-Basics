using System;

namespace _9.Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //designation of software engineer role
            //eligibile role 
            //1)Software developer 
         
            //eligibile age for the both role id greater than 22 but not greater than 30 
           int num1;
           int num2;

          num1=int.Parse(Console.ReadLine());
           num2=int.Parse(Console.ReadLine());
         
           if(num1==num2)
           {
               Console.WriteLine("Entered numbers are same ");
           }
            else if(num1>num2)
            {
                Console.WriteLine( num1+" is Greater ");
            }

            else{
                Console.WriteLine(num2+"  is Greater ");
            }
           
           
           
     NameCompare();


        }
        static void NameCompare()
        {
            string inputName1;
           string inputName2;
          
           Console.WriteLine("Enter the inputname1");
           inputName1=Console.ReadLine();
           Console.WriteLine();
           Console.WriteLine("Enter the inputname2");
           inputName2=Console.ReadLine();
           Console.WriteLine();
         
           if(inputName1==inputName2)
           {
               Console.WriteLine("Entered names are same ");
           }
            else
           {
               Console.WriteLine("Entered names are not same ");
           }
           


        }

       }
    }


