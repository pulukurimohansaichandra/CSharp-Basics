using System;

namespace _18.ClassesUsingEmployeeDetails
{
    class Program
    {
        static int counter = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number of Employess");
            int empSize = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[empSize];

            for (counter = 0; counter < empSize; counter++)
            {
                employees[counter] = new Employee();
                employees[counter].EmployeeId = " " + (counter + 1);
                /////////////////////////////////////////////////////
                Console.WriteLine($"Enter employee{counter + 1} First Name ");
                string firstname = Console.ReadLine();
                employees[counter].FirstName = firstname;
                //////////////////////////////////////////////////////
                Console.WriteLine($"Enter employee{counter + 1} Last  Name ");
                string lastname = Console.ReadLine();
                employees[counter].LastName = lastname;
                //////////////////////////////////////////////////////////////
                Console.WriteLine($"Enter employee{counter + 1} Role");
                string role = Console.ReadLine();
                employees[counter].Role = role;
                /////////////////////////////////////////////////////////
                Console.WriteLine($"Enter employee{counter + 1} Salary ");
                int salary = int.Parse(Console.ReadLine());
                employees[counter].Salary = salary;
                //////////////////////////////////////////////////////////
            }

            Console.WriteLine("The Details Of Employess");

            /*for (counter = 0; counter < empSize; counter++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee{counter + 1}");
                Console.WriteLine($"---------------------------------------------------");
                Console.WriteLine($"EmployeeID  {employees[counter].EmployeeId}");
                Console.WriteLine($"Full Name{employees[counter].FirstName + employees[counter].LastName}");
                Console.WriteLine($"Role {employees[counter].Role}");
                Console.WriteLine($"Salary {employees[counter].Salary}");
                Console.WriteLine($"---------------------------------------------------");
            }*/


            for (counter = 0; counter < empSize; counter++)
            {
                if (employees[counter].Salary > 20000)
                {
                    Console.WriteLine($"---------------------------------------------------");
                    Console.WriteLine($"EmployeeID  {employees[counter].EmployeeId}");
                    Console.WriteLine($"Full Name{employees[counter].FirstName + employees[counter].LastName}");
                    Console.WriteLine($"Role {employees[counter].Role}");
                    Console.WriteLine($"Salary {employees[counter].Salary}");
                    Console.WriteLine($"---------------------------------------------------");
                }
            }
        }

        
    }


    class Employee
    {
        string _employeeId;
        string _firstName;
        string _lastname;

        string _role;
        int _salary;

        public string EmployeeId
        {
            get
            {
                return _employeeId;
            }
            set
            {
              _employeeId=value;
            }
        }
        public string FirstName
        {
            get
            { return _firstName; }
            set
            {

                if (value !=" ")
                {
                    _firstName = value;
                }



            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {

                if (value != " ")
                {
                    _lastname = value;
                }
            }
        }
        public string Role
        {
            get
            {
                return _role;
            }
            set
            {

                if (value != " ")
                {
                    _role = value;
                }
            }
        }

        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {

                if (value != 0)
                {
                    _salary = value;
                }
            }
        }

    }
}
