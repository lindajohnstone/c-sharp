using System;

namespace AbstractClass
{
    // w3schools: https://www.w3schools.com/cs/cs_abstract.asp
    // Why And When To Use Abstract Classes and Methods?
    // To achieve security - hide certain details and only show the important details of an object.
    class Program
    {
        static void Main(string[] args)
        {
            //Animal myObj = new Animal(); error CS0144: Cannot create an instance of the abstract class or interface 'Animal'
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
        }
    }
    // Abstract class
    abstract class Animal
    {
    // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
        }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
    }
}
