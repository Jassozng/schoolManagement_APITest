using Microsoft.AspNetCore.Mvc;
using static StudentsAPI_Test.Models.IdentityModels;
using StudentsAPI_Test.Models;

namespace StudentsAPI_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoordinatorController : Controller
    {
        //dbContext setup
        private readonly ApplicationDbContext _context;
        public CoordinatorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Coordinator/GetAll
        [HttpGet]
        [Route("[action]")]
        public List<Coordinator> GetAll()
        {
            return _context.Coordinator.ToList();
        }

        // POST: Coordinator/Insert/CoordinatorObj
        [HttpPost]
        [Route("[action]")]
        public IActionResult Insert(User user)
        {
            try
            {
                _context.Coordinator.Add(new Coordinator() { User = user, RFC = "" });
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
