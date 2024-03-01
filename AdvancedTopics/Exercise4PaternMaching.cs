using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdvancedTopics
{
    public class Exercise4PaternMaching
    {
        // Let's extend exercise 1b.
        // We will evaluate the input from the command line a little bit more in detail:

        // If the input is a string then check if it is a palindrome
        // If the input is a number then check whether this is an even or odd number.
        
        // If the input is a boolean than show a random true/false statement (for example: 67 is an even  number).
       // Tip: use a Tuple definition for storing these statements.

        public  (bool result, string statment) Run(string inputTXT) 
        {

            return inputTXT switch
            {
                string input when int.TryParse(input, out int number) => IsOdd(number),
                string input when bool.TryParse(input, out bool isTrue) => getStatment(isTrue),
                string input => IsPalingdrome(input),
                _ => (false, $"not a reconized type ")
            };

            
           
        }

        private (bool result,string statment) getStatment(bool input)
        {
            return input ? (true, "66 is an even number")
                : (false, "67 is an even number");
        }

        private (bool  result, string statment) IsOdd(int input)
        {
            return input % 2 == 0
                ? (false, $"{input} is a even number")
                : (true, $"{input} is an odd number");
        }
        private static (bool result, string statment) IsPalingdrome(string input)
        {
            return (input.Reverse().ToString() == input)
                ? (true, $"{input} is a palingdrome")
                : (false, $"{input} is not a palingdrome");

        }
    }
}
