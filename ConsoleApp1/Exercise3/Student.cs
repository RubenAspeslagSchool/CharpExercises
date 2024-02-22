using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAfterJava.Exercise3
{
    internal class Student
    {
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"Student:   {Number}  {FirstName}   {LastName};   ";
        }
    }
}
