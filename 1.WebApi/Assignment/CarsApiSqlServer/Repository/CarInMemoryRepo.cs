using CarsApiInMemory.Database;
using CarsApiInMemory.Model;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace CarsApiInMemory.Repository
{
    public class CarInMemoryRepo : ICarRepository
    {
        CarDbContext _CarDbcontext;
        public CarInMemoryRepo(CarDbContext carDbContext)
        {
            _CarDbcontext = carDbContext;
        }
        public async Task<bool> AddCar(Car car)
        {
           var carAdded = _CarDbcontext.carsDatabase.Add(car);
            await _CarDbcontext.SaveChangesAsync();
            if(carAdded != null)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteCar(int id)
        {
            var carExist = await _CarDbcontext.carsDatabase.FirstOrDefaultAsync(x => x.Id == id);
            if (carExist!=null)
            {
                _CarDbcontext.carsDatabase.Remove(carExist);
                await _CarDbcontext.SaveChangesAsync();
                return true;
            }
            return false;

        }

        public async Task<Car> GetCar(int id)
        {
            return await _CarDbcontext.carsDatabase.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Car>> GetCars()
        {
            return await _CarDbcontext.carsDatabase.ToListAsync();
        }

        public async Task<bool> UpdateCar(int id, Car car)
        {
            var carExist = await _CarDbcontext.carsDatabase.FirstOrDefaultAsync(x => x.Id == id);
            if (carExist != null)
            {
                carExist.Price = car.Price;
                carExist.Category = car.Category;
                carExist.Price = car.Price;
                await _CarDbcontext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
