using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Children = new HashSet<Child>();
            this.UserEvents = new HashSet<UserEvent>();
        }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        [Required]
        [MaxLength(30)]
        public string City { get; set; }

        public bool HaveChildren { get; set; }

        public ICollection<Child> Children { get; set; }

        public ICollection<UserEvent> UserEvents { get; set; }
    }
}
