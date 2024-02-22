using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.ComponentModel;

namespace CsharpAfterJava.Exercise3
{
    // Exercise 3
    // Create an application to gather contact data for lecturers and students.
    // The students can be grouped in groups.Every group gets a principal lecturer assigned.
    //Lecturers and students have a first name and last name.

    //Students also have a student number and a trajectory.
    //Lecturers have a unique employer id.

    // Exercise 4
    //Continue previous exercise: instantiate some students, lecturers and groups in Main() method.
    //Make sure each group contains some students and gets assigned a principal lecturer.
    //Test your ToString() method for each class by printing sending output to
    //Console.WriteLine() .
    //Implement a class Institute that can contain multiple groups.
    internal class Exercise3
    {
        public static void Run() 
        {

            Console.WriteLine("-----------------exercise 3");
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

            Console.WriteLine(howest.ToString());

        }

    }
}
