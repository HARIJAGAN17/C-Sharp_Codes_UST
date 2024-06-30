using CarsApiInMemory.Model;

namespace CarsApiInMemory.Repository
{
    public interface ICarRepository
    {
        public Task<IEnumerable<Car>> GetCars();

        public Task<Car> GetCar(int id);

        public Task<bool> AddCar(Car car);

        public Task<bool> UpdateCar(int id,Car car);

        public Task<bool> DeleteCar(int id);
    }
}
