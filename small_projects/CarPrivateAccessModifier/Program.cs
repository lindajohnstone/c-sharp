using System;

namespace CarPrivateAccessModifier
{
    // W3Schools: https://www.w3schools.com/cs/cs_access_modifiers.asp
    /* errors:
            Program.cs(17,37): error CS0122: 'Car.model' is inaccessible due to its protection level 
            [/Users/Linda.Johnstone/Documents/fma/c-sharp/small_projects/CarPrivateAccessModifier/CarPrivateAccessModifier.csproj]
            Program.cs(9,24): warning CS0414: The field 'Car.model' is assigned but its value is never used 
            [/Users/Linda.Johnstone/Documents/fma/c-sharp/small_projects/CarPrivateAccessModifier/CarPrivateAccessModifier.csproj]
    */

    class Car
    {
        private string model = "Mustang";
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
