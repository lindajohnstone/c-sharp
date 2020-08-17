Payslip Problem

** highest priority == calculations
	** tax 1st priority (can use test details to check it works)
	** use a switch
	** super, gross pay, net pay when tax complete
** user input next priority
** formatting and writing to console
** validation

== logic ==
** tax - rounded
== retrieve income from (initially gross income from test case) user input
== switch case
	== case (income < 18200): tax = 0
	== case (income < 18201): tax = (income - 18200) * 0.19 (19c in dollars)
	== case (income < 37001): tax = 3572 + ((income - 37000) * 0.32)
	== case (income < 87001): tax = 19822 + ((income - 87000) * 0.37)
	== case (income < 180001): tax = 54232 + ((income - 180000) * 0.45))
== use const?? - const taxLevel5 = 180000
== display tax on console
** super == gross income * super rate % (eg 9% rate == gross income * 0.09)
** net income == gross income - tax

UPDATE 6/8:
** switch does not work
** need annual income to determine tax (using static def)
** monthly tax = annual tax / 12
** tax calculating correctly
** super - calculate grossPay by dividing income by 12
** super calculating correctly
** calculate netPay == grossPay - tax
** netPay working correctly
** logic to receive input from user (income and super atm)
== user asked to input data
== data received
== income added to income variable
== super added to income variable
== need to replace numbers into grossPay and super calculations
?? How to validate correct input - double
====== improvements 6/8 ==
** const - eg line 31 Payslip.cs
** double not used for money - use decimal (done 7/8)
** 12 months - change to const months - not in Payslip class - const (Constants) class (done 7/8)
** tests TDD - new project
** reference PayslipProblem project

HOW TO CREATE TEST PROJECT using vscode
** make a new directory mkdir <dir-name> using .tests as part
** type 'dotnet new xunit' (type of test required)
** 'dotnet add reference <other project folder>.csproj
** 'dotnet build' - in other project folder, links files
** 'dotnet test'
** [Fact]
** [Theory] - inline data  

https://myobconfluence.atlassian.net/wiki/spaces/PRAC/pages/1464731694/16th+July+2020+-+A+Practical+Introduction+to+TDD

====== improvements 7/8 ==
** methods more specific names - eg CalcGrossPay changed to CalculateAnnualIncomeToGrossMonthlyIncome (begun 7/8)
** added Constants.cs
** create Person.cs - move class from Program.cs
** Validations class?? (Last thing)
	** decimals - Decimal.TryParse(value, out number)(??)
	** strings -
		decimal number3 = 0;
		numString = "27.3"; //"27" is also a valid decimal
		canConvert = decimal.TryParse(numString, out number3);
		if (canConvert == true)
  			Console.WriteLine("number3 now = {0}", number3);
		else
  			Console.WriteLine("number3 is not a valid decimal");
** format correctly
** tax calculation using arrays or lists?

====== improvements 10/8 ==
** rest of method names changed to more specific names
** payment dates added
** how to format date so that single digit becomes 2 digits??
	** use substring to isolate number??
	** if number.length == 1, make it 2 digits ** works
	** can dates be called??
** validate date so that full name not abbreviation of month returned
** tax calculation - base[n], threshold[n], rate[n], percentage[n]
	** use indexof. (How??) 

====== improvements 11.8 ==
** tax calculation
	** indexof did not work
	** tried foreach loop - error: Unhandled exception. 					System.IndexOutOfRangeException: Index was outside the bounds of the array.
	** for loop worked
	** old code:
		if (income > taxThreshold[3])
            	{
                	tax = baseTax[3] + ((income - (taxThreshold[3])) * taxRate[3]);
            	}
            	else if (income > taxThreshold[2])
            	{
               		tax = baseTax[2] + ((income - (taxThreshold[2])) * taxRate[2]);
            	}
            	else if (income > taxThreshold[1])
            	{
               		tax = baseTax[1] + ((income - (taxThreshold[1])) * taxRate[1]);
            	}
            	else if (income > taxThreshold[0])
            	{
               		tax = baseTax[0] + ((income - (taxThreshold[0])) * taxRate[0]);
            	}
            	else
            	{
                	tax = 0; 
            	}
	** new code:
	for (int num = 0; num < taxThreshold.Length; num++)
            { 
                if (income > taxThreshold[num])
                {
                    tax = baseTax[num] + ((income - (taxThreshold[num])) * taxRate[num]);
                }
            }
** errors 
	** thrown if date entered as only one substring. Need to validate so exception does not happen
	** income, super need to be a number - now working - instead of same code both methods - already tried - error CS0029: Cannot implicitly convert type 'void' to 'decimal'
	** name, surname not numbers??
** formatting still required:
	** name, surname, month(??) ToTitleCase (first letter capitalised)
	** date format as day (2 digits), month in letters
** income, super as numbers - now fixed (during mentor session)
** created TaxableIncomeTax class - now foreach loop works
====== other info ==
** static class does not need to be instantiated (don't need to use keyword 'new')
====== homework ==
** sort array: write code - which class is responsible
** how to stop foreach loop when info found - not 'break'
** ask 3 questions each day
====== 12/8 ==
** sorting an array - Array.Sort() - requires two values, 1st array value, 2nd comparable (can't be same - throws error)
** stop foreach when value is reached - tax != 0 creates an error


Module 1: 24th Aug
Module 2a: 27th Aug
Module 2b: 3rd Sep
Module 3: 9th Sep
=======
====== latest 12/8 ==
** used orderby to organise (sort) tax threshold, base, rate objects
** updated orderby to orderbydescending to ensure that the code runs quicker - calculation only performed once
** make sure that I understand what is required
** validations still required
====== 13/8 thoughts + extras ==
** payslip calculations class?? == NO
** methods involving calculation:
	** CalculateTax
	** CalculateSuper
	** CalculateGrossPay
	** CalculateNetPay
** validation / formatting class??
** method involving (or will involve) validation / formatting 
	** ReadUserInputAsDecimal - income and super are decimals
	** name and surname to be valid input - no numbers, just letters, spaces (for  and some special characters (as in O'Brien, and '-' for hyphenated names) ?? Need to go this far??
	** format date so that output == (decimal)(decimal)(space)(fullMonthName) e.g. 01 March
====== Update 14/8 ==
** date now formatting correctly
	** (1st) startDate = Convert.ToString(dateValue); // writes date as 01/03/2020 00:00:00
	** (2nd) date = String.Format("{0:dd MMMM, yyyy}", dateValue); // writes date as dd MonthName, year
            }
** method added to ensure date is on correct format:
	** originally in both methods:
		* if (DateTime.TryParse(Console.ReadLine(), out var dateValue))
            	{
                	//startDate = Convert.ToString(dateValue); writes date as 01/03/2020 00:00:00
            	    	startDate = String.Format("{0:dd MMMM}", dateValue);
            	}
            	else 
            	{
                	Console.Write("Please try again. ");
                	StartDate();
            	}
	** separate method (modified)
		** string date = String.Empty;
            	   if (DateTime.TryParse(Console.ReadLine(), out var dateValue))
            	   {
                	date = String.Format("{0:dd MMMM, yyyy}", dateValue);
            	   }
            	   else 
            	   {
                	Console.Write("Please try again. ");
                	date = DateFormat();
            	   }
            	   return date;


