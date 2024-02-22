using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAfterJava.Exercise3
{
    public class Student : Person
    {
        public int Number { get; set; }

        public override string ToString()
        {
            return $"Student:   {Number}  {base.ToString()};   ";
        }
    }
}
