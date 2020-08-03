using System;
using System.Collections.Generic;

namespace Lab12_ClassUML
{
    class Program
    {
        public static List<string> menuOptions = new List<string>()
        {
            "1. Add Student", "2. Add Staff", "3. Display Person List", "4. Exit"
        };
        public static List<Person> listOfPersons = new List<Person>();
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Welcome to UML Challenge!-------------");
            Student student1 = new Student("Erica", "Detroit, MI", "C# .Net Bootcamp", 2020, 10000);
            Student student2 = new Student("Paul", "GrandRapids, MI", "Java Bootcamp", 2020, 12000);
            Student student3 = new Student("John", "Detroit, MI", "Frontend Bootcamp", 2020, 8000);

            Staff staff1 = new Staff("Bolden", "Lansing, MI", "International Academy", 8000);
            Staff staff2 = new Staff("Palaj", "Saginaw, MI", "Saginaw Public Schools", 6000);

            listOfPersons.Add(student1);
            listOfPersons.Add(student2);
            listOfPersons.Add(student3);
            listOfPersons.Add(staff1);
            listOfPersons.Add(staff1);

            DisplayPersonInfo();
            
            int searchOpt = 0;
            while (searchOpt != 4)
            {
                // Display menu options
                DisplayMenuOptions();

                // Get User input
                Console.WriteLine("What would you like to do?");

                string userOpt = Console.ReadLine();
                while (!ValidateUserOption(userOpt, out searchOpt))
                {
                    Console.WriteLine("Invalid option! Try Again!");
                    userOpt = Console.ReadLine();
                }
                switch (searchOpt)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        AddStaff();
                        break;
                    case 3:
                        Console.Clear();
                        DisplayPersonInfo();
                        break;
                    case 4:
                        break;
                }                              

                
            }
        }

        public static void DisplayInfo(Student student)
        {
            Console.WriteLine(student.ToString());
        }

        public static void DisplayInfo(Staff staff)
        {
            Console.WriteLine(staff.ToString());
        }

        public static void DisplayPersonInfo()
        {
            if(listOfPersons.Count == 0)
            {
                Console.WriteLine("Empty List");
            }
            else
            {
                foreach (Person p in listOfPersons)
                {
                    Console.WriteLine(p.ToString() + "\n");
                }
            }            
        }

        public static void DisplayMenuOptions()
        {
            Console.WriteLine("MAIN MENU");
            foreach (string menu in menuOptions)
            {
                Console.WriteLine(menu);
            }
        }
        public static bool ValidateUserOption(string userOption, out int number)
        {
            if (int.TryParse(userOption, out number))
            {
                if ((number > 0) && (number <= menuOptions.Count))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }

        public static void AddStudent()
        {
            Console.Clear();
            // Get student name            
            string name = GetUserInput("Please enter student's name");
            while (name == string.Empty)
            {
                Console.WriteLine("Please enter a valid name");
                name = Console.ReadLine();
            }

            // address
            string address = GetUserInput("Please enter student's address");
            while (address == string.Empty)
            {
                Console.WriteLine("Please enter a valid address");
                address = Console.ReadLine();
            }

            // program
            string program = GetUserInput("Please enter student's program");
            while (program == string.Empty)
            {
                Console.WriteLine("Please enter a valid program");
                program = Console.ReadLine();
            }

            // year
            string year = GetUserInput("Please enter student's year");
            int nYear;
            while (!int.TryParse(year, out nYear))
            {
                Console.WriteLine("Please enter a valid year");
                year = Console.ReadLine();
            }

            // fee
            string fee = GetUserInput("Please enter student's fee");
            double dFee;
            while (!double.TryParse(fee, out dFee))
            {
                Console.WriteLine("Please enter a valid fee");
                fee = Console.ReadLine();
            }

            Student newStudent = new Student (name, address, program, nYear, dFee);
            try
            {
                listOfPersons.Add(newStudent);
                Console.WriteLine("Added Student\n");
            }
            catch
            {
                Console.WriteLine("Error while adding student\n");
            }
        }

        public static void AddStaff()
        {
            Console.Clear();
            // Get staff name            
            string name = GetUserInput("Please enter staff's name");
            while (name == string.Empty)
            {
                Console.WriteLine("Please enter a valid name");
                name = Console.ReadLine();
            }

            // address
            string address = GetUserInput("Please enter staff's address");
            while (address == string.Empty)
            {
                Console.WriteLine("Please enter a valid address");
                address = Console.ReadLine();
            }

            // school
            string school = GetUserInput("Please enter staff's school");
            while (school == string.Empty)
            {
                Console.WriteLine("Please enter a valid school");
                school = Console.ReadLine();
            }                     

            // pay
            string pay = GetUserInput("Please enter staff's pay");
            double dPay;
            while (!double.TryParse(pay, out dPay))
            {
                Console.WriteLine("Please enter a valid pay");
                pay = Console.ReadLine();
            }

            Staff newStaff = new Staff(name, address, school, dPay);

            try
            {
                listOfPersons.Add(newStaff);
                Console.WriteLine("Added Staff\n");
            }
            catch
            {
                Console.WriteLine("Error while adding staff\n");
            }
        }
        public static string GetUserInput(string msg)
        {
            Console.WriteLine(msg);
            return (Console.ReadLine());
        }
    }
}
