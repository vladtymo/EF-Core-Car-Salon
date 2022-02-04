using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_Salon
{
    public class Country
    {
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Name { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
