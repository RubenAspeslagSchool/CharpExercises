using ClassLib.Models;

namespace ClassLib
{
    public class StudentRepository
    {
        private IEnumerable<Student> _allStudents;


        public StudentRepository() 
        {
            _allStudents = new List<Student>();
            _allStudents.Append(new Student {Id = 1, Name ="Mieke", Succeeded = true});
            _allStudents.Append(new Student { Id = 2, Name = "Ruben", Succeeded = true });
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _allStudents;
        }

        public Student GetStudentById(int id)
        {
            return _allStudents.SingleOrDefault(x => x.Id == id);
        }
    }
}
