using System;
using System.Globalization;

namespace ForTestPurposes
{
    class Child
    {
        private int age;
        private string name;

        // Default constructor:
        public Child()
        {
            name = "N/A";
        }

        // Constructor:
        public Child(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void CreateChild()
        {
            Console.WriteLine("Please enter the child's name: ");
            var childName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine()); // need to check if correct input
            Console.WriteLine("Please enter the child's age"); // as line 41
            var childAge = int.Parse(Console.ReadLine());
            Child child = new Child(childName, childAge);
            child.PrintChild(); // change to class
        }

        // Printing method:
        public void PrintChild()
        {
            Console.WriteLine("{0} is {1} years old.", name, age);
        }
    }
}

