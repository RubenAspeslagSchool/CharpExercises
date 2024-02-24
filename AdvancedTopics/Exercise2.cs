using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using CsharpAfterJava.Exercise3;

namespace AdvancedTopics
{
    // Import the classes from Exercise 4 of exercises-csharp-csharpafterjava
    // and use the collection initializer from the Main method.
    //Now, add Pattern Matching to check the following situations when iterating through the groups
    internal class Exercise2
    {
        Institute howest = new Institute()
        {
            Name = "Howest",
            Groups = new List<StudentGroup>
            {
                new StudentGroup
                {
                    Name = "Software engeneers",
                    Principal = new Lecturer() {EmployerID = 0,  FirstName = "Frederic",  LastName = "Vlummens"},
                    Students = new List<Student>()
                    {
                        new Student() {Number = 0, FirstName = "Ruben", LastName = "Aspeslag"},
                        new Student() {Number = 1, FirstName = "Ruben2", LastName = "Aspeslag"},
                        new Student() {Number = 3, FirstName = "Ruben3", LastName = "Aspeslag"}
                    }
                },
                  new StudentGroup
                {
                    Name = "Cyber Security",
                    Principal = new Lecturer() {EmployerID = 0,  FirstName = "Frederic",  LastName = "Vlummens"},
                    Students = new List<Student>()
                    {
                        new Student() {Number = 0, FirstName = "Yens", LastName = "IDK"},
                        new Student() {Number = 1, FirstName = "Artuur", LastName = "IDK"},
                        new Student() {Number = 3, FirstName = "Joost", LastName = "IDK"}
                    }
                }
            }
        };

        public void Run() 
        {
            // If the teacher is a person
            // and the name of the teacher starts with the letter P:
            // show the name of the group

            Lecturer lecturer = new Lecturer();
            if (lecturer is Person && lecturer.FirstName.StartsWith("P"))
            {
                
            }


            // If there are any students in the group:
            // show the name of the group and the amount of students within that group

            // If there are more than 2 students in the group '2TI': show the name of the group and teacher
        }



    }
}
