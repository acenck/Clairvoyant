using Clairvoyant.Data;
using Clairvoyant.Models;
using Clairvoyant.Services;
using Clairvoyant.ViewModels;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
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
            
            AddContactViewModel addContactViewModel = new AddContactViewModel();
            

            return View(addContactViewModel);
        }

        [HttpPost]
        [Route("Contacts/Add")]
        public ActionResult Add(AddContactViewModel addContactViewModel)
        {
            if (ModelState.IsValid)
            {

                

                Contact newContact = new Contact
                {
                    FirstName = addContactViewModel.FirstName,
                    LastName = addContactViewModel.LastName,
                    Phone = addContactViewModel.Phone,
                    Email = addContactViewModel.Email,
                    FullName = $"{addContactViewModel.FirstName} {addContactViewModel.LastName }",
                    EventType = new Event
                    {
                        Name = addContactViewModel.EventType.Name,
                        Date = addContactViewModel.EventType.Date,
                        Message = addContactViewModel.EventType.Message

                    }
                };
                  
                _contactService.Create(newContact);

                return Redirect("~/");

            };

            return View(addContactViewModel);
 
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



     

















