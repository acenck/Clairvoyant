using Clairvoyant.Models;
using LinqKit;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.Services
{
    public class ContactService
    {
        private static IMongoCollection<Contact> _contacts;

        private static IMongoCollection<User> _users;

        public ContactService(IClairvoyantDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _contacts = database.GetCollection<Contact>(settings.ContactsCollectionName);
            _users = database.GetCollection<User>(settings.UsersCollectionName);
        }

        public List<Contact> Get() =>
            _contacts.Find(contact => true).ToList();

        public Contact Get(string id) =>
            _contacts.Find<Contact>(contact => contact.Id == id).FirstOrDefault();

        public Contact Create(Contact contact)
        {
            _contacts.InsertOne(contact);
            return contact;
        }

        public void Update(Contact contactIn) =>
            _contacts.ReplaceOne(contact => contact.Id == contactIn.Id, contactIn);

        public void Remove(Contact contactIn) =>
            _contacts.DeleteOne(contact => contact.Id == contactIn.Id);

        public void Remove(string id) =>
            _contacts.DeleteOne(contact => contact.Id == id);

       public List<Contact> SearchByName(string keyword)
       {
            var words = keyword.Split(" ");
            var combinedWords = string.Join("", words);
            
            var filter = Builders<Contact>.Filter.Or(
                Builders<Contact>.Filter.Where(contact => contact.FirstName.ToLower().Contains(keyword.ToLower())),
                Builders<Contact>.Filter.Where(contact => contact.LastName.ToLower().Contains(keyword.ToLower())),
                Builders<Contact>.Filter.Where(contact => contact.FullName.ToLower().Contains(combinedWords.ToLower()))
                );

            var filteredcontacts = _contacts.Find(filter).ToList();

            return filteredcontacts;
        }






            
            


        public int Count() =>
            (int)_contacts.CountDocuments(new BsonDocument());


        

      














    }
}
