using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.ViewModels
{
    public class EventInputModel
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Performer { get; set; }

        public DateTime DoorTime { get; set; }

        public int Duration { get; set; }

        public DateTime EndTime { get; set; }

        [Required]
        [MaxLength(1000)]
        public string EventSchedule { get; set; }

        public string Status { get; set; }

        public bool IsAccessibleForFree { get; set; }

        public int MaximumAttendeeCapacity { get; set; }

        public decimal Price { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        public string AgeRange { get; set; }
    }
}
