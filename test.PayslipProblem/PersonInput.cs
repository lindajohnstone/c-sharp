using System;
using System.Globalization;
using System.Text.RegularExpressions;
using PaySlipProblem;

namespace test.PayslipProblem
{
    public class PersonInput
    {
        public string pattern = "^[A-Z][a-zA-Z]*$"; // want to add whitespace (0 or more), hyphen (-), single quote (')
    
        public string UseRegexNameValidCharacters(string value)
        {
            if (Regex.Match(value, pattern).Success)
            {
                return value;
            }
            /* var match = Regex.Match(value, pattern);
            if (match.Success )
            {
                return match.Value;
            } */
        }
    }
}