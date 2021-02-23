using Clairvoyant.Data;
using Clairvoyant.Models;
using Clairvoyant.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.Controllers
{

    public class ContactsController : Controller
    {
        private readonly ContactService _contactService;

        public ContactsController(ContactService contactService)
        {
            _contactService = contactService;
        }

        

        [HttpGet]
        [Route("Contacts/Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("Contacts/Add")]
        public ActionResult Add(Contact contact)
        {
 
            _contactService.Create(contact);

            return Redirect("~/");
        }

           



        [HttpGet]
        [Route("Contacts/Edit/{contactId}")]
        public IActionResult Edit(string contactId)
        {
            var contactSelected = _contactService.Get(contactId);

            return View(contactSelected);
        }

        
        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            
            _contactService.Update(contact);

            return Redirect("~/");
        }

        [HttpGet]
        [Route("Contacts/Delete")]
        public IActionResult Delete(string contactId)
        {
            _contactService.Remove(contactId);

            return Redirect("~/");
        }
    }
}

     

















