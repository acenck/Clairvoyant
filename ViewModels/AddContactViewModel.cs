using Clairvoyant.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.ViewModels
{
    public class AddContactViewModel
    {
        public string Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        public DateTime DateCreated { get; set; }

        public Event EventType { get; set; }

        public string FullName {get; set;}


        public AddContactViewModel()
        {

        }

        

        
    }
}
