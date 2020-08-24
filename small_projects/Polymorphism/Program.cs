using System;

namespace Polymorphism
{
    // Program.cs(23,21): warning CS0108: 'Dog.animalSound()' hides inherited member 'Animal.animalSound()'. Use the new keyword if hiding was intended. [/Users/Linda.Johnstone/Documents/fma/c-sharp/small_projects/Polymorphism/Polymorphism.csproj]
    // Program.cs(15,21): warning CS0108: 'Pig.animalSound()' hides inherited member 'Animal.animalSound()'. Use the new keyword if hiding was intended. [/Users/Linda.Johnstone/Documents/fma/c-sharp/small_projects/Polymorphism/Polymorphism.csproj]

    class Animal  // Base class (parent) 
    {
        public void animalSound() 
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public void animalSound() 
        {
            Console.WriteLine("The pig says: wee wee");
        }
        }

        class Dog : Animal  // Derived class (child) 
        {
        public void animalSound() 
        {
            Console.WriteLine("The dog says: bow wow");
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
        }
    }
}
