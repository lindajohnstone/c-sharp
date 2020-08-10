using System;
using Xunit;

namespace test.PayslipProblem
{
    public class CalcGrossPayTests
    {
        [Theory]
        [InlineData(60050, 5004)]
        [InlineData(87000, 7250)]
        [InlineData(87550, 7296)]
        public void aaa(decimal income, decimal expect)
        {
            //arrange
            var calc = new CalcGrossPay();

            //act
            var monthlyGrossIncome = calc.CalcMonthlyGrossIncome(income);

            //assert
            Assert.Equal(expect, monthlyGrossIncome);
        }
        

    }
}
