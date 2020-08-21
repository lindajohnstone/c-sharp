using System;

namespace Car
{
    // W3Schools: https://www.w3schools.com/cs/cs_classes.asp
    class Car 
    {
        string color = "red";
        string model = "Ford";

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine("My new car is a {0} {1}", myObj.color, myObj.model);
        }
    }
}
