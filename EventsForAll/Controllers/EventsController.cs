using EventsForAll.Data;
using EventsForAll.Data.Models;
using EventsForAll.Services;
using EventsForAll.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EventsForAll.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IEventsService eventsService;
        private readonly IOrganizersService organizersService;
        private readonly UserManager<ApplicationUser> userManager;

        public EventsController(ApplicationDbContext dbContext, IEventsService eventsService, IOrganizersService organizersService,UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.eventsService = eventsService;
            this.organizersService = organizersService;
            this.userManager = userManager;
        }
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(CreateEventInputModel model, OrganizerInputModel modelOrganizer)
        {
            var user = this.userManager.GetUserId(this.User);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var inputEvent = this.eventsService.CreateEvent(model, user);
            var organizer = this.organizersService.CreateOrganizer(modelOrganizer);

            return this.View();
        }
    }
}
