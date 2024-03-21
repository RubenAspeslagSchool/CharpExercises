using ClassLib.Reposetorys;
using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private StudentRepository _studentRepository;
        public StudentController() 
        {
            _studentRepository = new StudentRepository();
        }

        [HttpGet(Name = "GetStudent")]
        public IEnumerable<Student> GetStudents()
        {
            return new StudentRepository().GetAllStudents();
        }
    }
}
