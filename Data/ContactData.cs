using Clairvoyant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.Data
{
    public class ContactData
    {
        static private Dictionary<int, Contact> Contacts = new Dictionary<int, Contact>();

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
        public static void Remove(int id)
        {
            Contacts.Remove(id);
        }

        // Get by ID
        public static Contact GetById(int id)
        {
            return Contacts[id];
        }

    }
}
