using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentsAPI_Test.Models;
using static StudentsAPI_Test.Models.IdentityModels;

namespace StudentsAPI_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {

        //dbContext setup
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Student/GetAll
        [HttpGet]
        [Route("[action]")]
        public List<Student> GetAll()
        {
            return _context.Student.ToList();
        }

        // POST: Student/Insert/StudentObj
        [HttpPost]
        [Route("[action]")]
        public IActionResult Insert(User user)
        {
            try
            {
                _context.Student.Add(new Student(){ User = user, SchoolarID = ""});
                _context.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, "OK");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.ToString());
            }
        }
    }
}
