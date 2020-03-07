using EventsForAll.Data.Models;
using EventsForAll.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Services
{
    public class OrganizersService : IOrganizersService
    {
        public Organizer CreateOrganizer(OrganizerInputModel model)
        {
            var organizer = new Organizer
            {
                 ContactName = model.eventInputModel.
            };
        }
    }
}
