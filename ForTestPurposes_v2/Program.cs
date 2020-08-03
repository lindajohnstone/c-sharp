using System;
using System.Globalization;

namespace ForTestPurposes
{
    class SwitchNum
    {
        private int num;
        
        // Constructor:
        public SwitchNum(int num)
            {
                this.num = num;
            }

            // Printing method:
            public void switchNum(int num)
            {
                switch(num)
                    {
                        case 1:
                            //MagicYearCalculator();
                            break;
                        case 2:
                            //FizzBuzz();
                            break;
                        case 3:
                            //PrintChild();
                            break;
                        default:
                            Console.WriteLine("Please enter a number between 1 - 3.");
                            break;
                    }   
            }
    }
    class Program
    {
        static void UserChoice() 
            {
                var messageText = "Please select from the following options: 1 - Magic Year Calculator, 2 - FizzBuzz, 3 - PrintChild. Press any other key to exit";
                Console.WriteLine(messageText);
                
                var switchNum = Console.ReadLine();
                //var newNum = 0;
                //while (int.TryParse(switchNum, out var newNum))
                if (!int.TryParse(switchNum, out var newNum)) //if not a whole number input give an error ** code works, changing code to use while
                {
                    Console.WriteLine("Please enter a number");
                }
                else 
                {
                    switch(newNum)
                    {
                        case 1:
                            MagicYearCalculator(); // change to class
                            break;
                        case 2:
                            FizzBuzz(); // change to class
                            break;
                        case 3:
                            PrintChild(); // change to class
                            break;
                        default:
                            Console.WriteLine("Please enter a number between 1 - 3.");
                            break;
                        }
                    }
            }
        static void Main(string[] args)
        {
            
            UserChoice();// can be instantiated within class
            
            UserChoiceMoreThanOnce();
            }
        static void UserChoiceMoreThanOnce()
        {
            Console.WriteLine("Are you sure you want to exit? Type 'yes' to exit or 'no' to try again.");
            var choice = Console.ReadLine();
            bool boolChoice;// use of while loop continually loops b/c choice is always == no
            if (choice == "yes")
            {
                boolChoice = true;
            }
            else
            {
                UserChoice();
            } 
            Console.WriteLine("Are you sure you want to exit? Please type 'yes' to exit and 'no' to continue.");
        }

        static void PrintChild()
        {
            //Child child1 = new Child("Craig", 11);
            //Child child2 = new Child("Sally", 10);

            // Create an object using the default constructor:
            Child child3 = new Child();

            // Create object using User input
            Console.WriteLine("Please enter the child's name: ");
            var childName = Console.ReadLine(); // need to check if correct input
            Console.WriteLine("Please enter the child's age"); // as line 41
            var childAge = int.Parse(Console.ReadLine());
            Child child4 = new Child(childName, childAge);

            // Display results:
            //Console.Write("Child #1: ");
            //child1.PrintChild();
            //Console.Write("Child #2: ");
            //child2.PrintChild();
            //Console.Write("Child #3: ");
            //child3.PrintChild();
            Console.Write("Child #4: ");
            child4.PrintChild();
        }
/* Output:
    Child #1: Craig, 11 years old.
    Child #2: Sally, 10 years old.
    Child #3: N/A, 0 years old.
*/
        static void MagicYearCalculator()
        {
            Console.WriteLine("Please input your name: ");
            var PersonName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            Console.WriteLine("Please input your surname:");
            var PersonSurname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            Console.WriteLine("Please enter your annual salary: ");
            var PersonSalary = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your work start year: ");
            //var year = int.Parse(Console.ReadLine()); does not work
            var PersonYear = Convert.ToInt32(Console.ReadLine()); // works
            Person person = new Person(PersonName, PersonSurname, PersonSalary, PersonYear);

            person.PrintPerson();
        }
        static void FizzBuzz()
        {
            FizzBuzz MinMax = new FizzBuzz(1, 100);
            MinMax.PrintFizzBuzz();
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
    class FizzBuzz
    {
        private int startNumber;
        private int endNumber;

        // Default constructor:
        public FizzBuzz()
        {
            startNumber = 0;
        }
        
        // Constructor:
        public FizzBuzz(int startNumber, int endNumber)
        {
            this.startNumber = startNumber;
            this.endNumber = endNumber;
        }

        public void PrintFizzBuzz()
        {
            for(var num = 1; num <= 100; num++)
            {
                if(num % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
    }
}
