Variables - format - camelcase, start with lowercase or uppercase letters?

Change string to int? - error CS1503: Argument 1: cannot convert from 'string' to 'int' 
** Convert.ToInt32(value) - causes euro
** Used int.Parse(value);

Round numbers
** int.Parse(Console.ReadLine(());
** tried Math.Round - many errors!
** Program.cs(52,34): error CS0121: The call is ambiguous between the following methods or properties: 'Math.Round(decimal, int)' and 'Math.Round(double, int)' [/Users/Linda.Johnstone/Documents/fma/c-sharp/magicYrCalc/magicYrCalc.csproj]
	Did not call Math.Round correctly 
** Program.cs(54,31): error CS1503: Argument 1: cannot convert from 'method group' to 'bool' [/Users/Linda.Johnstone/Documents/fma/c-sharp/		magicYrCalc/magicYrCalc.csproj]
	?? Don't know why

Frustrating not knowing the correct terminology and not understanding
it all.


Possible additions:
** error handling - either try/catch or if statements to notify of issue and ask user to input specific information
** Math.Round instead of int.Parse
** Uppercase first letter of name and surname if user did not input it.

UPDATE 
** successfully used Convert.ToInt32(Console.ReadLine()); - string to int to be able to be used as an integer
** (Thanks to Simon) successfully rounded the number (code follows):
	
	static void mthlySalary(int num)
        {
            var mthSalary = num / 12m; // passing number is int, is changed to decimal
            Console.Write("Monthly Salary: ");
            Console.WriteLine("{0:F0}",mthSalary); // diff bw Math.round == create number 		w/o decimal; {0:F0} == display original value w/o decimal
        } 

UPDATE AGAIN

** successfully used two classes instead of static class. YAY!


