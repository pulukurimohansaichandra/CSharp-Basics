using System;

namespace _12._7swithCases
{
    class Program
    {
        static void Main(string[] args)
        {
           string personOne="Ravana";
           string personTwo="Hanuman";
           string personThree="Rama";
            Ashokavanam(personOne);
            Console.WriteLine();
            Ashokavanam(personTwo);
            Console.WriteLine();
            Ashokavanam(personThree);
            Console.WriteLine();
        }

        static void Ashokavanam(string person)
        {
            switch(person)
            {
                case "Rama":
                {
                    Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();

               Console.WriteLine(" Rama entered the asokavanam");
                           Console.WriteLine();

               SitaToRama();
              
                }break;

                case "Ravana":
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Ravana entered the asokavanam");
                    Console.WriteLine();

                    SitaToRavana();
              
                }break;

                case "Hanuman":
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                 Console.WriteLine(" Hanuman entered the asokavanam");
                 Console.WriteLine();

                 SitaToHanuman();
                Console.WriteLine();
                Console.WriteLine();
                HanumanLankaTour();
                Console.WriteLine();
                SitaBlessingToHanuman();
                }break;
        }

        static void SitaToRavana()
        {
          Console.WriteLine();
            Console.WriteLine();

         Console.WriteLine(" Sita : Ninnu Chusthe naku ashiyam vesthundhi ravana ");
         Console.WriteLine(" Ravana : Natho ra devi ");
         Console.WriteLine(" Sita : Chi murkuda nan ranu ");

        }

        static void SitaToHanuman()
        {
          Console.WriteLine();
                            Console.WriteLine();

            Console.WriteLine(" Sita : Ninnu Chusthe naku santhosam ga vundhi  hanuma ");
            Console.WriteLine(" hanuman : amma meru naku talli tho samanam  ");
            Console.WriteLine(" hanuman :amma merru natho vasthe memalni ramiyya daggariki thiskuveltha amma  ");
            Console.WriteLine(" Sita :nanu ranu hanuma ramaiyaa vasthe ne nanu vastha ");

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
        static void SitaToRama()
        {
            Console.WriteLine();
                            Console.WriteLine();

             Console.WriteLine(" Sita  chana santhosisthundhi ");
             Console.WriteLine(" Rama kills the ravana......... ");
            Console.WriteLine(" Sita leaves lanka with rama  ");
             
             
        }

    }
}
}
