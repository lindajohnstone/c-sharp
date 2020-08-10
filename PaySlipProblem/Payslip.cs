using System;
using System.Globalization;

namespace PaySlipProblem
{
    public class Payslip
    {
        private decimal income;
        private decimal tax;
        private decimal netPay;
        private decimal grossPay;
        private decimal super;
        private decimal superRate;
        private string[] startDate;
        private string endDate;
        private decimal[] taxThreshold = {18200, 37000, 87000, 180000};
        private decimal[] baseTax = {0, 3572, 19822, 54232};
        private decimal[] taxRate = {0.19m, 0.325m, 0.37m, 0.45m};
        
        //constructor
        public Payslip()
        {
            income = 0;
        }
        public Payslip(decimal income)
        {
            this.income = income;
        }
        public void CalculateTax(decimal income)
        {
            /*
                logic:
                check which taxThreshold[num].indexOf income falls into 
                use taxThreshold[].indexOf ??
                tax = baseTax[num] + ((income - taxThreshold[num])) * taxRate[num];
                what loop??
             */
            decimal searchTaxThreshold = income; // 
            int index = Array.IndexOf(taxThreshold, searchTaxThreshold);
            //if (income > taxThreshold[3] + 1)
            //{
            /*  }
            else if (income > taxThreshold[2] + 1)
            {
               tax = baseTax[2] + ((income - (taxThreshold[2])) * taxRate[2]);
            }
            else if (income > taxThreshold[1] + 1)
            {
               tax = baseTax[1] + ((income - (taxThreshold[1])) * taxRate[1]);
            }
            else if (income > taxThreshold[0] + 1)
            {
               tax = baseTax[0] + ((income - (taxThreshold[0])) * taxRate[0]);
            }
            else
            {
                tax = 0; 
            }   */
            //tax = tax / Constants.Months; 
            tax = index;
        }
        public void CalculateSuper(decimal income, decimal superRate)
        {
            super = (income / Constants.Months) * superRate;
        }
        public void CalculateGrossPay(decimal income)
        {
            grossPay = income / Constants.Months;
        }
        public void CalculateNetPay()
        {
            netPay = grossPay - tax;
        }
        public void IncomeUserInput()
        {
            Console.Write("Please input your annual salary: ");
            //if(decimal.TryParse(Console.ReadLine(), out var newNum)) // check it is a number
            //{
                income = Convert.ToDecimal(Console.ReadLine()); // terminology to determine if a number??
            //}
            //else 
            //{
            //    Console.WriteLine("Sorry, input should be numbers. Please try again");
            //}
            
        }
        public void SuperUserInput()
        {
            Console.Write("Please input your super rate: ");
            superRate = Convert.ToDecimal(Console.ReadLine()) / 100; // make it a percentage
        }
        public void PaymentPeriod()
        {
            Console.Write("Pay Period: ");
            if (startDate[0].Length < 2)
            {
                Console.Write("0{0}", startDate[0]);
            }
            else
            {
                Console.Write(startDate[0]);
            }
            Console.WriteLine(" {0} - {1}", startDate[1],endDate);
        }
        public void StartDate()
        {
            Console.Write("Please enter your payment start date: ");
            startDate = Console.ReadLine().Split(default(Char[]), StringSplitOptions.RemoveEmptyEntries);
        }
        public string EndDate()
        {
            Console.Write("Please enter your payment end date: ");
            endDate = Console.ReadLine();
            return endDate;
        }
        public void PrintDetails()
        {
            PaymentPeriod();
            CalculateGrossPay(income);
            Console.WriteLine("Gross Income: {0:F0}", grossPay);
            CalculateTax(income);
            Console.WriteLine("Income tax: {0:F0}",tax);
            CalculateNetPay();
            Console.WriteLine("Net Income:{0:F0}", netPay);
            CalculateSuper(income, superRate);
            Console.WriteLine("Super: {0:F0}", super);
            /* complete expected output:
                Welcome to the payslip generator!

                Please input your name: John  
                Please input your surname: Doe  
                Please enter your annual salary: 60050
                Please enter your super rate: 9
                Please enter your payment start date: 1 March
                Please enter your payment end date: 31 March

                Your payslip has been generated:

                Name: John Doe  
                Pay Period: 01 March – 31 March  
                Gross Income: 5004  
                Income Tax: 922 
                Net Income:4082 
                Super: 450  

                Thank you for using MYOB!
            */
        }
    }
}