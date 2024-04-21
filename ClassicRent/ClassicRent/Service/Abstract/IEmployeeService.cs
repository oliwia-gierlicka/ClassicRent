using ClassicRent.Db.Entity;
using ClassicRent.Models;

namespace ClassicRent.Service.Abstract;

public interface IEmployeeService
{
    Task Decide(ReservationConfirm c);
    IEnumerable<Reservation> GetReservations(int employeeId);
}