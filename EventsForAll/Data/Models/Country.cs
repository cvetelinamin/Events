using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Data.Models
{
    public class Country : BaseModel<string>
    {
        public Country()
        {
            this.Cities = new HashSet<City>();
        }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
