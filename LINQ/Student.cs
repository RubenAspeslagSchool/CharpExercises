using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public override string ToString ()
        {
            return $"id: {Id}, firstname: {FirstName}, lastname {LastName}, age: {Age}, sex {Sex}";
        }
    }
}
