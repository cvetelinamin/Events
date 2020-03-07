using EventsForAll.Data.Models;
using EventsForAll.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Services
{
    public interface IOrganizersService
    {
        Organizer CreateOrganizer(OrganizerInputModel model);
    }
}
