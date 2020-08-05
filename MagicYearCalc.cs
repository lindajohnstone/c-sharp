using System;

namespace ForTestPurposes
{
    class MagicYearCalc
    {
        private int salary;
        private string name;
        private int year;
        private string surname;

        // Default constructor:
        public MagicYearCalc()
        {
            name = "N/A";
        }

        // Constructor:
        public MagicYearCalc(string name, string surname, int salary, int year)
        {
            this.name = name;
            this.surname = surname;
            this.salary = salary;
            this.year = year;
        }
        
        // Printing method:
        public void PrintCalc()
        {
            Console.WriteLine("{0} is {1} years old.", name, age);
        }
    }
}

