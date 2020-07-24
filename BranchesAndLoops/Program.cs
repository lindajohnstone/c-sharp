using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void NumberLessOrMore()
        {
            int a = 5;
            int b = 3;
            int c = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10!");
            else
                Console.WriteLine("The answer is not greater than 10!");
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
                }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            } 
        }

        static void LeapYear()
        {
            Console.WriteLine("Enter Year : ");  
            int Year = int.Parse(Console.ReadLine());  
            //if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) 
            if (Year % 4 == 0)
                Console.WriteLine("{0} is a Leap Year.", Year);  
            else Console.WriteLine("{0} is not a Leap Year.", Year);  
            Console.ReadLine(); 
        }
        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;
            if ((a + b + c > 10) && (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not greater than the second");
            }

            if ((a + b + c > 10) || (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
        }

        static void ExploreWhile()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
            int counter1 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter1}");
                counter1++;
            } while (counter1 < 10);
        }
        
        static void ExploreFor()
        {
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }
                        for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }
        static void Main(string[] args)
        {
            //ExploreFor();
            /* Now that you've seen the if statement and the looping constructs in the C# language, see if you can write C# code to find the sum 
                of all integers 1 through 20 that are divisible by 3. Here are a few hints:
                The % operator gives you the remainder of a division operation.
                The if statement gives you the condition to see if a number should be part of the sum.
                The for loop can help you repeat a series of steps for all the numbers 1 through 20. 
            */
            int challengeAnswer = 0;

            for(int i = 1; i <= 20; i++)
            {
                if ( i % 3 == 0)
                    challengeAnswer = challengeAnswer + i;
            }
            Console.WriteLine($"The total is {challengeAnswer}");
        }
    }
}
