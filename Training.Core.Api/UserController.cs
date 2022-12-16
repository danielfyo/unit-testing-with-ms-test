using Training.Core.Users;
using Microsoft.AspNetCore.Mvc;

namespace Training.Core.Api;

public class UserController : Controller
{
    private readonly IUserService _userService;
    
    public UserController(IUserService userService) => _userService = userService;

    // GET
    [HttpPost]
    public IActionResult CreateUser(UserDto user)
    {
        _userService.CreateUser(user);
        return Ok();
    }
}