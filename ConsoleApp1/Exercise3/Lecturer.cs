﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAfterJava.Exercise3
{
    public class Lecturer : Person
    {
        public int EmployerID { get; set; }
        

        public override string ToString()
        {
            return $" {EmployerID}  {base.ToString()};   ";
        }
    }
}
