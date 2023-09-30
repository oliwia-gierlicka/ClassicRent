using System.ComponentModel.DataAnnotations;

namespace ClassicRent.Db.Entity;

public class Employee
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Location { get; set; }
}