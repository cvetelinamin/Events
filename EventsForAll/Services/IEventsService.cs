using EventsForAll.Data.Models;
using EventsForAll.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Services
{
    public interface IEventsService
    {
        Event CreateEvent(CreateEventInputModel model, string userId);
    }
}
