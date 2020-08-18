using System;

namespace test.PayslipProblem
{
    internal class Calculations
    {
        public Calculations()
        {

        }

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
    }
}