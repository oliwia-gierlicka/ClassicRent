using ClassicRent.Db;
using ClassicRent.Db.Entity;
using ClassicRent.Service.Abstract;

namespace ClassicRent.Service.Implementation;

public class CarService : ICarService
{
    private readonly ClassicRentDbContext _dbContext;

    public CarService(ClassicRentDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Car> GetAll()
    {
        return _dbContext.Cars;
    }
}