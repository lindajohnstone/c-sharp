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
                var messageText = "Please select from the following options: 1 - Magic Year Calculator, 2 - FizzBuzz, 3 - PrintChild. ";
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
            Console.WriteLine("Are you sure you want to exit? Please type 'yes' to exit and 'no' to continue.");// 'yes'exits, no repeats once
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
            //Console.Write("Child #4: ");
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
}
