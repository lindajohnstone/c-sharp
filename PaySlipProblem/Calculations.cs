using System;
using System.Collections.Generic;
using System.Linq;

namespace PaySlipProblem
{
    public class Calculations
    {
        public decimal CalculateMonthlyGrossPay(decimal income)
        {
            return Math.Round(income / 12m);
        }

        public decimal CalculateMonthlyNetPay(decimal monthlyGrossPay, decimal tax)
        {
            return Math.Round(monthlyGrossPay - tax);
        }
        
        public decimal CalculateMonthlySuper(decimal grossPay, decimal superRate)
        {
            return Math.Round(grossPay * (superRate / 100));
        }

        public decimal CalculateMonthlyTax(decimal income)
        {
            var taxableIncomeTaxArray = TaxableIncomeTaxArray.Get();
            var tax = 0m;
            var query = taxableIncomeTaxArray.OrderByDescending(_ => _.Threshold).ToList();
            
            foreach (var taxableIncomeTax in query)
            { 
                if (income > taxableIncomeTax.Threshold)
                {
                    tax = taxableIncomeTax.Base + ((income - (taxableIncomeTax.Threshold)) * taxableIncomeTax.Rate);
                    break;
                }
            }
            return Math.Round(tax / 12m); 
        }
    }
}