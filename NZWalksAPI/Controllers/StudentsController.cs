using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: https://localhost:portnumber/api/Students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] StudentNames = new string[] { "John", "Merry", "Jessy", "Walter", "Gustavo" };
            return Ok(StudentNames);
        }
    }
}
