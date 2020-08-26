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
            var payslipIO = new PayslipIO();
            var payslipInput = new PayslipInput(payslipIO);
            
            Payslip newUser = new Payslip(calculations, payslipInput);
            
            newUser.GetUserData();

            Console.WriteLine(Environment.NewLine + Constants.PayslipGeneratedMessage + Environment.NewLine);

            employee.PrintPerson();
            newUser.PrintDetails();

            Console.WriteLine(Environment.NewLine + Constants.EndMessage);
        }
    }
    
}