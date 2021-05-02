using System;

namespace _15.SuperMarket
{
    class Program
    {
        static int apple= 1000;
        static int banana=1000;
        static int oranges =1000;
        static int grapes =1000;
        
        static int userApples=0;
        static int userBanana=0;
        static int userOrange=0;
        static int userGrapes=0;
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("                    Welcome To BigBazar                        ");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            UserSelect();
        }

        static void UserSelect()
        {
            char userSelect;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please select the user  ");
                Console.WriteLine("------------------------");
                Console.WriteLine("Press 1 for Customer ");
                Console.WriteLine("Press 2 for Manager  ");
                Console.WriteLine("Please select here  ");
                int userchoice =int.Parse(Console.ReadLine());
                switch(userchoice)
                {
                    case 1:
                    {
                       Customer(); 
                    }break;

                    case 2:
                    {
                       Manager();
                    }break;

                    
                }
                Console.WriteLine("Please enter if you want to use the service (Y/N)");
                userSelect=char.Parse(Console.ReadLine());
            }while(userSelect=='Y');
        }
        static void Manager()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome Mr Bala Krishna ");
            Console.WriteLine("------------------------");
            Console.WriteLine("Employee ID = 24568");
            Console.WriteLine("Designation=Branch Manager");
            char managerChoice;
            do
            {
            Console.WriteLine();
            Console.WriteLine($"Please Enter the option for audit selection");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Press 1 for Inventory");
            Console.WriteLine($"Press 2 for TodaySales");
            
            Console.WriteLine($"Please Enter here");
            int select = int.Parse(Console.ReadLine());
            switch(select)
            {
                case 1:
                {
                    Inventory();
                }break;

                case 2:
                {
                      TodaySales();
                }break;

            }
            Console.WriteLine($"Please select if want to audit again");
            managerChoice=char.Parse(Console.ReadLine());
            
            }while(managerChoice=='Y');

        }

        static void Inventory()
        {
            Console.WriteLine("Current Stocks");
            Console.WriteLine("---------------");
            Console.WriteLine($"Apples : {apple}");
            Console.WriteLine($"Bananas : {banana}");
            Console.WriteLine($"Oranges : {oranges}");
            Console.WriteLine($"Grapes : {grapes}");
            Console.WriteLine("----------------------");
            Console.WriteLine("Do you want to order the inventory (Y/N)");
            char ManagerChoice=char.Parse(Console.ReadLine());
            if(ManagerChoice=='Y')
            {
                ToOrderInventory();
            }
            
            
        }

        static void TodaySales()
        {
            Console.WriteLine($"Today Apples Sales = {userApples}");
            Console.WriteLine($"Today Bananas Sales = {userBanana}");
            Console.WriteLine($"Today Oranges Sales = {userOrange}");
            Console.WriteLine($"Today Grapes Sales = {userGrapes}");
        }

        static void ToOrderInventory()
        {
            char managechoice;
            do{
            Console.WriteLine($"Press 1 to Order to Apple");
            Console.WriteLine($"Press 2 to Order to Bananas");
            Console.WriteLine($"Press 3 to Order to Oranges");
            Console.WriteLine($"Press 4 to Order to Grapes");
            Console.WriteLine("Please Enter the Option here");
            int mangerOption=int.Parse(Console.ReadLine());
            switch(mangerOption)
            {
                case 1:
                {
                  Console.WriteLine("Please enter how many pieces of apples  you  need  ");
                  int apples =int.Parse(Console.ReadLine());
                  apple+=apples;
                }break;
                case 2:
                {
                 Console.WriteLine("Please enter how many dozens of Bananas  you  need  ");
                  int bananas =int.Parse(Console.ReadLine());
                  banana+=bananas;
                }break;
                case 3:
                {
                     Console.WriteLine("Please enter how many pieces of Oranges  you  need  ");
                  int orange =int.Parse(Console.ReadLine());
                  oranges+=orange;
                }break;
                case 4:
                {
                  Console.WriteLine("Please enter how many KG's of Grapes  you  need  ");
                  int grape =int.Parse(Console.ReadLine());
                  grapes+=grape;
                }break;
            }
             Console.WriteLine("Do you wish to continue to order (Y/N)");
             managechoice=char.Parse(Console.ReadLine());
            }while(managechoice=='Y');
        } 

        static void  Customer()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome Mr Pulukuri Mohan Sai Chandra");
            Console.WriteLine("-------------------------------------");
            CurrentInventory(); 
        }

        static void  CurrentInventory()
        {
            char Userchoice;
            Console.WriteLine($"Today's Items In Stock");
            Console.WriteLine("------------------------");
            Console.WriteLine($"Apples : {apple} Pieces");
            Console.WriteLine($"Bananas : {banana} Dozens");
            Console.WriteLine($"Oranges : {oranges} Pieces");
            Console.WriteLine($"Grapes : {grapes} KG's");
            do{
            Console.WriteLine();
            Console.WriteLine($"Press 1 if you Want to select Apples");
            Console.WriteLine($"Press 2 if you Want to select Banana");
            Console.WriteLine($"Press 3 if you Want to select Oranges");
            Console.WriteLine($"Press 4 if you Want to select Grapes");
            Console.WriteLine();


            Console.WriteLine("Please Enter the Option");
            byte UserOption=byte.Parse(Console.ReadLine());
            NoOfQuantity(UserOption);
            Console.WriteLine("Do You Want to Select another item  (Y/N)");
            Userchoice=char.Parse(Console.ReadLine());
            

        }while(Userchoice=='Y');
            InventoryRegestry();
        }
        static void NoOfQuantity(byte useroption)
        {
              
             switch(useroption)
             {
                 case 1:
                 {
                        
                   Console.WriteLine("Please Enter the Quantity of  Apples ");
                   userApples= int.Parse(Console.ReadLine());
                   apple-=userApples;  
                 }break;

                 case 2:
                 {
                    Console.WriteLine("Please Enter the Quantity of  Bananas ");
                    userBanana= int.Parse(Console.ReadLine());
                    banana-=userBanana; 
                 }break;
                 case 3:
                 {
                     Console.WriteLine("Please Enter the Quantity of  Oranges ");
                     userOrange= int.Parse(Console.ReadLine());
                     oranges-=userOrange; 
                 }break;
                 case 4:
                 {
                     Console.WriteLine("Please Enter the Quantity of  Grapes ");
                     userGrapes= int.Parse(Console.ReadLine());
                     grapes-=userGrapes; 
                 }break;
             }


        }

        static void  InventoryRegestry()
        {
          Console.WriteLine();
          Console.WriteLine("                  Please Check your Items                         ");
          Console.WriteLine("------------------------------------------------------------------");
          Console.WriteLine();
        Console.WriteLine($"You  Selected  Apples of quantity {userApples} Pieces ");
        Console.WriteLine($"You  Selected  Bananas of quantity {userBanana} Dozens ");
        Console.WriteLine($"You  Selected  Oranges of quantity {userOrange} Pieces ");
        Console.WriteLine($"You  Selected  Grapes of quantity {userGrapes} Kgs");
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("Generating Your bill.................................");
        UserBill();
               

        }

        static void UserBill()
        {
            int totalQuantity=userApples+userBanana+userGrapes+userOrange;
            double totalPrice=(2*userApples)+(0.5*userBanana)+(userOrange)+(1.5*userGrapes);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("                  Welcome to BigBazar                    ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("                     Your Bill                           ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"Item                Quantity              Price         ");
            Console.WriteLine($"-----               --------              ------        ");
            Console.WriteLine($"Apples                {userApples}                   ${2*userApples}     ");
            Console.WriteLine($"Bananas               {userBanana}                   ${0.5*userBanana}  ");
            Console.WriteLine($"Oranges               {userOrange}                   ${1*userOrange}    ");
            Console.WriteLine($"Grapes                {userGrapes}                   ${1.5*userGrapes}   ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($" Total                {totalQuantity}                 ${totalPrice}     ");
            Console.WriteLine("---------------------------------------------------------");

        }


    }
}

