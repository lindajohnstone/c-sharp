using System;

namespace PolymorphismUsingVirtualOverride
// Why And When To Use "Inheritance" and "Polymorphism"?
// - It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.
{
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound() 
        {
            Console.WriteLine("The animal makes a sound");
        }
        public virtual void animalFood()
        {
            Console.WriteLine("The animal eats food");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound() 
        {
            Console.WriteLine("The pig says: wee wee");
        }
        public override void animalFood()
        {
            Console.WriteLine("The pig eats corn");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound() 
        {
            Console.WriteLine("The dog says: bow wow");
        }
        public override void animalFood()
        {
            Console.WriteLine("The dog eats chicken");
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            myPig.animalFood();
            myDog.animalFood();
        }
    }
}
