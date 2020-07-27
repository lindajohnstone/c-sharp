using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /* Fizz Buzz Kata
               Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” 
               instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples 
               of both three and five print “FizzBuzz”."
               Example Output
                1
                2
                Fizz
                4
                Buzz
                Fizz
                7
                etc. 
            */
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
