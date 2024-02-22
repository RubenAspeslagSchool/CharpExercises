using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Warmup
    {

        public int Run(string givvenString)
        {
            // Given: the string sequence "10,5,0,8,10,1,4,0,10,1".
            //        Task: make a LinQ expression, to calculate the sum of all numbers in the sequence
            //          "10,5,0,8,10,1,4,0,10,1", with the exception of the lowest 3 values.Doubles are not taken into account.

            return givvenString
                .Split(',')
                .Select(int.Parse)
                .Distinct()
                .OrderBy(n => n)  // orderBy and skip are to Exclude the lowest 3 numbers
                .Skip(3)
                .Sum();

        }

    }
}
