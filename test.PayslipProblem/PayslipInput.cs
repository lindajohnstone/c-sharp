using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace test.PayslipProblem
{
    public class PayslipInput
    {
        public decimal ReadUserInput(decimal value) 
        { 
            if (decimal.TryParse(Console.ReadLine(), out var validateDecimal))
            {
                return validateDecimal;
            }
            else
            {
                Console.WriteLine("Input is not a valid number. ");
                return ReadUserInput(value); //recursive
            }  
        }
        public string ParseDateIntoString(DateTime value)
        {
            string date = String.Empty;
            if (DateTime.TryParse(Console.ReadLine(), out var dateValue))
            {
                date = String.Format("{0:dd MMMM yyyy}", dateValue);
            }
            else 
            {
                Console.Write("Please try again. ");
                date = ParseDateIntoString(value);
            }
            return date;
        }
    }
}