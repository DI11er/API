using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class LogDeparture
    {
        [Key]
        public int Id { get; set; }
        public int IdCar { get; set; }
        public int IdDriver { get; set; }
        public int IdFlight { get; set; }
        public DateTime DepartureTimeDate { get; set; }
        public string? ProductName { get; set; }
        public string? ProductValume { get; set; }
    }
}
