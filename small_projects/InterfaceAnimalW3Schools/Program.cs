using System;

namespace IAnimal
{
    // Interface
    interface IAnimal 
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal 
    {
        public void animalSound() 
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: oink oink");
        }
    }
    class Dog : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says: woof woof");
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
            Dog myDog = new Dog();
            myDog.animalSound();
        }
    }
}
