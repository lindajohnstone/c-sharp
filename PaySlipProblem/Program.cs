﻿using System;
using System.Globalization;

namespace PaySlipProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.WelcomeMessage + Environment.NewLine);
            //Console.WriteLine("");
            Person employee = new Person();
            employee.GetPersonNameSurname();

            Payslip newUser = new Payslip();
            newUser.GetUserData();

            //Console.WriteLine();
            Console.WriteLine(Environment.NewLine + Constants.PayslipGeneratedMessage + Environment.NewLine);
            //Console.WriteLine();

            employee.PrintPerson();
            newUser.PrintDetails();
            Console.WriteLine();

            Console.WriteLine(Constants.EndMessage);
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        //public Payslip EmployeeData { get; set; } // link person class to payslip class
        public void GetPersonNameSurname()
        {
            Console.Write("Please input your name: ");
            Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            Console.Write("Please input your surname: ");
            Surname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
        }
        public void PrintPerson()
        {
            Console.WriteLine("{0} {1}", Name, Surname);
        }
        //public void GetPersonPayslip
    }
}