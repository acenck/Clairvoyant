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

        [HttpGet]
        [Route("Contacts/Edit/{contactId}")]
        public IActionResult Edit(int contactId)
        {
            ViewBag.contactToEdit = ContactData.GetById(contactId);
            return View();
        }

        [HttpPost]
        [Route("/Contacts/Edit")]
        public IActionResult SubmitEditContactForm(int contactId, string firstname, string lastname, string phone, string email)
        {
            var updated = ContactData.GetById(contactId);

            updated.FirstName = firstname;
            updated.LastName = lastname;
            updated.Phone = phone;
            updated.Email = email;

           return Redirect("~/");
        }

        [HttpGet]
        [Route("Contacts/Delete")]
        public IActionResult Delete(int contactId)
        {
            ContactData.Remove(contactId);

            return Redirect("~/");
        }


    }
}
