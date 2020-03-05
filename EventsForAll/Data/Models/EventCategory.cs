using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Data.Models
{
    public class EventCategory : BaseModel<string>
    {
        public EventCategory()
        {
            this.ChildCategories = new HashSet<ChildEventCategory>();
        }


        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public ICollection<ChildEventCategory> ChildCategories { get; set; }
    }
}
