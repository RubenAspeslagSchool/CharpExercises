using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAfterJava.Exercise3
{
    internal class Institute
    {
        public string Name { get; set; }
        public List<StudentGroup> Groups { get; set; }

        public override string ToString() 
        {
            string insteture = $"------ Institut {Name}";
            Groups.ForEach(group =>
            {
                insteture = $"{insteture} \n {group.ToString()}";
            });
            return insteture;

        }
    }
}
