using ClassicRent.Db.Entity;
using Microsoft.EntityFrameworkCore;

namespace ClassicRent.Db.Repository;

public class CarRepository
{
    private ClassicRentDbContext carRepo;
    
    public CarRepository(ClassicRentDbContext carRepo)
    {
        this.carRepo = carRepo;
    }

    public async Task<List<Car>> GetAllAsync()
    {
        return await carRepo.Cars.ToListAsync();
    }

    public async Task<Car> GetByIdAsync(int id)
    {
        return await carRepo.Cars.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task DeleteByIdAsync(int id)
    {
        Car c = await GetByIdAsync(id);
        carRepo.Cars.Remove(c);
        await carRepo.SaveChangesAsync();
    }

    public async Task AddCarAsync(Car c)
    {
        carRepo.Cars.Add(c);
        await carRepo.SaveChangesAsync();
    }

    public async Task ChangeDamageAsync(int id, string damage)
    {
        Car c = await GetByIdAsync(id);
        c.Damage = damage;
        carRepo.Cars.Update(c);
        await carRepo.SaveChangesAsync();
    }

    public async Task ExtendReviewDate(int id)
    {
        Car c = await GetByIdAsync(id);
        c.ReviewDate = c.ReviewDate.AddYears(1);
        carRepo.Cars.Update(c);
        await carRepo.SaveChangesAsync();
    }

}