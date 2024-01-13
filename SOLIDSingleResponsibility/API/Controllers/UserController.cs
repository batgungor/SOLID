using Application;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly UserService _userService;
        private readonly OrderService _orderService;
        public UserController(UserService userService, OrderService orderService)
        {
            _userService = userService;
            _orderService = orderService;
        }
        [HttpGet("{userId}/orders")]
        public IActionResult Orders([FromRoute] string userId)
        {
            var user = _userService.GetUser(userId);
            var orders = _orderService.GetOrders(user);
            return Ok(orders);
        }
    }
}
