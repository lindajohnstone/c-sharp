using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PaySlipProblem
{
    class Person
    {
        /* private NameValidations _nameValidations;

        public Person(NameValidations nameValidations)
        {
            _nameValidations = nameValidations;
        } */

        public string Name { get; set; }
        public string Surname { get; set; }
        
        //public Payslip EmployeeData { get; set; } // link person class to payslip class
        public void GetPersonNameSurname()
        {
            Console.Write("Please input your name: ");
            Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            // bool  validName = _nameValidations.ValidateName(Name);
            Console.Write("Please input your surname: ");
            Surname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
        }

        public void PrintPerson()
        {
            Console.WriteLine("{0} {1}", Name, Surname);
        }
    
        //public void GetPersonPayslip
    }
}