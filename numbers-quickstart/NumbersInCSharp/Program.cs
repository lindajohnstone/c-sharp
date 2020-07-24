using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;

            // addition
            int c = a + b;
            Console.WriteLine(c);

            // subtraction
            c = a - b;
            Console.WriteLine(c);

            // multiplication
            c = a * b;
            Console.WriteLine(c);

            // division
            c = a / b;
            Console.WriteLine(c);
        }

        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            //int d = a + b * c; 13
            int d = (a + b) * c;
            Console.WriteLine(d);
            d = (a +b) - 6 * c + (12 * 4) / 3 + 12;
            Console.Write(d);
            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }
        static void TestLimits()
        {
            int a = 7; 
            int b = 4;
            int c = 3;
            int d = (a = b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        static void WorkWithDoubles()
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);
            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h);
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
            double third = 1.0 / 3.0;
            Console.WriteLine(third);
            double i = 180;
            double j = 89;
            double k = 12;
            double l = 132;
            Console.WriteLine(i / k);
            Console.WriteLine((i + j) - k / l);
            Console.WriteLine(i - j);
            Console.WriteLine(i % l);
        }

        static void Main(string[] args)
        {
            //WorkingWithIntegers();
            
            //OrderPrecedence();

            //TestLimits();

            //WorkWithDoubles();

            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}.");
            
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            // code to calculate area of circle with radius 2.50 cm
            double radius = 2.50;
            // double area = Math.Pi * radius * radius;
            double area = Math.PI * Math.Pow(radius, 2.0); 
            Console.WriteLine(area);
        }
    }
}