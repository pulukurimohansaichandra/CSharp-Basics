using System;

namespace CollectionfromUser
{

    class Collection
    {

        int counter = 0;

        int _userSize = 1;

        int[] CollectionArray;

        public int UserSize
        {
            get
            {
                return _userSize;
            }

            set
            {
                _userSize = value;
            }
        }

        public void SetCollectionArray()
        {
            CollectionArray = new int[_userSize];
        }

        public void Add(int inputNumber)
        {
            if (counter < _userSize)
            {
                CollectionArray[counter] = inputNumber;
                counter++;
            }
            else
            {

                Console.WriteLine("Not Enough Size in the array");

            }


        }

        public void Remove(int inputNumber)
        {


            
            for (counter = 0; counter < _userSize; counter++)
            {
                if (CollectionArray[counter] == inputNumber)
                {
                    CollectionArray[counter] = -1;
                }
            }
        }

        public void PrintingCollection()
        {

            Console.WriteLine("After Removel of the Elements");
            Console.WriteLine("------------------------------");
            foreach (var value in CollectionArray)
            {
                if (value != -1)
                {
                    Console.WriteLine(value);
                }

            }
        }




    }
}