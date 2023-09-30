using System.ComponentModel.DataAnnotations;

namespace ClassicRent.Db.Entity;

public class User
{
    [Key]
    public int Id { get; set; }
    public bool IsEmployee { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
    public string Mail { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
}