using System;

namespace EmployessClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student data access Through three classes");
            Console.WriteLine("-----------------------------------------");
            Students admin = new Students();

            admin.GetUserDetails();
            admin.PrintingEmployeeDetails();
        }
    }

    class Student
    {
        static string   _studentID;
        static string  _firstName;

        static string   _lastName;
        static string  _gender;

        int _marks;

        public string StudentID
        {

            get
            {
                return _studentID;

            }

            set
            {

                _studentID = value;

            }

        }

        public string FirstName
        {

            get
            {
                return _firstName;

            }

            set
            {

                _firstName = value;

            }

        }

        public string LastName
        {

            get
            {
                return _lastName;
            }

            set
            {

                _lastName = value;

            }

        }

        public string Gender
        {
            get
            {
                return _gender;

            }

            set
            {
                _gender = value;

            }

        }

        public int Marks
        {
            get
            {
                return _marks;
            }
            set
            {

                _marks = value;

            }
        }
    }

    class Students

    {

        private int counter = 0;


        private int StudentsSize = 0;
        Student[] students;
        public void GetUserDetails()
        {

            Console.WriteLine("Enter the Number Of Students");
            StudentsSize = int.Parse(Console.ReadLine());
            students = new Student[StudentsSize];


            for (counter = 0; counter < StudentsSize; counter++)
            {
                students[counter] = new Student();
                /////////////////////////////////////////////////////////////////////////
                students[counter].StudentID = " " + (counter + 1);
                /////////////////////////////////////////////////////////////////////////
                Console.WriteLine($"Enter the first Name of the Student {counter + 1} ");
                string firstname = Console.ReadLine();
                students[counter].FirstName = firstname;
                ////////////////////////////////////////////////////////////////////////////
                Console.WriteLine($"Enter the Last  Name of the Student {counter + 1} ");
                string lastname = Console.ReadLine();
                students[counter].LastName = lastname;
                //////////////////////////////////////////////////////////////////////////////
                Console.WriteLine($"Enter the Gender   of the Student {counter + 1} ");
                string gender = Console.ReadLine();
                students[counter].Gender = gender;
                /////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine($"Enter the Marks of the Student {counter + 1} ");
                int marks = int.Parse(Console.ReadLine());
                students[counter].Marks = marks;
                //////////////////////////////////////////////////////////////////////////////////

            }
        }

        public void PrintingEmployeeDetails()
        {

            Console.WriteLine(" Printing student details");

            for (counter = 0; counter < StudentsSize; counter++)
            {
                Console.WriteLine($"Students {counter + 1} Details ");
                Console.WriteLine("------------------------------");
                Console.WriteLine($" Student ID {students[counter].StudentID}");
                Console.WriteLine($"Student First Name={students[counter].FirstName}");
                Console.WriteLine($"Student Last Name={students[counter].LastName}");
                Console.WriteLine($"Student Marks={students[counter].Marks}");
                Console.WriteLine("-----------------------------------------------------");

            }

            Console.WriteLine("Detail of Students whose marks are greater than 80");
            for (counter = 0; counter < StudentsSize; counter++)
            {

                if (students[counter].Marks > 80)
                {

                    Console.WriteLine($"StudentID={students[counter].StudentID}");
                    Console.WriteLine($" Student {counter + 1} Full Name :- {students[counter].FirstName + students[counter].LastName}");
                    Console.WriteLine($" Student Gender = {students[counter].Gender}");
                    Console.WriteLine($" Marks of the student = {students[counter].Marks}");

                }
            }

        }


    }
}
