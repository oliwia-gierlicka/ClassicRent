using System.ComponentModel.DataAnnotations;

namespace ClassicRent.Db.Entity;

public class Schedule
{
    [Key]
    public int Id { get; set; }
    public int ReservationId { get; set; }
    public int CarId { get; set; }
    public int ClientId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
}