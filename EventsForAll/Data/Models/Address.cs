using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Data.Models
{
    public class Address : BaseModel<string>
    {
        [Required]
        public string CityId { get; set; }

        public City City { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public string Building { get; set; }

        [Required]
        public string Entrance { get; set; }

        [Required]
        public string Floor { get; set; }

        [Required]
        public string Apartment { get; set; }

        [Required]
        public string District { get; set; }

        [Required]
        public string OrganizerId { get; set; }

        public Organizer Organizer { get; set; }
    }
}
