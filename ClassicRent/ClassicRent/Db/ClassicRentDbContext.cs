using ClassicRent.Db.Entity;
using Microsoft.EntityFrameworkCore;

namespace ClassicRent.Db;

public class ClassicRentDbContext:DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<User> Users { get; set; }

    public ClassicRentDbContext(DbContextOptions options) : base(options)
    {
    }
}