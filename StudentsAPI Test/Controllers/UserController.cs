using Microsoft.AspNetCore.Mvc;
using static StudentsAPI_Test.Models.IdentityModels;
using StudentsAPI_Test.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentsAPI_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        //dbContext setup
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: User/GetAll
        [HttpGet]
        [Route("[action]")]
        public List<User> GetAll()
        {
            return _context.User.ToList();
        }

        // POST: User/Insert/UserObj
        [HttpPost]
        [Route("[action]")]
        public IActionResult Insert(User user)
        {
            try
            {
                _context.User.Add(user);
                _context.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, "OK");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.ToString());
            }
        }

        // POST: User/Update/UserObj
        [HttpPut]
        [Route("[action]")]
        public IActionResult Update(User user)
        {
            try
            {
                _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, "OK");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.ToString());
            }
        }

        // POST: User/Delete/Id
        [HttpPost]
        [Route("[action]")]
        public IActionResult Delete(int idUser)
        {
            try
            {
                User? user = _context.User.FirstOrDefault(x => x.Id == idUser);
                if (user == null) return StatusCode(StatusCodes.Status404NotFound);
                user.Status = false;
                _context.Entry(user).State = EntityState.Modified;
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
