using System;
using Xunit;

namespace test.PayslipProblem
{
    public class CalculationTests
    {
        [Theory]
        [InlineData(60050, 5004)]
        [InlineData(87000, 7250)]
        [InlineData(87550, 7296)]
        public void AnnualIncomeToGrossPayTest(decimal income, decimal expected)
        {
            //arrange
            var calculateGrossPay = new Calculations();

            //act
            var monthlyGrossPay = calculateGrossPay.CalculateMonthlyGrossPay(income);

            //assert
            Assert.Equal(expected, monthlyGrossPay);
        }

        [Theory]
        [InlineData(5004, 922, 4082)]
        [InlineData(1516, 0, 1516)]
        [InlineData(7250, 1652, 5598)]
        public void GrossPayToNetPay(decimal grossPay, decimal tax, decimal expected)
        {
            //arrange
            var calculateNetPay = new Calculations();

            //act
            var monthlyNetIncome = calculateNetPay.CalculateMonthlyNetPay(grossPay, tax);

            //assert
            Assert.Equal(expected, monthlyNetIncome);
        }

        [Theory]
        [InlineData(5004, 9, 450)]
        [InlineData(5004, 27, 1351)]
        [InlineData(5004, 15, 751)]
        [InlineData(4005, 9, 360)]
        public void Super(decimal grossPay, decimal superRate, decimal expected)
        {
            // arrange 
            var calculateSuper = new Calculations();
            // act
            var monthlySuper = calculateSuper.CalculateMonthlySuper(grossPay, superRate);
            // assert
            Assert.Equal(expected, monthlySuper);
        }

    }
}
