using ClassicRent.Models;
using ClassicRent.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ClassicRent.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController:ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<ActionResult> Post(RegisterForm form)
    {
        if (await _userService.Register(form))
            return BadRequest();
        return Ok();
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginForm form)
    {
        var token = await _userService.Login(form);
        return token is not null
            ? Ok(token)
            : BadRequest();
    }
}