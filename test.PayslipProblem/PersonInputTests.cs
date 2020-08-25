using System;
using PaySlipProblem;
using Xunit;

namespace test.PayslipProblem
{
    public class PersonInputTests
    {
        [Theory]
        [InlineData("john", true)]
        [InlineData("Jones 12", false)]
        [InlineData("*James", false)]
        [InlineData("amy lee", true)]
        [InlineData("amy-lee", true)]
        [InlineData("o'brien", true)]
        public void Should_Check_Name_IsNotNumeric(string input, bool expected)
        {
            //arrange
            var checkUserInput = new PersonInput();
            //act
            bool personName = checkUserInput.ValidateName(input);
            
            //assert
            Assert.Equal(expected, personName); 

        }
    }
}