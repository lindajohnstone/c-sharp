using System;
using System.Globalization;
using System.Text.RegularExpressions;
using PaySlipProblem;

namespace test.PayslipProblem
{
    public class PersonInput
    {
        public string pattern = "^[a-zA-Z]+[a-zA-Z '-]*$"; // want to add whitespace (0 or more), hyphen (-), single quote (') single quote b4 hyphen
    
        public bool ValidateName(string value)
        {
            return Regex.Match(value, pattern).Success;
        }
    }
}