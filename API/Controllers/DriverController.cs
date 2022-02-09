using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Interfaces;
using API.Repositories;

namespace API.Controllers
{
    [ApiController]
    [Route("api/Driver")]
    public class DriverController: ControllerBase
    {
        private DriverInterface _DriverRepository;
        public DriverController(DriverInterface DriverRepository) { _DriverRepository = DriverRepository; }

        [HttpGet]
        public IEnumerable<Driver> select() => _DriverRepository.select();

        [HttpGet("{id}")]
        public Driver getbyid(int Id) => _DriverRepository.getbyid(Id);

        [HttpPut]
        [Route("update")]
        public void update(int Id, [FromBody] Driver driver) => _DriverRepository.update(driver);

        [HttpDelete("{id}")]
        public void delete(int Id) => _DriverRepository.delete(Id);


        [HttpPost]
        [Route("insert")]
        public void insert([FromBody] Driver driver) => _DriverRepository.insert(driver);
    }
}
