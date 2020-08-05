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
                        Person person = new Person();
                        person.CreateMgcYrCal();
                        break;
                    case 2:
                        FizzBuzz minMax = new FizzBuzz(1, 100);
                        minMax.PrintFizzBuzz();
                        break;
                    case 3:
                        Child child = new Child();
                        child.CreateChild();
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1 - 3.");
                        break;
                }// does not execute switch
            }
            /* public void PrintSwitch()
            {
                Console.WriteLine();
            } */
        }
    class Program
    {
        static void UserChoice() 
            {
                var messageText = "Please select from the following options: 1 - Magic Year Calculator, 2 - FizzBuzz, 3 - PrintChild. ";
                Console.WriteLine(messageText);
                
                var switchNum = Console.ReadLine();
                
                if (!int.TryParse(switchNum, out var newNum)) 
                {
                    Console.WriteLine("Please enter a number");
                }
                else 
                {
                    SwitchNum sNum = new SwitchNum(newNum);
                    /* switch(newNum)
                    {
                        case 1:
                            Person person = new Person();
                            person.CreateMgcYrCal();
                            break;
                        case 2:
                            FizzBuzz minMax = new FizzBuzz(1, 100);
                            minMax.PrintFizzBuzz();
                            break;
                        case 3:
                            Child child = new Child();
                            child.CreateChild();
                            break;
                        default:
                            Console.WriteLine("Please enter a number between 1 - 3.");
                            break;
                    }  */
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
            
            if (choice == "no")
            {
                UserChoice();
            } 
            
        }

        static string ChangeTitleCase(string value)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }
    }
}
