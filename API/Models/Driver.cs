using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
    }
}
