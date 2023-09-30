using System.ComponentModel.DataAnnotations;
using ClassicRent.Models.Enum;

namespace ClassicRent.Db.Entity;

public class Reservation
{
    [Key]
    public int Id { get; set; }
    public int CarId { get; set; }
    public int ClientId { get; set; }
    public int EmployeeId { get; set; }
    public ReservationStatus Status { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public string RentPlace { get; set; }
    public string ReturnPlace { get; set; }
    public bool IsFullAssurance { get; set; }
    public PaymentMethod Pay { get; set; }
    public decimal Price { get; set; }
}