using System;

namespace _8.JobApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           JobApplication();
        }

        static void JobApplication()
        {
            string firstName;
            string lastName;
            byte dd;
            byte mm;
            int  yyyy;
            string address;
            int postalCode ;
            double homePhone;
            double mobilePhone;
            string emailId;
            Console.WriteLine("Enter the date in dd/mm/yyyy format  ");
            int d=int.Parse(Console.ReadLine());
            Console.WriteLine();
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine();
            int y=int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("********************************************************");
            Console.WriteLine("               Enter Personal Details..                 ");
            Console.WriteLine();
            Console.WriteLine("Enter First name");
           firstName=Console.ReadLine();
             Console.WriteLine();
           Console.WriteLine("Enter Last name");
           lastName=Console.ReadLine();
             Console.WriteLine();
            Console.WriteLine("Enter Date Of Birth Details ");
            Console.WriteLine();
           Console.WriteLine("Enter day");
           dd=byte.Parse(Console.ReadLine());
             Console.WriteLine();
           Console.WriteLine("Enter Month");
           mm=byte.Parse(Console.ReadLine());
             Console.WriteLine();
           Console.WriteLine("Enter Year");
           yyyy=int.Parse(Console.ReadLine());
             Console.WriteLine();
           Console.WriteLine("Enter Address");
           address=Console.ReadLine();
             Console.WriteLine();
           Console.WriteLine("Enter Postal Code ");
           postalCode=int.Parse(Console.ReadLine());
             Console.WriteLine();
           Console.WriteLine("Enter Home Phone Number ");
           homePhone=double.Parse(Console.ReadLine());
             Console.WriteLine();
           Console.WriteLine("Enter Mobile Phone Number");
           mobilePhone=double.Parse(Console.ReadLine());
             Console.WriteLine();
           Console.WriteLine("Enter Email Id");
           emailId=Console.ReadLine();
           Console.WriteLine();
           Console.WriteLine("********************************************************");
           Console.WriteLine("              Enter Education Details                   ");
           Console.WriteLine();
           Console.WriteLine("Enter High School Details.");
             Console.WriteLine();
           Console.WriteLine("Enter Name of the school");
           string schoolName=Console.ReadLine();
             Console.WriteLine();
           Console.WriteLine("Enter the City ");
           string schoolCity=Console.ReadLine();
             Console.WriteLine();
           Console.WriteLine("Enter the university details");
             Console.WriteLine();
           Console.WriteLine("Enter the Name ");
           string universityName=Console.ReadLine();
             Console.WriteLine();
           Console.WriteLine("Enter the City");
           string universityCity=Console.ReadLine();
             Console.WriteLine();
            Console.WriteLine("********************************************************");
           Console.WriteLine("                    Enter Skills                         ");
             Console.WriteLine();
           Console.WriteLine("Enter 1st Skill ");
           string fSkill=Console.ReadLine();
             Console.WriteLine();
           Console.WriteLine("Enter Profiency in the 1st Skill   ");
             Console.WriteLine();
           Console.WriteLine(" Please  Specify  low    Medium   High");
             
           string fproficency=Console.ReadLine();
             Console.WriteLine();
              Console.WriteLine("Enter 2nd  Skill ");
           string sSkill=Console.ReadLine();
             Console.WriteLine();
           Console.WriteLine("Enter Profiency in the 2nd Skill   ");
             Console.WriteLine();
           Console.WriteLine(" Please  Specify  low    Medium   High");
           
           string sproficency=Console.ReadLine();
             Console.WriteLine();
            Console.WriteLine("Enter 3rd Skill ");
           string tSkill=Console.ReadLine();
             Console.WriteLine();
           Console.WriteLine("Enter Profiency in the 3rd  Skill   ");
             
           Console.WriteLine(" Please  Specify  low    Medium   High");
             
           string tproficency=Console.ReadLine();
             Console.WriteLine();
           Console.WriteLine("Do you speak foreign language Y or N");
           char L=char.Parse(Console.ReadLine());
           Console.WriteLine();
             Console.WriteLine("if yes ,Which ");
             string foreginLanguage=Console.ReadLine();
             Console.WriteLine();
           Console.WriteLine("Do you have a car Y or N ");
           char C=char.Parse(Console.ReadLine());
             Console.WriteLine();
           Console.WriteLine("Can you work on holiday Y or N ");
           char h=char.Parse(Console.ReadLine());
             Console.WriteLine();



          Console.WriteLine("*************************************************************************************************");
          Console.WriteLine("                             ----------------------------------                                  ");
          Console.WriteLine("                            |           Job Application         |                                ");
          Console.WriteLine("                             ----------------------------------                                  ");
          Console.WriteLine();
          Console.WriteLine("           --------------------------------------------------------------------------------      ");
          Console.WriteLine("          |   Section 1:   Personal Information                                            |     ");
          Console.WriteLine("           --------------------------------------------------------------------------------      ");
          Console.WriteLine();
          Console.WriteLine("            Name                                                                Date Of Birth    ");
          Console.WriteLine("           ------                                                             -----------------  ");
          Console.WriteLine("           FirstName: "+firstName+"        Last Name:  "+lastName+"                "+dd+"/"+mm+"/"+yyyy+" ");
          Console.WriteLine();
          Console.WriteLine("            Address                                                                                  ");
          Console.WriteLine("          -----------                                                                                 ");
          Console.WriteLine("           Address:  "+address+"                                                                                   ");
          Console.WriteLine();
          Console.WriteLine("           Postal Code : "+postalCode+"            Home Phone:     "+homePhone+"    Mobile Phone:  "+mobilePhone+"                      ");
          Console.WriteLine();
          Console.WriteLine("           Email address: "+emailId+"                                                                          ");
          Console.WriteLine();
          Console.WriteLine("          ------------------------------------------------------------------------------------           ");
          Console.WriteLine("         | Section 2 :   Education                                                            |         ");
          Console.WriteLine("          ------------------------------------------------------------------------------------          ");
          Console.WriteLine();
          Console.WriteLine("           High School                                                                                  ");
          Console.WriteLine("          -------------                                                                                 ");
          Console.WriteLine("           Name:  "+schoolName+"                  City :  "+schoolCity+"                                            ");
          Console.WriteLine();
          Console.WriteLine("          University                                                                                    ");
          Console.WriteLine("         ------------                                                                                   ");
          Console.WriteLine("           Name:  "+universityName+"              City :  "+universityCity+"                             ");
          Console.WriteLine();
          Console.WriteLine("         --------------------------------------------------------------------------------               ");
          Console.WriteLine("        |  Section 3:   Skill Levels                                                     |              ");
          Console.WriteLine("         --------------------------------------------------------------------------------               ");
          Console.WriteLine();
          Console.WriteLine("         --------------------------------------------------------------------------------             ");
          Console.WriteLine("        |         Skills                           |      Proficiancy                    |   ");
          Console.WriteLine("         --------------------------------------------------------------------------------               ");
          Console.WriteLine("        | "+fSkill+"                               |  "+ fproficency+"    "+"            |                ");
          Console.WriteLine("         -------------------------------------------------------------------------------                ");
          Console.WriteLine("        | "+sSkill+"                               |  "+sproficency+"                    |              ");
          Console.WriteLine("         -------------------------------------------------------------------------------                ");
          Console.WriteLine("        | "+tSkill+"                               |  "+tproficency+"                    |              ");
          Console.WriteLine("         -------------------------------------------------------------------------------                ");
          Console.WriteLine("               Do you speak any foreign language(s)        "+"["+L+"]"+"           if yes,Which?  "+foreginLanguage                                 );
          Console.WriteLine("               Do you have a car                           "+"["+C+"]"                                    );
          Console.WriteLine("               Can you work on holidays                    "+"["+h+"]"                                    );
          Console.WriteLine();
          Console.WriteLine("        Name :"+firstName+" "+lastName+"                      date: "+d+"/"+m+"/"+y                      );
          Console.WriteLine("*********************************************************************************************************");
        }

       
           




        
    }
}
