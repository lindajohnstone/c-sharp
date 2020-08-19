using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace PaySlipProblem
{
    public class PayslipInput
    {
        private IPayslipIO _payslipIO;
        public PayslipInput(IPayslipIO payslipIO)
        {
            _payslipIO = payslipIO;
        }
        public decimal ReadUserInput() 
        { 
            if (decimal.TryParse(_payslipIO.ReadLine(), out var validateDecimal))
            {
                return validateDecimal;
            }
            else
            {
                _payslipIO.WriteLine("Input is not a valid number. ");
                return ReadUserInput(); //recursive
            }  
        }
        public string ParseDateIntoString()
        {
            string date = String.Empty;
            if (DateTime.TryParse(_payslipIO.ReadLine(), out var dateValue))
            {
                date = String.Format("{0:dd MMMM yyyy}", dateValue);
            }
            else 
            {
                _payslipIO.WriteLine("Please try again. ");
                date = ParseDateIntoString();
            }
            return date;
        }
    }
}