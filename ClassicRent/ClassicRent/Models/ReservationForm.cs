using ClassicRent.Models.Enum;

namespace ClassicRent.Models;

public class ReservationForm
{
    public int CarId { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public string RentPlace { get; set; }
    public string ReturnPlace { get; set; }
    public bool IsFullAssurance { get; set; }
    public PaymentMethod Pay { get; set; }
    public decimal Price { get; set; }
}