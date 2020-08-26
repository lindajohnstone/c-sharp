using System;

namespace CarPublicAccessModifier
{
    using System;

namespace CarPublicAccessModifier
{
    // W3Schools: https://www.w3schools.com/cs/cs_access_modifiers.asp
    // same as CarPrivateAccessModifier.cs except for change in class Car - public string instead of private string
    class Car
    {
        public string model = "Mustang";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }   
}
}
