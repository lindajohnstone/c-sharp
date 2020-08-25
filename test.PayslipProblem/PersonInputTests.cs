using System;
using PaySlipProblem;
using Xunit;

namespace test.PayslipProblem
{
    public class PersonInputTests
    {
        [Theory]
        [InlineData("john", "john")]
        public void Should_Check_Name_IsNotNumeric(string input, string expected)
        {
            //arrange
            var checkUserInput = new PersonInput();
            //act
            string personName = checkUserInput.UseRegexNameValidCharacters(input);
            
            //assert
            Assert.Equal(expected, personName); 

        }
    }
}