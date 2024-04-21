using ClassicRent.Models.Enum;

namespace ClassicRent.Models;

public class ReservationConfirm
{
    public int Id { get; set; }
    public ReservationStatus Status { get; set; }
}