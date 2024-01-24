using Leave.API.Business.Leave.Models;
using Leave.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace Leave.API.Controllers
{
    [ApiController]
    [Route("api/leave")]
    public class LeaveController : Controller
    {
        private readonly MockDataBase _database;
        public LeaveController()
        {
            _database = new MockDataBase();
        }

        [HttpPost("/annual")]
        public IActionResult CreateAnnualLeave([FromBody] CreateLeaveModel request)
        {
            var user = _database.GetUser(request.PersonId);
            if (user == null) return NotFound();

            var leave = new AnnualLeave()

            return Ok(user);
        }
    }
}
