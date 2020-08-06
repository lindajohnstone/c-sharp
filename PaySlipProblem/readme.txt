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
** double not used for money - use decimal 
** 12 months - change to const months - not in Payslip class - const (Constants) class
** tests TDD - new project
** reference PayslipProblem project
I
HOW TO CREATE TEST PROJECT using vscode
** make a new directory mkdir <dir-name> using .tests as part
** type 'dotnet new xunit' (type of test required)
** 'dotnet add reference <other project folder>.csproj
** 'dotnet build' - in other project folder, links files
** 'dotnet test'
** [Fact]
** [Theory] - inline data  



