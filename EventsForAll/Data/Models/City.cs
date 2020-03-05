using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Data.Models
{
    public class City : BaseModel<string>
    {
        public City()
        {
            this.Addresses = new HashSet<Address>();
        }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public string CountryId { get; set; }

        public Country Country { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
