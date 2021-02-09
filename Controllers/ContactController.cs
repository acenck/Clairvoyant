using Clairvoyant.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        [Route("Contact/Detail/{contactId}")]
        public IActionResult Detail(int contactId)
        {
            ViewBag.contactToDisplay = ContactData.GetById(contactId);
            ViewBag.contactFullName = $"{ViewBag.contactToDisplay.FirstName} {ViewBag.contactToDisplay.LastName}";
            
            return View();
        }
    }
}
