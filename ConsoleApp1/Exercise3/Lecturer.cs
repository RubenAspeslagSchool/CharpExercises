﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAfterJava.Exercise3
{
    internal class Lecturer
    {
        public int EmployerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $" {EmployerID}  {FirstName} {LastName};   ";
        }
    }
}
