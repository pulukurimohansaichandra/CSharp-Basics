using System;

namespace CollectionfromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection user=new Collection();

            Console.WriteLine("Enter the Size of the collection");
            user.UserSize=int.Parse(Console.ReadLine());
            user.SetCollectionArray();
            Console.WriteLine($" You Can Add {user.UserSize} Elements in the collection ");
            char UserChoice=' ';
            do
            {
                Console.WriteLine("Press 1 to Add the element");
                Console.WriteLine("Press 2 to Remove the element");
                Console.WriteLine("Enter the Choice of the array");
                byte userselection=byte.Parse(Console.ReadLine());
                switch(userselection)
                {
                    case 1:
                    {
                        int userinput=int.Parse(Console.ReadLine());
                        user.Add(userinput);

                    }break;
                    case 2:
                    {
                        int userinput=int.Parse(Console.ReadLine());
                        user.Remove(userinput);
                    }break;
                }
                Console.WriteLine("Do you want add or remove the elements more (y/n)");
                 UserChoice=char.Parse(Console.ReadLine());


            }while(UserChoice=='y');

            user.PrintingCollection();
            
            
            
        }
    }
}
