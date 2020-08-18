using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace PaySlipProblem
{
    public class Payslip
    {
        private decimal annualIncome;
        private decimal tax;
        private decimal netPay;
        private decimal grossPay;
        private decimal super;
        private decimal superRate;
        private string startDate;
        private string endDate;
        private Calculations _calculations;

        public Payslip(Calculations calculations)
        {
            _calculations = calculations;
        }

     
        private decimal ReadUserInput() 
        { 
            if (decimal.TryParse(Console.ReadLine(), out var validateDecimal))
            {
                return validateDecimal;
            }
            else
            {
                Console.WriteLine("Input is not a valid number. ");
                return ReadUserInput(); //recursive
            } 
        }
    
        public void GetUserData()
        {
            Console.Write("Please input your annual salary: ");
            annualIncome = ReadUserInput();

            Console.Write("Please input your super rate: ");
            superRate = ReadUserInput(); // make it a percentage
            StartDate();
            EndDate();
        }
        public void PrintPaymentPeriod()
        {
            Console.WriteLine("Payment Period: {0} - {1}", startDate, endDate);
        }
        private string CheckDateFormat()
        {
            string date = String.Empty;
            if (DateTime.TryParse(Console.ReadLine(), out var dateValue))
            {
                date = String.Format("{0:dd MMMM, yyyy}", dateValue);
            }
            else 
            {
                Console.Write("Please try again. ");
                date = CheckDateFormat();
            }
            return date;
        }
        public void StartDate()
        {
            Console.Write("Please enter your payment start date (date Month Year): ");
            startDate = CheckDateFormat();
        }
        public void EndDate()
        {
            Console.Write("Please enter your payment end date (date Month Year): ");
            endDate = CheckDateFormat();
        }
        public void DoCalculations()
        {
            grossPay =  _calculations.CalculateMonthlyGrossPay(annualIncome);
            tax = _calculations.CalculateMonthlyTax(annualIncome);
            netPay =  _calculations.CalculateMonthlyNetPay(grossPay, tax);
            super = _calculations.CalculateMonthlySuper(grossPay, superRate);
        }
        public void PrintDetails()
        {
            DoCalculations();
            PrintPaymentPeriod();

            Console.WriteLine("Gross Income: {0:F0}", grossPay);
            Console.WriteLine("Income Tax: {0:F0}", tax);
            Console.WriteLine("Net Income: {0:F0}", netPay);
            Console.WriteLine("Super: {0:F0}", super);
        }
    }
}