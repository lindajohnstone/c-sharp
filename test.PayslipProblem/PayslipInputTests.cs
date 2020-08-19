using System;
//using PaySlipProblem;
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
        [InlineData(10, true)]
        [InlineData(10000, true)]

        public void Should_Check_ReadUserInput_Is_Numeric(decimal input, bool expected)
        {
            //arrange
            var userInput = new PayslipInput();

            //act
            var isInputDecimal = Convert.ToString(userInput.ReadUserInput(input));// PayslipInputTests.cs(37,26): error CS1503: Argument 1: cannot convert from 'bool' to 'string'

            //assert
            Assert.True(expected, isInputDecimal);
        }
       [Theory]
        [InlineData("2016-06-27", "27 June 2016")]
        [InlineData("2016-03-01", "01 March 2016")]
        [InlineData("2017-09-17", "17 September 2017")]
        public void Should_Check_CheckDateFormat_Is_Date(string date, string expected)
        {
            // arrange

    

            var checkDate = new PayslipInput();
            Console.WriteLine("Please enter date "); // need to input number

            // act
            var payslipDate = checkDate.ParseDateIntoString(DateTime.Parse(date));
            //bool test = Boolean.Parse(payslipDate);// not recognised as a valid Boolean; Convert.Boolean returns same error

            // assert
            Assert.Equal(expected, payslipDate);
            //DateTime.ParseExact(date, "dddd MMMM yyyy",)
        }  
    }
}