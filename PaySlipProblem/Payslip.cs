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

        public void CalculateTax(decimal income)
        {
            var taxableIncomeTaxArray = TaxableIncomeTaxArray.Get();
            var query = taxableIncomeTaxArray.OrderByDescending(_ => _.Threshold).ToList();
            
            foreach (var taxableIncomeTax in query)
            { 
                if (income > taxableIncomeTax.Threshold)
                {
                    tax = taxableIncomeTax.Base + ((income - (taxableIncomeTax.Threshold)) * taxableIncomeTax.Rate);
                    break;
                }
            }
            tax = tax / Constants.Months; 
        }
        public void CalculateSuper(decimal income, decimal superRate)
        {
            super = (income / Constants.Months) * superRate;
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
        public void IncomeUserInput()
        {
            Console.Write("Please input your annual salary: ");
           
            annualIncome = ReadUserInput();
        }
        public void SuperUserInput()
        {
            Console.Write("Please input your super rate: ");
        
            superRate = ReadUserInput() / 100; // make it a percentage
        }
    
        public void GetUserData()
        {
            Console.Write("Please input your annual salary: ");
            annualIncome = ReadUserInput();

            Console.Write("Please input your super rate: ");
            superRate = ReadUserInput() / 100; // make it a percentage
        }
        public void PrintPaymentPeriod()
        {
            Console.WriteLine("Payment Period: {0} - {1}", startDate, endDate);
        }
        private string CheckDateFormat()
        {

            Console.Write("Please enter your payment start date (date Month): ");
            // todo: method to parse date??
            if (DateTime.TryParse(Console.ReadLine(), out var dateValue))
            {
                //startDate = Convert.ToString(dateValue); writes date as 01/03/2020 00:00:00
                startDate = String.Format("{0:dd MMMM}", dateValue);

            }
            else 
            {
                Console.Write("Please try again. ");
                startDate = CheckDateFormat();

            }
            return startDate;
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
            PrintPaymentPeriod();
            CalculateGrossPay();
            CalculateTax();
            CalculateNetPay();
            CalculateSuper();
        }
        public void PrintDetails()
        {
            PrintPaymentPeriod();
            DoCalculations();

            Console.WriteLine("Gross Income: {0:F0}", grossPay);
            Console.WriteLine("Income Tax: {0:F0}", tax);
            Console.WriteLine("Net Income: {0:F0}", netPay);
            Console.WriteLine("Super: {0:F0}", super);
        }
    }
}