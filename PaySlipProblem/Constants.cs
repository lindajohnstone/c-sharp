using System;
using System.Globalization;

namespace PaySlipProblem
{
    public class Constants
    {
        public const decimal TaxLevel1 = 18200;
        public const decimal TaxLevel2 = 37000;
        public const decimal TaxLevel3 = 87000;
        public const decimal TaxLevel4 = 180000;
        public const decimal Months = 12m;
        public const string WelcomeMessage = "Welcome to the payslip generator!";
        public const string PayslipGeneratedMessage = "Your payslip has been generated:";
        public const string EndMessage  = "Thank you for using MYOB!";
    }
}