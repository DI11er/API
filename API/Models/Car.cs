using System.ComponentModel.DataAnnotations;


namespace API.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? MaxWeight { get; set; }
    }
}
 