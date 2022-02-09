using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Interfaces;
using API.Repositories;

namespace API.Controllers
{
    [ApiController]
    [Route("api/Flight")]
    public class FlightController: ControllerBase
    {
        private FlightInterface _FlightRepository;
        public FlightController(FlightInterface FlightRepository) { _FlightRepository = FlightRepository; }

        [HttpGet]
        public IEnumerable<Flight> select() => _FlightRepository.select();

        [HttpGet("{id}")]
        public Flight getbyid(int Id) => _FlightRepository.getbyid(Id);

        [HttpPut]
        [Route("update")]
        public void update(int Id, [FromBody] Flight flight) => _FlightRepository.update(flight);

        [HttpDelete("{id}")]
        public void delete(int Id) => _FlightRepository.delete(Id);

        [HttpPost]
        [Route("insert")]
        public void insert([FromBody] Flight flight) => _FlightRepository.insert(flight);
    }
}
