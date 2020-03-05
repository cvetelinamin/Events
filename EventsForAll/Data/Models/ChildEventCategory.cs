using EventsForAll.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Data.Models
{
    public class ChildEventCategory : BaseModel<string>
    {
        public ChildEventCategory()
        {
            this.Events = new HashSet<Event>();
        }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public string EventCategoryId { get; set; }

        public EventCategory EventCategory { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
