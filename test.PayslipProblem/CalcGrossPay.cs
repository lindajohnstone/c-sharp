using System;

namespace test.PayslipProblem
{
    internal class CalcGrossPay
    {
        public CalcGrossPay()
        {

        }

        public decimal CalcMonthlyGrossIncome(decimal income)
        {
            return Math.Round(income / 12m);
        }
    }
}