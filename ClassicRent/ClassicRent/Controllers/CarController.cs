using ClassicRent.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ClassicRent.Controllers;

[ApiController]
[Route("[controller]")]
public class CarController:ControllerBase
{
    private readonly ICarService _carService;

    public CarController(ICarService carService)
    {
        _carService = carService;
    }

    [HttpGet("All")]
    public ActionResult AllAsync()
    {
        return Ok(_carService.GetAll());
    }
}