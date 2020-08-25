using System;    
using System.Collections.Generic;    
using System.Linq;    
using System.Text;    
using System.Text.RegularExpressions;    
    
namespace RegularExpression1    
{    
    class Program    
    {    
        static void Main(string[] args)    
        {       
            /* Regex nameRegex = new Regex("^[A-Z][a-zA-Z]*$");       
    
            Console.WriteLine("Please enter your name ");
            var value = Console.ReadLine();
            if (nameRegex.Match(value))
            { 
                Console.WriteLine("Your name is {0}", value);
            }    */
            string text = "Name";
      if ( !Regex.Match(text,"^[A-Z][a-zA-Z]*$" ).Success )
      {
         Console.WriteLine( "Invalid last name");
      }
      else 
        Console.WriteLine("Yay!!");
        }    
    }    
}    