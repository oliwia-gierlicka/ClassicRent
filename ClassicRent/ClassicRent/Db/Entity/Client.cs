using System.ComponentModel.DataAnnotations;

namespace ClassicRent.Db.Entity;

public class Client
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Pesel { get; set; }
    public string DrivingLicenceNumber { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string HouseNumber { get; set; }
    public string ApartmentNumber { get; set; }
    public DateTime DrivingLicenceFrom { get; set; }
    public DateTime DateOfBirth { get; set; } 
}