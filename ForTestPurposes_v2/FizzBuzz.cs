using System;
using System.Globalization;

namespace ForTestPurposes
{
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
