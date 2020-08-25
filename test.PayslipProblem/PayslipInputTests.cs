using System;
using PaySlipProblem;
using Xunit;

namespace test.PayslipProblem
{
    public class PayslipInputTests
    {/* 
       [Fact]
        public void Should_Check_ReadUserInput_IsNumeric()
        {
            //arrange
            var checkUserInput = new PayslipInput();
            Console.WriteLine("Please enter a number "); // need to input number

            //act
            var payslipDecimals = checkUserInput.ReadUserInput();
            bool test = Convert.ToBoolean(payslipDecimals);
            
            //assert
            Assert.True(test, $"The string {payslipDecimals} is not a number"); 
        } */

        [Theory]
        [InlineData("10", 10)]
        [InlineData("10000", 10000)]
        public void Should_Check_ReadUserInput_Is_Numeric(string input, decimal expected)
        {
            //arrange
            IPayslipIO payslipIO = new StubPayslipIO().WithReadLine(input);
            var userInput = new PayslipInput(payslipIO);

            //act
            var result = userInput.ReadUserInput();

            //assert
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData("2016-06-27", "27 June 2016")]
        [InlineData("2016-03-01", "01 March 2016")]
        [InlineData("2017-09-17", "17 September 2017")]
        public void Should_Check_CheckDateFormat_Is_Date(string date, string expected)
        {
            // arrange
            IPayslipIO payslipIO = new StubPayslipIO().WithReadLine(date);
            var checkDate = new PayslipInput(payslipIO);
            //Console.WriteLine("Please enter date "); // need to input number

            // act
            var payslipDate = checkDate.ParseDateIntoString();
            //bool test = Boolean.Parse(payslipDate);// not recognised as a valid Boolean; Convert.Boolean returns same error

            // assert
            Assert.Equal(expected, payslipDate);
            //DateTime.ParseExact(date, "dddd MMMM yyyy",)
        }  
    }
}