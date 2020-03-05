using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Data.Models
{
    public class UserEvent
    {
        [Key]
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [Key]
        public string EventId { get; set; }

        public Event Event { get; set; }

        public int NumberOfGuests { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
