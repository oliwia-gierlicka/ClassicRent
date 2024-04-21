using System.Collections;
using ClassicRent.Db;
using ClassicRent.Db.Entity;
using ClassicRent.Models;
using ClassicRent.Models.Enum;
using ClassicRent.Service.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ClassicRent.Service.Implementation;

public class ReservationService : IReservationService
{
    private readonly ClassicRentDbContext _dbContext;

    public ReservationService(ClassicRentDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task CreateReservation(ReservationForm form, int userId)
    {
        var rand = new Random();

        var employeeIndex = rand.Next(await _dbContext.Users.Where(x => x.IsEmployee).CountAsync());

        _dbContext.Reservations.Add(new Reservation
        {
            CarId = form.CarId,
            ClientId = userId,
            EmployeeId = (await _dbContext.Users.Where(x => x.IsEmployee).ToListAsync())[employeeIndex].Id,
            Status = ReservationStatus.Created,
            From = form.From,
            To = form.To,
            RentPlace = form.RentPlace,
            ReturnPlace = form.ReturnPlace,
            IsFullAssurance = form.IsFullAssurance,
            Pay = form.Pay,
            Price = form.Price
        });
        await _dbContext.SaveChangesAsync();
    }

    public IEnumerable<Reservation> Get(int userId)
    {
        return _dbContext.Reservations.Where(x => x.ClientId == userId);
    }

    public async Task Delete(int id, int userId)
    {
        var r = await _dbContext.Reservations.FirstOrDefaultAsync(x => x.Id == id && x.ClientId == userId);
        _dbContext.Reservations.Remove(r);
        await _dbContext.SaveChangesAsync();
    }
}