using System;
using System.Globalization;

namespace PaySlipProblem
{
    class Program
    {
        const string welcomeMessage = "Welcome to the payslip generator!";
        const string payslipGeneratedMessage = "Your payslip has been generated:";
        const string endMessage  = "Thank you for using MYOB!";
        static void Main(string[] args)
        {
            Console.WriteLine(welcomeMessage);
            Console.WriteLine("");
            Person employee = new Person();
            employee.CreatePerson();
            
            Payslip newUser = new Payslip();
            newUser.CreatePayslip();

            employee.PrintPerson();
            newUser.PrintDetails();
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