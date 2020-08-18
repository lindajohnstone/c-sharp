using System;
using System.Globalization;

namespace PaySlipProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.WelcomeMessage);
        
            Person employee = new Person();
            employee.GetPersonNameSurname();

            var calculations = new Calculations();

            Payslip newUser = new Payslip(calculations);
            
            newUser.GetUserData();

            Console.WriteLine(Environment.NewLine + Constants.PayslipGeneratedMessage + Environment.NewLine);

            employee.PrintPerson();
            newUser.PrintDetails();

            Console.WriteLine(Environment.NewLine + Constants.EndMessage);
        }
    }
    
}