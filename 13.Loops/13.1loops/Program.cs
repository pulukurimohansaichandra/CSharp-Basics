using System;

namespace _13._1loops
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Jananam();
           OnEarth();
        }

        static void OnEarth()
        {
            int papam=0,punyam=0,lifespan;
            int newpapam=0,newpunyam=0;
            Console.WriteLine($"-------------------------------------------------------------------");
            Console.WriteLine("                        Enter the lifespan                          ");
            lifespan=int.Parse(Console.ReadLine());
            Console.WriteLine();
            while(lifespan!=0)
            {
                
               Console.WriteLine($"Please enter the option");
               Console.WriteLine($"Press 1 for papam");
               Console.WriteLine($"Press 2 for punyam");
               Console.WriteLine();
               byte Option= byte.Parse(Console.ReadLine());
               switch(Option)
               {
                   case 1:
                   {
                       Console.WriteLine("Enter Papam");
                       papam =int.Parse(Console.ReadLine());
                      newpapam+=papam;
                   }break;
                   case 2:
                   {
                       Console.WriteLine("Enter Punyam");
                       punyam =int.Parse(Console.ReadLine());
                       newpunyam+=punyam;
                   }break;
               }
               lifespan--;
            }
            Maranam();
            if(newpapam>newpunyam)
            {
                Console.WriteLine($"-------------------------------------------------------------------");
                Console.WriteLine($"Papam({newpapam}) is  greater than punyam ({newpunyam})");
                Console.WriteLine($"-------------------------------------------------------------------");
                Narakam(newpapam);
                Console.WriteLine();
                Swargam(newpunyam);
            }
            else if(newpapam<newpunyam)
            {
                Console.WriteLine($"-------------------------------------------------------------------");
                Console.WriteLine($"Punyam({newpunyam}) is greater than papam ({newpapam})");
                Console.WriteLine($"-------------------------------------------------------------------");
                Swargam(newpunyam);
                Console.WriteLine();
                Narakam(newpapam);
            }
            else
            { 
                Console.WriteLine($" Papam({newpapam}) and Punyama({newpunyam}) are Equal");
                 Sayudam(newpapam,newpunyam);

            }


        }

        static void Narakam(int papam)
        {
            Console.WriteLine();
            Console.WriteLine($"Going to narakam");
            Console.WriteLine($"----------------");
            Console.WriteLine();
            Console.WriteLine($" Experiance the Papam for({papam}) years");
             Console.WriteLine();
            
        }
        
        static void Swargam(int punyam)
        {
             Console.WriteLine();
             Console.WriteLine($"Going to swargam");
            Console.WriteLine($"-----------------");
            Console.WriteLine();
             Console.WriteLine($" Enjoys the Punyam for ({punyam}) years");
             Console.WriteLine();
             
        }

        static void Sayudam(int papam ,int punyam)
         {
            Console.WriteLine();
           Console.WriteLine($"Since the papam({papam}) and punyam({punyam}) account are equal ");
            Console.WriteLine(); 
           Console.WriteLine($"Absorbed into the eternal god "); 
            Console.WriteLine(); 
         }

         static void Jananam()
         {
            
            Console.WriteLine();
            Console.WriteLine("*******************************Jananam**********************************                       "); 
            Console.WriteLine();
         }

         static void Maranam()
         {
                Console.WriteLine();
                Console.WriteLine("****************************Maranam*********************************                        " ); 
                Console.WriteLine(); 
         }

    }
}
