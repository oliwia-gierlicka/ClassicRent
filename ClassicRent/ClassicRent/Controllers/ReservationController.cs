using ClassicRent.Models;
using ClassicRent.Service.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClassicRent.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class ReservationController:ControllerBase
{
    private readonly IReservationService _reservationService;
    private readonly IUserProvider _userProvider;

    public ReservationController(IReservationService reservationService, IUserProvider userProvider)
    {
        _reservationService = reservationService;
        _userProvider = userProvider;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var userId = _userProvider.GetUserId();
        return Ok(_reservationService.Get(userId));
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var userId = _userProvider.GetUserId();
        await _reservationService.Delete(id, userId);
        return Ok();
    }
    
    [HttpPost]
    public async Task<ActionResult> Post(ReservationForm form)
    {
        var userId = _userProvider.GetUserId();
        await _reservationService.CreateReservation(form, userId);
        return Ok();
    }
}