using CarsApiInMemory.Model;

namespace CarsApiInMemory.Repository
{
    public interface ICarRepository
    {
        public IEnumerable<Car> GetCars();

        public Car GetCar(int id);

        public bool AddCar(Car car);

        public bool UpdateCar(int id,Car car);

        public bool DeleteCar(int id);
    }
}
