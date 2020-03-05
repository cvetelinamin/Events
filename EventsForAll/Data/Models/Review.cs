using EventsForAll.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Data.Models
{
    public class Review : BaseModel<string>
    {
        [Required]
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [Range(0,5)]
        public int Rating { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string Comment { get; set; }

        [Required]
        public string EventId { get; set; }

        public Event Event { get; set; }
    }
}
