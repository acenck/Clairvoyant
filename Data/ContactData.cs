using Clairvoyant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.Data
{
    public class ContactData
    {
        static private Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

        //Get all
        public static IEnumerable<Contact> GetAll()
        {
            return Contacts.Values;
        }

        // Add
        public static void Add(Contact newContact)
        {
            Contacts.Add(newContact.Id, newContact);
        }

        //Remove 
        public static void Remove(string id)
        {
            Contacts.Remove(id);
        }

        // Get by ID
        public static Contact GetById(string id)
        {
            return Contacts[id];
        }

    }
}
