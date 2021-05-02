using System;

namespace _13._2Loopstable
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplication();
        }

        static void Multiplication()
        {
            int number= UserInput(" number for generating table");
            int minnum= UserInput("Minimum number ");
            int maxnum= UserInput("Maximum number  ");
            

            Console.WriteLine("enter 1 for working with for loop");
            Console.WriteLine("enter 2 for working with while loop");
            Console.WriteLine("enter 3  for working with do while loop");

            int useroption = UserInput("useroption ");
            
            UsingSwitch(number,minnum,maxnum,useroption);
            
        }

        static int  UserInput(string userinput)
        {
           
           Console.WriteLine($" Please enter the {userinput}");
           int enterduservalue=int.Parse(Console.ReadLine());

           return enterduservalue;
            
        }

        static void UsingSwitch(int number ,int minnum,int maxnum,int useroption)
        {
           int count=0;
           switch(useroption)
           {
                case 1:
                {
                  for(count =minnum;count<=maxnum;count++)
                  {
                    Console.WriteLine($"{number}*{count}={number*count}");
                  }      

                }break;

                case 2:
                {
                    while(minnum<=maxnum)
                    {
                      Console.WriteLine($"{number}*{minnum}={number*minnum}");
                        minnum++;
                    }
                    
                }break;
                case 3:
                {
                   
                   do
                   {
                       Console.WriteLine($"{number}*{minnum}={number*minnum}");
                       minnum++;
                   }while(minnum<=maxnum);
                }break;
                
           }
            
        }
    }

}
