using System;
using System.Globalization;

namespace PaySlipProblem
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.WelcomeMessage);
            Console.WriteLine("");
            Person employee = new Person();
            employee.CreatePerson();

            Payslip newUser = new Payslip();
            newUser.IncomeUserInput();
            newUser.SuperUserInput();
            newUser.StartDate();
            newUser.EndDate();

            Console.WriteLine();
            Console.WriteLine(Constants.PayslipGeneratedMessage);
            Console.WriteLine();

            employee.PrintPerson();
            newUser.PrintDetails();
            Console.WriteLine();

            Console.WriteLine(Constants.EndMessage);
        }
        
    }
    class Person
    {
        private string name;
        private string surname;
        public Person()
        {
            name = "N/A";
        }
        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public void CreatePerson()
        {
            Console.Write("Please input your name: ");
            name = Console.ReadLine();
            Console.Write("Please input your surname: ");
            surname = Console.ReadLine();
        }
        public void PrintPerson()
        {
            Console.WriteLine("{0} {1}", name, surname);
        }
    }
}