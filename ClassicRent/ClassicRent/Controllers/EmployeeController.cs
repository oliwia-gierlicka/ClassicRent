using ClassicRent.Models;
using ClassicRent.Service.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClassicRent.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class EmployeeController:ControllerBase
{
    private readonly IEmployeeService _employeeService;
    private readonly IUserProvider _userProvider;

    public EmployeeController(IEmployeeService employeeService, IUserProvider userProvider)
    {
        _employeeService = employeeService;
        _userProvider = userProvider;
    }

    [HttpGet("reservations")]
    public ActionResult Get()
    {
        var id = _userProvider.GetUserId();
        return Ok(_employeeService.GetReservations(id));
    }
    
    [HttpPost("reservation")]
    public async Task<ActionResult> Post(ReservationConfirm c)
    {
        await _employeeService.Decide(c);
        return Ok();
    }
}