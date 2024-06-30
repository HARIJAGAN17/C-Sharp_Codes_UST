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
        public async Task<IActionResult> GetCars() {
        
            var totalCars = await _CarRepository.GetCars();

            if(totalCars==null)
                return NotFound("No cars in api please add!");

            return Ok(totalCars);

        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetCar([FromRoute] int id) {
            
            var carExist =  await _CarRepository.GetCar(id);
            if (carExist != null)
            {
                return Ok(carExist);
            }
            return NotFound($"Car with id:{id} not exist");
        }

        [HttpPost]

        public async Task<IActionResult> Addcars([FromBody] Car car) {
        
            var carAdded = await _CarRepository.AddCar(car);
            if (carAdded == true)
            {
                return Ok($"carAdded successfully!!");
            }
            return StatusCode(401);
        }

        [HttpPut]

        public async Task<IActionResult> UpdateCar([FromQuery] int id, [FromBody] Car car)
        {
            var carUpdate = await _CarRepository.UpdateCar(id, car);
            if(carUpdate == true)
            {
                return Ok(car);
            }
            return NotFound($"Car with id:{id} not exist");
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteCar([FromQuery] int id)
        {
            var carDeleted = await _CarRepository.DeleteCar(id);

            if (carDeleted == true)
                return Ok($"Car with id:{id} deleted successfully");

            return NotFound($"Car with id:{id} not exist");
        }
    }
}
