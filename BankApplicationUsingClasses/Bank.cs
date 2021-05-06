using System;

namespace BankApplicationUsingClasses
{


    class IndianBank
    {

        int _initialBalance;
        int _userBalance;



        int _counter = 0;

        const int _minimumBalace = 1000;

        string[] UserTracking = new string[50];
        int[] UserAmountTracking = new int[50];

        public int InitialBalance
        {
            set
            {
                _initialBalance = value;

            }
        }

        public void Deposit(int UserAmount)
        {

            _userBalance = _userBalance + UserAmount;
            UserTracking[_counter] = "Deposit";
            UserAmountTracking[_counter] = UserAmount;
            _counter++;


        }

        public void WithDraw(int UserAmount)
        {
            if (_userBalance - UserAmount < _minimumBalace)
            {
                Console.WriteLine("There is no Required Balance ");

            }
            _userBalance = _userBalance - UserAmount;
            UserTracking[_counter] = "WithDraw";
            UserAmountTracking[_counter] = UserAmount;
            _counter++;

        }

        public void PrintingStatement()
        {
            int UserTrackingsize = UserTracking.Length;

            Console.WriteLine("     Transaction Type               Transaction Amount    ");
            Console.WriteLine("     ----------------               ----------------------");
            for (_counter = 0; _counter < UserTrackingsize; _counter++)
            {
                if (UserAmountTracking[_counter] != 0)
                {
                    Console.WriteLine($" {UserTracking[_counter]}                                   {UserAmountTracking[_counter]} ");
                }

            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine($"   Final Amount                                       {_userBalance}");
            Console.WriteLine("-----------------------------------------------------------------------------");


        }


    }
}