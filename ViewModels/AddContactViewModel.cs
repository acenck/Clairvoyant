using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.ViewModels
{
    public class AddContactViewModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        
        public string Phone { get; set; }
        
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
