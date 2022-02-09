using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }
        public string? Way { get; set; }
    }
}
