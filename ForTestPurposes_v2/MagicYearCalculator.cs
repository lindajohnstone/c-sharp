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

            // Printing method:
            public void PrintPerson()
            {
                Console.WriteLine("{0} {1}", name, surname);
                mthlySalary(salary);
                Console.WriteLine("Magic Year: {0}",magicYear(year));
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
            Console.Write("Monthly Salary: $");
            Console.WriteLine("{0:F0}",mthSalary); // diff: Math.round == create number w/o decimal; {0:F0} == display original value w/o decimal
        } 
    }
}
