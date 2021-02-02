using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int Id { get; }
        static private int nextId = 1;

        public Contact()
        {
            Id = nextId;
            nextId++;
        }

        public Contact(string firstname, string lastname, string phone, string email) : this()
        {
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            return obj is Contact contact &&
                   Id == contact.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
