using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PaySlipProblem
{
    public class NameValidations
    {
        public string pattern = "^[a-zA-Z]+[a-zA-Z '-]*$"; 
    
        public bool ValidateName(string value)
        {
            return Regex.Match(value, pattern).Success;
        }
    }
}