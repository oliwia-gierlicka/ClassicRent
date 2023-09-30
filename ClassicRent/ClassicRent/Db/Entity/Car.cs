using System.ComponentModel.DataAnnotations;
using ClassicRent.Models.Enum;

namespace ClassicRent.Db.Entity;

public class Car
{
    [Key]
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public CarType Type { get; set; }
    public CarClass Class { get; set; }
    public string Color { get; set; }
    public int SeatCount { get; set; }
    public int Year { get; set; }
    public int Mileage { get; set; }
    public bool IsManual { get; set; }
    public bool IsDiesel { get; set; }
    public string PlateNumber { get; set; }
    public DateTime ReviewDate { get; set; }
    public string Damage { get; set; }
    public bool IsABS { get; set; }
    public bool IsESP { get; set; }
    public bool IsASR { get; set; }
    public string Image { get; set; }
    public decimal PricePerDay { get; set; }
}