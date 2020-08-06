using System;
using System.Globalization;

namespace PaySlipProblem
{
    public class Payslip
    {
        private double income;
        private double tax;
        private double netPay;
        private double grossPay;
        private double super;
        private double superRate;
        const double taxLevel1 = 18200;
        const double taxLevel2 = 37000;
        const double taxLevel3 = 87000;
        const double taxLevel4 = 180000;
        //constructor
        public Payslip()
        {
            income = 0;
        }
        public Payslip(double income)
        {
            this.income = income;
        }
        public void CalcTax(double income)
        {
            if (income > taxLevel4 + 1)
            {
               tax = 54232 + ((income - (taxLevel4)) * 0.45); 
            }
            else if (income > taxLevel3 +1)
            {
                tax = 19822 + ((income - taxLevel3) * 0.37);
            }
            else if (income > taxLevel2 + 1)
            {
                tax = 3572 + ((income - taxLevel2) * 0.325);
            }
            else if (income > taxLevel1 +1)
            {
                tax = (income - taxLevel1) * 0.19;
            }
            else
            {
                tax = 0; 
            }  
            tax = tax / 12; 
        }
        public void CalcSuper(double income, double superRate)
        {
            super = (income / 12) * superRate;
        }
        public void CalcGrossPay(double income)
        {
            grossPay = income / 12;
        }
        public void CalcNetPay()
        {
            netPay = grossPay - tax;
        }
        public void InputSalarySuper()
        {
            Console.Write("Please input your annual salary: ");
            //if(double.TryParse(Console.ReadLine(), out var newNum)) // check it is a number
            //{
                income = Convert.ToDouble(Console.ReadLine()); // terminology to determine if a number??
            //}
            //else 
            //{
            //    Console.WriteLine("Sorry, input should be numbers. Please try again");
            //}
            Console.Write("Please input your super rate: ");
            superRate = Convert.ToDouble(Console.ReadLine()) / 100; // make it a percentage
        }
        public void CreatePayslip()
        {
            InputSalarySuper();
        }
        public void PrintDetails()
        {
            CalcGrossPay(income);
            Console.WriteLine("Gross Income: {0:F0}", grossPay);
            CalcTax(income);
            Console.WriteLine("Income tax: {0:F0}",tax);
            CalcNetPay();
            Console.WriteLine("Net Income:{0:F0}", netPay);
            CalcSuper(income, superRate);
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