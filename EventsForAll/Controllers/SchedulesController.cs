﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Controllers
{
    public class SchedulesController : Controller
    {
        public IActionResult Schedule()
        {
            return View();
        }
    }
}
