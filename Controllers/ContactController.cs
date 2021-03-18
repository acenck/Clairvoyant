using Clairvoyant.Data;
using Clairvoyant.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactService _contactService;

        public ContactController(ContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        [Route("Contact/Detail/{contactId}")]
        public IActionResult Detail(string contactId)
        {
            ViewBag.contactToDisplay = _contactService.Get(contactId);
            ViewBag.contactFullName = $"{ViewBag.contactToDisplay.FirstName} {ViewBag.contactToDisplay.LastName}";
            var contactSelected = _contactService.Get(contactId);

            return View(contactSelected);
        }
    }
}
