﻿using System;

namespace _17.Classes
{
    class Program
    {

        static void Main(string[] Args)
        {

            char userSelect = ' ';
            ElectronicDevicesShop user1 = new ElectronicDevicesShop();
            Console.WriteLine("Welcome to Electronic Shop ");
            Console.WriteLine("---------------------------");


            do
            {

                user1.GetShopItems();
                Console.WriteLine("Please Enter the Choice ");
                byte userChoice = byte.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("Please Enter the Number Resistors");
                            int userResitors = int.Parse(Console.ReadLine());
                            user1.Resitors = userResitors;
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Please Enter the Number Transistors");
                            int userTransistors = int.Parse(Console.ReadLine());
                            user1.Transistors = userTransistors;
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Please Enter the Number Diodes");
                            int userDiodes = int.Parse(Console.ReadLine());
                            user1.Diodes = userDiodes;
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Please Enter the Number BreadBoard");
                            int userBreadBoard = int.Parse(Console.ReadLine());
                            user1.BreadBoard = userBreadBoard;
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Please Enter the Number DcMotors");
                            int userDcMotors = int.Parse(Console.ReadLine());
                            user1.DcMotors = userDcMotors;
                        }
                        break;
                }


                Console.WriteLine("Do You Want to Order Again (y/n)");
                userSelect = char.Parse(Console.ReadLine());
            } while (userSelect == 'y');

            user1.GetUserBill();


        }

    }


    class ElectronicDevicesShop
    {
        private static int _resistors = 100;
        private static int _transistors = 200;
        private static int _diodes = 300;
        private static int _breadBoard = 30;
        private static int _dcMotors = 50;

        private static int _userResistor;
        private static int _userTransistor;
        private static int _userDiodes;
        private static int _userBreadBoard;
        private static int _userDcmotors;
        public void GetShopItems()
        {

            Console.WriteLine("1.Resitors");
            Console.WriteLine("2.Transistors");
            Console.WriteLine("3.Diodes");
            Console.WriteLine("4.BreadBoard");
            Console.WriteLine("5.DcMotors");

        }

        public int Resitors
        {
            get
            {
                return Resitors;
            }

            set
            {

                if (value > _resistors)
                {
                    Console.WriteLine("Not Enough  Stock ");
                }

                else
                {

                    _userResistor = value;
                    _resistors = _resistors - value;

                }

            }
        }

        public int Transistors
        {
            get
            {
                return Transistors;
            }

            set
            {

                if (value > _transistors)
                {
                    Console.WriteLine("Not Enough  Stock ");
                }

                else
                {

                    _userTransistor = value;
                    _transistors = _transistors - value;

                }

            }
        }

        public int Diodes
        {
            get
            {
                return Diodes;
            }

            set
            {

                if (value > _diodes)
                {
                    Console.WriteLine("Not Enough  Stock ");
                }

                else
                {

                    _userDiodes = value;
                    _diodes = _diodes - value;

                }

            }
        }

        public int BreadBoard
        {
            get
            {
                return BreadBoard;
            }

            set
            {

                if (value > _breadBoard)
                {
                    Console.WriteLine("Not Enough  Stock ");
                }

                else
                {

                    _userBreadBoard = value;
                    _breadBoard = _breadBoard - value;
                    _userResistor = _userResistor + 1;
                    _userTransistor = _userTransistor + 1;
                    _userDiodes = _userDiodes + 1;

                }

            }
        }

        public int DcMotors
        {
            get
            {
                return DcMotors;
            }

            set
            {

                if (value > _dcMotors)
                {
                    Console.WriteLine("Not Enough  Stock ");
                }

                else
                {

                    _userDcmotors = value;
                    _dcMotors = _dcMotors - value;

                }

            }
        }

        public void GetUserBill()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("             User Bill               ");
            Console.WriteLine($" Resitors           {_userResistor}      ");
            Console.WriteLine($" Transistors        {_userTransistor}   ");
            Console.WriteLine($" Diodes             {_userDiodes}    ");
            Console.WriteLine($" BreadBoard         {_userBreadBoard}    ");
            Console.WriteLine($" DcMotors           {_userDcmotors}      ");
            Console.WriteLine($"-------------------------------------");
            Console.WriteLine($"Total                {_userResistor + _userTransistor + _userDiodes + _userDcmotors}");
            Console.WriteLine("-------------------------------------");






        }




    }

}










