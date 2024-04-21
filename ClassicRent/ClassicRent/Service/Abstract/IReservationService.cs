using ClassicRent.Db.Entity;
using ClassicRent.Models;

namespace ClassicRent.Service.Abstract;

public interface IReservationService
{
    Task Delete(int id, int userId);
    IEnumerable<Reservation> Get(int userId);
    Task CreateReservation(ReservationForm form, int userId);
}