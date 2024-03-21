using ClassLib.Models;

namespace ClassLib.Reposetorys
{
    public interface IStudentRepository
    {
        int AddStudent(string name, bool succeded);
        bool DeleteStudent(int id);
        IEnumerable<Student> GetAllStudents();
        Student GetRandom(int random);
        Student GetStudentById(int id);
        void PutStudent(int id, string name, bool succeded);
    }
}