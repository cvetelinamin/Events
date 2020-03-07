using EventsForAll.Data.Models;
using EventsForAll.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Services
{
    public class EventService : IEventsService
    {

        public Event CreateEvent(CreateEventInputModel model, string userId)
        {
            var eventToCreate = new Event
            {
                Title = model.eventInputModel.Title,
                Performer = model.eventInputModel.Performer,
                DoorTime = model.eventInputModel.DoorTime,
                EndTime = model.eventInputModel.EndTime,
                Duration = model.eventInputModel.Duration,
                Description = model.eventInputModel.Description,
                EventSchedule = model.eventInputModel.EventSchedule,
                MaximumAttendeeCapacity = model.eventInputModel.MaximumAttendeeCapacity,
                IsAccessibleForFree = model.eventInputModel.IsAccessibleForFree,
                Price = model.eventInputModel.Price,
                CreatorId = userId,
                 
            };

            return eventToCreate;
        }
    }
}
