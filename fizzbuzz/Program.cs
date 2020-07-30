using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
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
