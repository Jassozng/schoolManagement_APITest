using Microsoft.AspNetCore.Mvc;
using static StudentsAPI_Test.Models.IdentityModels;
using StudentsAPI_Test.Models;

namespace StudentsAPI_Test.Controllers
{
    public class TeacherController : Controller
    {
        //dbContext setup
        private readonly ApplicationDbContext _context;
        public TeacherController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Teacher/GetAll
        [HttpGet]
        [Route("[action]")]
        public List<Teacher> GetAll()
        {
            return _context.Teacher.ToList();
        }

        // POST: Teacher/Insert/TeacherObj
        [HttpPost]
        [Route("[action]")]
        public IActionResult Insert(User user)
        {
            try
            {
                _context.Teacher.Add(new Teacher() { User = user, RFC = "" });
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
