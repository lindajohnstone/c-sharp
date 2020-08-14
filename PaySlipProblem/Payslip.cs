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
        public void CalculateTax()
        {
            var taxableIncomeTaxArray = TaxableIncomeTaxArray.Get();
            var query = taxableIncomeTaxArray.OrderByDescending(_ => _.Threshold).ToList();
            
            foreach (var taxableIncomeTax in query)
            { 
                if (annualIncome > taxableIncomeTax.Threshold)
                {
                    tax = taxableIncomeTax.Base + ((annualIncome - (taxableIncomeTax.Threshold)) * taxableIncomeTax.Rate);
                    break;
                }
            }
            tax = tax / Constants.Months; 
        }
        public void CalculateSuper()
        {
            super = grossPay * superRate;
        }
        public void CalculateGrossPay()
        {
            grossPay = annualIncome / Constants.Months;
        }
        public void CalculateNetPay()
        {
            netPay = grossPay - tax;
        }
        private decimal ReadUserInput() 
        { 
            //var isValidDecimal = decimal.TryParse(Console.ReadLine(), out var validateDecimal); 
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
            superRate = ReadUserInput() / 100; // make it a percentage

            StartDate();
            EndDate();
        }
        public void PaymentPeriod()
        {
            Console.WriteLine("Payment Period: {0} - {1}", startDate, endDate);
        }
        private string DateFormat()
        {
            string date = String.Empty;
            if (DateTime.TryParse(Console.ReadLine(), out var dateValue))
            {
                //startDate = Convert.ToString(dateValue); writes date as 01/03/2020 00:00:00
                date = String.Format("{0:dd MMMM, yyyy}", dateValue);
            }
            else 
            {
                Console.Write("Please try again. ");
                date = DateFormat();
            }
            return date;
        }
        public void StartDate()
        {
            Console.Write("Please enter your payment start date (date Month): ");
            startDate = DateFormat();
            /* if (DateTime.TryParse(Console.ReadLine(), out var dateValue))
            {
                //startDate = Convert.ToString(dateValue); writes date as 01/03/2020 00:00:00
                startDate = String.Format("{0:dd MMMM}", dateValue);
            }
            else 
            {
                Console.Write("Please try again. ");
                StartDate();
            } */
        }
        public void EndDate()
        {
            Console.Write("Please enter your payment end date (date Month): ");
            endDate = DateFormat();
           /*  if (DateTime.TryParse(Console.ReadLine(), out var dateValue))
            {
                endDate = String.Format("{0:dd MMMM}", dateValue);
            }
            else 
            {
                Console.Write("Please try again. ");
                EndDate();
            } */
        }
        public void PrintDetails()
        {
            PaymentPeriod();
            CalculateGrossPay();
            Console.WriteLine("Gross Income: {0:F0}", grossPay);
            CalculateTax();
            Console.WriteLine("Income tax: {0:F0}", tax);
            CalculateNetPay();
            Console.WriteLine("Net Income: {0:F0}", netPay);
            CalculateSuper();
            Console.WriteLine("Super: {0:F0}", super);
        }
    }
}