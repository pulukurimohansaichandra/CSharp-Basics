using System;

namespace _9._1.Conditions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        static void Calculator()
        {
         Console.WriteLine("Calculator");
         Console.WriteLine("1.Addition");
         Console.WriteLine("2.Multiplication");
         Console.WriteLine("3.Subraction");
         Console.WriteLine("4.Division");
         UserOption();

         
        }

        static void UserOption()
        {
          Console.WriteLine("Please Enter Your Option");
          Byte UOption = Byte.Parse(Console.ReadLine());
        if(UOption==1)
        {
            Console.WriteLine("Please Enter Two Numbers");
            Console.WriteLine();
            Console.WriteLine("Please First  Number");
            int numOne=int.Parse(Console.ReadLine());
             Console.WriteLine("Please Second  Number");
            int numTwo=int.Parse(Console.ReadLine());
            if(CheckIfFloatNumIsZero(numOne))
            {
                Console.WriteLine("Entered  First  Number Is Not Valid");
            }
            if(CheckIfFloatNumIsZero(numTwo))
            {
                Console.WriteLine("Entered  Second  Number Is Not Valid");
            }
          
            int resultAdd = Addition(numOne,numTwo);
            Console.WriteLine("Result "+resultAdd);
           
            
        }
        else if(UOption==2)
        {
               Console.WriteLine("Please Enter Two Numbers");
            Console.WriteLine();
            Console.WriteLine("Please First  Number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Please Second  Number");
            int num2=int.Parse(Console.ReadLine());
             if(CheckIfFloatNumIsZero(num1))
            {
                Console.WriteLine(" Entered  First  Number Is Not Valid");
            }
             if(CheckIfFloatNumIsZero(num2))
            {
                Console.WriteLine("Entered  Second  Number Is Not Valid");
            }
           
            int resultMul = Multipication(num1,num2);
            Console.WriteLine("Result "+resultMul);
        }
        else if(UOption==3)
        {
               Console.WriteLine("Please Enter Two Numbers");
            Console.WriteLine();
            Console.WriteLine("Please First  Number");
            int subInp1=int.Parse(Console.ReadLine());
            Console.WriteLine("Please Second  Number");
            int subInp2=int.Parse(Console.ReadLine());
            if(CheckIfFloatNumIsZero(subInp1))
            {
                Console.WriteLine(" Entered  First  Number Is Not Valid");
            }
             if(CheckIfFloatNumIsZero(subInp2))
            {
                Console.WriteLine("Entered  Second  Number Is Not Valid");
            }
           
            int resultSub = Subraction(subInp1,subInp2);
            Console.WriteLine("Result "+resultSub);
        }
        else if(UOption==4)
        {
            Console.WriteLine("Please Enter Two Numbers");
            Console.WriteLine();
            Console.WriteLine("Please First  Number");
            float divInp1=float.Parse(Console.ReadLine());
            Console.WriteLine("Please Second  Number");
            float divInp2=float.Parse(Console.ReadLine());
             if(CheckIfFloatNumIsZero(divInp1))
            {
                Console.WriteLine(" Entered  First  Number Is Not Valid");
            }
             if(CheckIfFloatNumIsZero(divInp2))
            {
                Console.WriteLine("Entered  Second  Number Is Not Valid");
            }
           
            float resultDiv =Division(divInp1,divInp2);
            Console.WriteLine("Result "+resultDiv);
            
            
         }
         else
         {
             Console.WriteLine("Please Enter The Vaild Option ");
         }
      

          
        }

        static int Addition( int numOne,int numTwo)
        {
          
          return numOne+numTwo;
        }

        static int Multipication(int num1,int num2)
        {
             
          return num1*num2;
        }

        static int Subraction(int num1,int num2)
        {
            if(num2>num1) 
               return num2-num1;
            else 
               return num1-num2;
        }

        static float Division(float num1,float num2)
        {
             
          return num1/num2;
        }

    //* static bool CheckIfNumIsZero(int number)
     //   {
      ///    if(number==0)
      //    {
       //       return true;
       //   }
//else
      //    {
          //    return false;
         // }
        //}
        static bool CheckIfFloatNumIsZero(float number)
        {
          if(number==0)
          {
              return true;
          }
          else
          {
              return false;
          }
            

        }
    }

}
