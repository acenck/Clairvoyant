using Clairvoyant.Data;
using Clairvoyant.Models;
using Clairvoyant.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.Controllers
{
    public class HomeController : Controller
    {
     

        private readonly ContactService _contactService;

        public HomeController(ContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public ActionResult<List<Contact>> Get() =>
            _contactService.Get();

        public IActionResult Index()
        {
           
            var contacts = _contactService.Get();

            ViewBag.contactCount = _contactService.Count();

            contacts.Sort((x, y) => string.Compare(x.LastName, y.LastName)); 

            return View(contacts);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
