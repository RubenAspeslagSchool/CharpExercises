using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAfterJava.Exercise3
{
    public class StudentGroup
    {
        public string Name { get; set; }
        public Lecturer Principal { get; set; }
        public List<Student> Students { get; set; }

        public override string ToString() 
        {
            string group = $"group {Name}:     principal: {Principal.ToString()}";
            
            Students.ForEach(student =>
            {
                group = $" {group} :    {student.ToString()}";
            });
            return group;
        }
    }
}
