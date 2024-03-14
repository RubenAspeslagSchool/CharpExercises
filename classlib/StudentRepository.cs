using ClassLib.Models;
using System.ComponentModel.DataAnnotations;

namespace ClassLib
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _allStudents;


        public StudentRepository()
        {
            _allStudents = new List<Student>()
            {
                new Student {Id = 0, Name ="Mieke", Succeeded = true},
                new Student { Id = 1, Name = "Ruben", Succeeded = true }
            };

        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _allStudents;
        }

        public Student GetStudentById(int id)
        {
            return _allStudents.SingleOrDefault(x => x.Id == id);
        }

        public int AddStudent(string name, bool succeded)
        {
            Student newStudent = new Student { Id = _allStudents.Count(), Name = name, Succeeded = succeded };
            _allStudents = _allStudents.Append(newStudent).ToList();
            return newStudent.Id;
        }

        public void PutStudent(int id, string name, bool succeded)
        {
            _allStudents[id] = new Student { Id = id, Name = name, Succeeded = succeded };
        }

        public bool DeleteStudent(int id)
        {
            return _allStudents.Remove(GetStudentById(id));
        }

        public Student GetRandom(int random)
        {
            int max = _allStudents.Count < random
                ? _allStudents.Count
                : random;
            Random? rand = new System.Random();
            return _allStudents[rand.Next(0, max)];
        }
    }
}
