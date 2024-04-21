using ClassicRent.Db;
using ClassicRent.Db.Entity;
using ClassicRent.Models;
using ClassicRent.Service.Abstract;

namespace ClassicRent.Service.Implementation;

public class EmployeeService : IEmployeeService
{
    private readonly ClassicRentDbContext _dbContext;

    public EmployeeService(ClassicRentDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Decide(ReservationConfirm c)
    {
        var r = _dbContext.Reservations.FirstOrDefault(x => x.Id == c.Id);
        
        if (r is not null)
        {
            r.Status = c.Status;
            _dbContext.Reservations.Update(r);
            await _dbContext.SaveChangesAsync();
        }
    }

    public IEnumerable<Reservation> GetReservations(int employeeId)
    {
        return _dbContext.Reservations.Where(x => x.EmployeeId == employeeId);
    }
}