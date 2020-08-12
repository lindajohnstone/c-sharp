using System;
using System.Collections.Generic;
using System.Linq;

namespace PaySlipProblem
{
    public class Payslip
    {

        private decimal income;
        private decimal tax;
        private decimal netPay;
        private decimal grossPay;
        private decimal super;
        private decimal superRate;
        private string[] startDate;
        private string endDate;

        //constructor
        public Payslip()
        {
            income = 0;
        }
        public Payslip(decimal income)
        {
            this.income = income;
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
        public void CalculateGrossPay(decimal income)
        {
            grossPay = income / Constants.Months;
        }
        public void CalculateNetPay()
        {
            netPay = grossPay - tax;
        }
        private decimal ReadUserInputAsDecimal() 
        { 
            var isValidDecimal = decimal.TryParse(Console.ReadLine(), out var validateDecimal); 
            if (isValidDecimal)
            {
                return validateDecimal;
            }
            else
            {
                Console.WriteLine("Input is not a valid number. ");
                return ReadUserInputAsDecimal(); //recursive
            } 
        }
        public void IncomeUserInput()
        {
            Console.Write("Please input your annual salary: ");
           
            income = ReadUserInputAsDecimal();
        }
        public void SuperUserInput()
        {
            Console.Write("Please input your super rate: ");
        
            superRate = ReadUserInputAsDecimal() / 100; // make it a percentage
        }
        public void PaymentPeriod()
        {
            Console.Write("Pay Period: ");
            if (startDate[0].Length < 2)
            {
                Console.Write("0{0}", startDate[0]);
            }
            else
            {
                Console.Write(startDate[0]);
            }
            Console.WriteLine(" {0} - {1}", startDate[1],endDate);
        }
        public void StartDate()
        {
            Console.Write("Please enter your payment start date: ");
            startDate = Console.ReadLine().Split(default(Char[]), StringSplitOptions.RemoveEmptyEntries);
        }
        public string EndDate()
        {
            Console.Write("Please enter your payment end date: ");
            endDate = Console.ReadLine();
            return endDate;
        }
        public void PrintDetails()
        {
            PaymentPeriod();
            CalculateGrossPay(income);
            Console.WriteLine("Gross Income: {0:F0}", grossPay);
            CalculateTax(income);
            Console.WriteLine("Income tax: {0:F0}",tax);
            CalculateNetPay();
            Console.WriteLine("Net Income:{0:F0}", netPay);
            CalculateSuper(income, superRate);
            Console.WriteLine("Super: {0:F0}", super);
        }
    }
}