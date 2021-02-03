using Clairvoyant.Data;
using Clairvoyant.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("Contacts/Add")]
        public IActionResult NewContact(Contact newContact)
        {
            ContactData.Add(newContact);


            return Redirect("~/"); 
        }


    }
}
