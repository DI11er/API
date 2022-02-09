using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Interfaces;
using API.Repositories;

namespace API.Controllers
{
    [ApiController]
    [Route("api/Car")]
    public class CarController: ControllerBase
    {
        private CarInterface _CarRepository;
        public CarController(CarInterface CarRepository) { _CarRepository = CarRepository; }

        [HttpGet]
        public IEnumerable<Car> select() => _CarRepository.select();

        [HttpGet("{id}")]
        public Car getbyid(int Id) => _CarRepository.getbyid(Id);

        [HttpPut]
        [Route("update")]
        public void update(int Id, [FromBody] Car car) => _CarRepository.update(car);

        [HttpDelete("{id}")]
        public void delete(int Id) => _CarRepository.delete(Id);


        [HttpPost]
        [Route("insert")]
        public void insert([FromBody] Car car) => _CarRepository.insert(car);
    }
}


