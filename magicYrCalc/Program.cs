using System;
using System.Globalization;

namespace magicYrCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputDetails(); 
             // Create objects by using the new operator:

            Console.WriteLine("Please input your name: ");
            var PersonName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            //name = (name);
            //Console.WriteLine( "\"{0}\" to titlecase: {1}", myString, myTI.ToTitleCase( myString ) )
            Console.WriteLine("Please input your surname:");
            var PersonSurname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            //var fullName = name + ' ' + surname;
            Console.WriteLine("Please enter your annual salary: ");
            var PersonSalary = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your work start year: ");
            //var year = int.Parse(Console.ReadLine()); does not work
            var PersonYear = Convert.ToInt32(Console.ReadLine()); // works
            Person person = new Person(PersonName, PersonSurname, PersonSalary, PersonYear);

            // Display results:
            //Console.Write("Child #1: ");
            person.PrintPerson();
        }
    }
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
                this.name = name;
                this.surname = surname;
                this.salary = salary;
                this.year = year;
            }

            // Printing method:
            public void PrintPerson()
            {
                Console.WriteLine("{0}, {1}", name, surname);
                mthlySalary(salary);
                magicYear(year);
            }
        static void magicYear(int num)
        {
            var mgcYr = num + 65;
            Console.Write("Magic Year: ");
            Console.WriteLine(mgcYr);
        }
        static void mthlySalary(int num)
        {
            var mthSalary = num / 12m; // passing number is int, is changed to decimal
            Console.Write("Monthly Salary: $");
            Console.WriteLine("{0:F0}",mthSalary); // diff bw Math.round == create number w/o decimal; {0:F0} == display original value w/o decimal
        } 
        /* static void inputDetails()
        {
            Console.WriteLine("Please input your name: ");
            var name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            //name = (name);
            //Console.WriteLine( "\"{0}\" to titlecase: {1}", myString, myTI.ToTitleCase( myString ) )
            Console.WriteLine("Please input your surname:");
            var surname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            var fullName = name + ' ' + surname;
            Console.WriteLine("Please enter your annual salary: ");
            var salary = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your work start year: ");
            //var year = int.Parse(Console.ReadLine()); does not work
            var year = Convert.ToInt32(Console.ReadLine()); // works
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(name + ' ' + surname);
            mthlySalary(salary);
            magicYear(year);
            Console.WriteLine();
        } */
    }
}

