using ClassicRent.Db.Entity;

namespace ClassicRent.Service.Abstract;

public interface ICarService
{
    IEnumerable<Car> GetAll();
}