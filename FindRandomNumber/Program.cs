using System;

namespace FindRandomNumber
{
    class Program
    {
        static void ChosenNumber()
        {
            Random rand = new Random();
            int randomInt = rand.Next(1,100);
            //Console.WriteLine(randomInt); test line 
            Console.WriteLine("You have 10 chances to guess the selected number");
            int choiceNumber = 1;
            while(choiceNumber <= 10) {
                Console.WriteLine("Please enter a guess between 1 and 100");
                int parseInt = int.Parse(Console.ReadLine());
                //Console.WriteLine($"The number chosen is {parseInt}"); test line
                if(parseInt > randomInt)
                    Console.WriteLine("Number is too high.");
                if (parseInt < randomInt) 
                    Console.WriteLine("Number is too low.");
                if (parseInt == randomInt){
                    Console.WriteLine("You are CORRECT!!");
                    break;
                }
                Console.WriteLine($"Guess number: {choiceNumber}");
                choiceNumber++;
                //Console.WriteLine(choiceNumber);
            }
        }

        static void Main(string[] args)
        {
            ChosenNumber();
        }
    }
}
