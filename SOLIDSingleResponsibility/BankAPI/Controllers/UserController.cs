using BankAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly UserManager _userManager;
        private readonly AccountManager _accountManager;
        public UserController(UserManager userManager, AccountManager accountManager)
        {
            _userManager = userManager;
            _accountManager = accountManager;
        }
        [HttpPost]
        public IActionResult Create()
        {
            var user = _userManager.CreateUser();
            user.Account = _accountManager.CreateAccount();
            //_eventbusClient.Publish(UserCreatedEvent) For async account Creating
            return Ok(user);
        }
    }
}
