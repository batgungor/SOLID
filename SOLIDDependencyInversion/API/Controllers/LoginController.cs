using API.Business;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly TokenManager _tokenManager;
        public LoginController(UserService userService, TokenManager tokenManager)
        {
            _userService = userService;
            _tokenManager = tokenManager;
        }

        [HttpGet]
        public IActionResult Login([FromQuery] string userName, [FromQuery] string password)
        {
            //var _userService = new UserService();
            var user = _userService.CheckUserLogin(userName, password);

            //var _tokenManager = new TokenManager();
            var token = _tokenManager.GetToken(user);
            return Ok(token);
        }
    }
}
