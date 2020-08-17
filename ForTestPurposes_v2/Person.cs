using System;
using System.Globalization;

namespace ForTestPurposes
{
    class Person    
    {
        // need new name, surname, salary & year
        private string name;
        private string surname;
        private int salary;
        private int year;

            // Default constructor:
        public Person()
        {
            name = "N/A";
        }

        // Constructor:
        public Person(string name, string surname, int salary, int year)
        {
            this.name = name; // passed in / injected 
            this.surname = surname;
            this.salary = salary;
            this.year = year;
        }
        public void CreateMgcYrCal()
        {
            Console.WriteLine("Please input your name: ");
            var personName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            Console.WriteLine("Please input your surname:");
            var personSurname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            Console.WriteLine("Please enter your annual salary: ");
            var personSalary = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter your work start year: ");
            //var year = int.Parse(Console.ReadLine()); does not work
            var personYear = Convert.ToInt32(Console.ReadLine()); // works
            Person person = new Person(personName, personSurname, personSalary, personYear);
            person.PrintPerson();
            person.PrintSalary();
            person.PrintMgcYrCal();
        }
        // Printing method:
        public void PrintPerson()
        {
            Console.WriteLine("{0} {1}", name, surname);
        }
        public void PrintMgcYrCal()
        {
            Console.WriteLine("Magic Year: {0}",magicYear(year));
        }
        public void PrintSalary()
        {
            mthlySalary(salary);
        }
        static int magicYear(int num)
        {
            var mgcYr = num + 65;
            //Console.Write("Magic Year: ");
            //Console.WriteLine(mgcYr);
            return mgcYr;
        }
        static void mthlySalary(int num)
        {
            var mthSalary = num / 12m; // passing number is int, is changed to decimal
            Console.WriteLine("Monthly Salary: ${0:F0}",mthSalary); // diff: Math.round == create number w/o decimal; {0:F0} == display original value w/o decimal
        } 
    }
}
