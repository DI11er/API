using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Interfaces;
using API.Repositories;

namespace API.Controllers
{
    [ApiController]
    [Route("api/LogDeparture")]
    public class LogDepartureController: ControllerBase
    {
        private LogDepartureInterface _LogDepartureRepository;
        public LogDepartureController(LogDepartureInterface LogDepartureRepository) { _LogDepartureRepository = LogDepartureRepository; }

        [HttpGet]
        public IEnumerable<LogDeparture> select() => _LogDepartureRepository.select();

        [HttpGet("{id}")]
        public LogDeparture getbyid(int Id) => _LogDepartureRepository.getbyid(Id);

        [HttpPut]
        [Route("update")]
        public void update(int Id, [FromBody] LogDeparture logDeparture) => _LogDepartureRepository.update(logDeparture);

        [HttpDelete("{id}")]
        public void delete(int Id) => _LogDepartureRepository.delete(Id);

        [HttpPost]
        [Route("insert")]
        public void insert([FromBody] LogDeparture logDeparture) => _LogDepartureRepository.insert(logDeparture);
    }
}
