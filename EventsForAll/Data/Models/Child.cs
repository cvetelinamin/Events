﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Data.Models
{
    public class Child : BaseModel<string>
    {
        public int? Age { get; set; }

        public Gender? Gender { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
