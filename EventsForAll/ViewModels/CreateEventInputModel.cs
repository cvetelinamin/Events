using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.ViewModels
{
    public class CreateEventInputModel
    {
        public EventInputModel eventInputModel { get; set; }

        public OrganizerInputModel organizerInputModel { get; set; }

        public AdressInputModel adressInputModel { get; set; }
    }
}
