using System;

namespace _11.Sundarakanda
{
    class Program
    {
        static void Main(string[] args)
        {

           string personOne="Ravana";
           string personTwo="Hanuman";
           string personThree="Rama";
            Asokavanam(personOne);
            Console.WriteLine();
            Asokavanam(personTwo);
            Console.WriteLine();
            Asokavanam(personThree);
            Console.WriteLine();

            
        }

        static void Asokavanam( string person)
        {
            if(person=="Ravana")
            {
                            Console.WriteLine();
                                          Console.WriteLine();
                            Console.WriteLine();

                Console.WriteLine("Ravana entered the asokavanam");
                            Console.WriteLine();

                bool result = SitaToRavana();
                if(result==false)
                {
                                                Console.WriteLine();

                Console.WriteLine("Does Sita amma goes  with ravana ? ---> "+result);
                Console.WriteLine();
                   Console.WriteLine("*****************************************************************"); 
    
                }
            }

            else if(person=="Hanuman")
            {
                         
                   Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();

                 Console.WriteLine(" Hanuman entered the asokavanam");
                             Console.WriteLine();

                bool result = SitaToHanuman();
                Console.WriteLine();
                Console.WriteLine();
                HanumanLankaTour();
                if(result==false)
                {
                                                Console.WriteLine();

                  Console.WriteLine("Does Sita amma goes with hanuma?---> "+result); 
                  Console.WriteLine();
                   Console.WriteLine("*****************************************************************");

                }

            }
            else if (person=="Rama")
            {
                         Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();

               Console.WriteLine(" Rama entered the asokavanam");
                           Console.WriteLine();

               bool result = SitaToRama();
               if(result==true)
               {
                                               Console.WriteLine();
                            Console.WriteLine();

                  Console.WriteLine("Does Sita amma goes with rama?---> "+result); 
                Console.WriteLine();
                   Console.WriteLine("*****************************************************************");


               }
               
               
            }
            
        }

        static bool  SitaToRavana()
        {
            Console.WriteLine();
                            Console.WriteLine();

         Console.WriteLine(" Sita : Ninnu Chusthe naku ashiyam vesthundhi ravana ");
         Console.WriteLine(" Ravana : Natho ra devi ");
         Console.WriteLine(" Sita : Chi murkuda nan ranu ");
         return false;
        }

        static bool SitaToHanuman()
        {
                                        Console.WriteLine();
                            Console.WriteLine();

            Console.WriteLine(" Sita : Ninnu Chusthe naku santhosam ga vundhi  hanuma ");
            Console.WriteLine(" hanuman : amma meru naku talli tho samanam  ");
            Console.WriteLine(" hanuman :amma merru natho vasthe memalni ramiyya daggariki thiskuveltha amma  ");
            Console.WriteLine(" Sita :nanu ranu hanuma ramaiyaa vasthe ne nanu vastha ");
            return false;
        }

        static void HanumanLankaTour()
        {
                                        Console.WriteLine();
                            Console.WriteLine();

            Console.WriteLine(" hanuman : Orri ravana twara lo ni lanka nasanam ipothundhi chudu ma ramiyya vasthunaru ");
            Console.WriteLine(" ravan  : ori nuvvu naku chepantha vadiva battulu a toka nippu intiandhi  ");
            Console.WriteLine(" hanuman fires up the lanka ............ ");

        }
           
        static void  SitaBlessingToHanuman()
        {
                                        Console.WriteLine();
                            Console.WriteLine();

            Console.WriteLine(" hanuma : amma ika naku selva ivvandi  ");
            Console.WriteLine(" Sita : ksyamam ga vellu hanuma ramiyya ni adiga anni chepu ");
            
        }

        static bool SitaToRama()
        {
                                        Console.WriteLine();
                            Console.WriteLine();

             Console.WriteLine(" Sita  chana santhosisthundhi ");
             Console.WriteLine(" Rama kills the ravana......... ");
            Console.WriteLine(" Sita leaves lanka with rama  ");
             
             return true;
        }

    }
}
