using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsForAll.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return this.View();
        }
    }
}
