using System;

namespace InterfaceAnimalW3Sv2
{
    // Interface
    interface IAnimal 
    {
        void animalSound(); // interface method (does not have a body)
        void animalFood();
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal 
    {
        public void animalSound() 
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }

        public void animalFood()
        {
            Console.WriteLine("The pig eats corn");
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
            myPig.animalFood();
        }
    }
}
