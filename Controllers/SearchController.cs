using Clairvoyant.Models;
using Clairvoyant.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.Controllers
{
    public class SearchController : Controller
    {

        private readonly ContactService _contactService;

        public SearchController(ContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index(List<Contact> filterBySearch)
        {
            var contacts = filterBySearch;

            ViewBag.searchCount = contacts.Count;

            contacts.Sort((x, y) => string.Compare(x.LastName, y.LastName));

            return View(contacts);

        }


        public IActionResult SearchResult(string search)
        {
            List<Contact> allContacts;
            List<Contact> filteredContacts = new List<Contact>();

            if (string.IsNullOrEmpty(search))
            {
                allContacts = _contactService.Get();

                foreach (var contact in allContacts)
                {
                    filteredContacts.Add(contact);
                }
            }
            else
            {
                allContacts = _contactService.SearchByName(search);

                foreach (var contact in allContacts)
                {
                    filteredContacts.Add(contact);
                }
                    
            }

            filteredContacts.Sort((x, y) => string.Compare(x.LastName, y.LastName));

            return View("Index", filteredContacts);
        }
           
        
          


            



            


       
            
                
    }
}
