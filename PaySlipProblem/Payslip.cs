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
        private PayslipInput _payslipInput;

        public Payslip(Calculations calculations, PayslipInput payslipInput)
        {
            _calculations = calculations;
            _payslipInput = payslipInput;
        }
    
        public void GetUserData()
        {
            Console.Write("Please input your annual salary: ");
            annualIncome = _payslipInput.ReadUserInput();

            Console.Write("Please input your super rate: ");
            superRate = _payslipInput.ReadUserInput(); 

            Console.Write("Please enter your payment start date (date Month Year): ");
            startDate = _payslipInput.ParseDateIntoString();
            
            Console.Write("Please enter your payment end date (date Month Year): ");
            endDate = _payslipInput.ParseDateIntoString();
        }
        public void PrintPaymentPeriod()
        {
            Console.WriteLine("Payment Period: {0} - {1}", startDate, endDate);
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

            Console.WriteLine("Gross Income: {0}", grossPay);
            Console.WriteLine("Income Tax: {0}", tax);
            Console.WriteLine("Net Income: {0}", netPay);
            Console.WriteLine("Super: {0}", super);
        }
    }
}