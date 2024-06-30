using CarsApiInMemory.Database;
using CarsApiInMemory.Model;

namespace CarsApiInMemory.Repository
{
    public class CarInMemoryRepo : ICarRepository
    {
        CarDbContext _CarDbcontext;
        public CarInMemoryRepo(CarDbContext carDbContext)
        {
            _CarDbcontext = carDbContext;
        }
        public bool AddCar(Car car)
        {
           var carAdded =_CarDbcontext.carsDatabase.Add(car);
            _CarDbcontext.SaveChanges();
            if(carAdded != null)
            {
                return true;
            }
            return false;
        }

        public bool DeleteCar(int id)
        {
            var carExist = _CarDbcontext.carsDatabase.FirstOrDefault(x => x.Id == id);
            if (carExist!=null)
            {
                _CarDbcontext.carsDatabase.Remove(carExist);
                _CarDbcontext.SaveChanges();
                return true;
            }
            return false;

        }

        public Car GetCar(int id)
        {
            var carExist = _CarDbcontext.carsDatabase.FirstOrDefault(x => x.Id == id);
            if (carExist != null)
            {

                return carExist;
            }
            return null;
        }

        public IEnumerable<Car> GetCars()
        {
            return _CarDbcontext.carsDatabase;
        }

        public bool UpdateCar(int id, Car car)
        {
            var carExist = _CarDbcontext.carsDatabase.FirstOrDefault(x => x.Id == id);
            if (carExist != null)
            {
                carExist.Price = car.Price;
                carExist.Category = car.Category;
                carExist.Price = car.Price;
                _CarDbcontext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
