using System.ComponentModel.DataAnnotations;

namespace EF_Core_Salon
{
    public class Car
    {
        public int Id { get; set; }
        [Required, MaxLength(250)]
        public string Model { get; set; }
        public int Year { get; set; }
        public Category Category { get; set; }
        public Country Country { get; set; }
    }
}
