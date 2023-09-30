using ClassicRent.Db;
using ClassicRent.Db.Entity;
using ClassicRent.Db.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ClassicRent.Controllers;

[ApiController]
[Route("[controller]")]
public class CarController:ControllerBase
{
    private CarRepository carRepo;

    public CarController(CarRepository carRepo)
    {
        this.carRepo = carRepo;
    }

    [HttpGet("All")]
    public async Task<ActionResult> AllAsync()
    {
        return Ok(await carRepo.GetAllAsync());
    }

    [HttpGet("GetById")]
    public async Task<ActionResult> GetByIdAsync(int id)
    {
        return Ok(await carRepo.GetByIdAsync(id));
    }

    [HttpDelete("Delete")]
    public async Task<ActionResult> DeleteAsync(int id)
    {
        await carRepo.DeleteByIdAsync(id);
        return Ok();
    }

    [HttpPost("Add")]
    public async Task<ActionResult> AddAsync(Car c)
    {
        await carRepo.AddCarAsync(c);
        return Ok();
    }

    [HttpPut("ChangeDamage")]
    public async Task<ActionResult> ChangeDamageAsync(int id, string damage)
    {
        await carRepo.ChangeDamageAsync(id, damage);
        return Ok();
    }

    [HttpPut("ExtendReviewDate")]
    public async Task<ActionResult> ExtendReviewDateAsync(int id)
    {
        await carRepo.ExtendReviewDate(id);
        return Ok();
    }
}