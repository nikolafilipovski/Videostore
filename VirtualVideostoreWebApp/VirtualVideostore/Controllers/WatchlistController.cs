using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualVideostore.Controllers
{
    public class WatchlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
