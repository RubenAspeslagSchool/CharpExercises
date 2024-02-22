
using LINQ;
using System.Xml.Linq;

namespace LINQ
{
    internal class Exercises2CustomClass
    {
        public List<Student> students = new List<Student> {
            new Student { Id= 1, FirstName = "Freddie", LastName = "Fish", Age = 18 , Sex = "M"},
            new Student { Id= 2, FirstName = "Bill", LastName = "Jones", Age = 21, Sex = "M" },
            new Student { Id = 3, FirstName = "Kitty", LastName = "Cat", Age = 19, Sex = "F" },
            new Student { Id = 4, FirstName = "Suzy", LastName = "Wan", Age = 20, Sex = "F" }
        };

        internal void Run()
        {
            Console.WriteLine("-------------------- Exercises 2: custom class ------------");

            //1- students where the first and last name start with the same character
            Console.WriteLine("1- students where the first and last name start with the same character");
            StudentsWhereFirstAndLastNameStartWithSameCharacter().ForEach(student => Console.WriteLine(student.ToString));

            Console.WriteLine($"2- the average age of female students {avgFemale()}" );
            Console.WriteLine($"3- The student with the highest score is {largestCode().ToString()}, and its code is {computeCode(largestCode())}");
        }

        private List<Student> StudentsWhereFirstAndLastNameStartWithSameCharacter()
        {
            return students
                .Where(student => student.FirstName[0] == student.LastName[0])
                .ToList();
        }

        private double avgFemale()
        {
            return students
                .Where(student => student.Sex == "F")
                .Average(student => student.Age);
        }


        private Student largestCode()
        {
           return students
                .OrderByDescending(student => computeCode(student))
                .First();       
         }
        
        private double computeCode(Student student)
        {
            return Math.Pow(student.Id, 2);
        }
    }

    
}
