﻿using System;

namespace magicYrCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            inputDetails(); 
        }
        
        static void magicYear(int num)
        {
            var mgcYr = num + 65;
            Console.Write("Magic Year: ");
            Console.WriteLine(mgcYr);
        }
        static void mthlySalary(int num)
        {
            var mthSalary = num / 12;
            Console.Write("Monthly Salary: ");
            Console.WriteLine(mthSalary);
        } 
        static void inputDetails()
        {
            Console.WriteLine("Please input your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please input your surname:");
            var surname = Console.ReadLine();
            var fullName = name + ' ' + surname;
            Console.WriteLine("Please enter your annual salary: ");
            var salary = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter your work start year: ");
            var year = int.Parse(Console.ReadLine());
            //year = Convert.ToInt32(year);
            //Convert.ToInt32(year);
            Console.WriteLine(name + ' ' + surname);
            mthlySalary(salary);
            magicYear(year);
            //Console.WriteLine(fullName);
        }
    }
}