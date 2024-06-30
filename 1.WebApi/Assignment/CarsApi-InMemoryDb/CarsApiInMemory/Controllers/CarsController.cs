using CarsApiInMemory.Model;
using CarsApiInMemory.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarsApiInMemory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarRepository _CarRepository;
        public CarsController(ICarRepository carRepository)
        {
            _CarRepository = carRepository;
        }


        [HttpGet]
        public IActionResult GetCars() {
        
            var totalCars = _CarRepository.GetCars();

            if(totalCars.Count()==0)
                return NotFound("No cars in api please add!");

            return Ok(totalCars);

        }

        [HttpGet("{id}")]

        public IActionResult GetCar([FromRoute] int id) {
            
            var carExist = _CarRepository.GetCar(id);
            if (carExist != null)
            {
                return Ok(carExist);
            }
            return NotFound($"Car with id:{id} not exist");
        }

        [HttpPost]

        public IActionResult Addcars([FromBody] Car car) {
        
            var carAdded = _CarRepository.AddCar(car);
            if (carAdded == true)
            {
                return Ok($"carAdded successfully!!");
            }
            return StatusCode(401);
        }

        [HttpPut]

        public IActionResult UpdateCar([FromQuery] int id, [FromBody] Car car)
        {
            var carUpdate = _CarRepository.UpdateCar(id, car);
            if(carUpdate == true)
            {
                return Ok(car);
            }
            return NotFound($"Car with id:{id} not exist");
        }

        [HttpDelete]

        public IActionResult DeleteCar([FromQuery] int id)
        {
            var carDeleted = _CarRepository.DeleteCar(id);

            if (carDeleted == true)
                return Ok($"Car with id:{id} deleted successfully");

            return NotFound($"Car with id:{id} not exist");
        }
    }
}
