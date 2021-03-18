using Clairvoyant.Models;
using MongoDB.Driver;
using LinqKit;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.Services
{
    public class UserService
    {
        

        private static IMongoCollection<User> _users;

        public UserService(IClairvoyantDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            
            _users = database.GetCollection<User>(settings.UsersCollectionName);
        }

        public List<User> Get() =>
            _users.Find(contact => true).ToList();

        public User Get(string id) =>
            _users.Find<User>(contact => contact.Id == id).FirstOrDefault();

        public User Create(User contact)
        {
            _users.InsertOne(contact);
            return contact;
        }

        public void Update(User contactIn) =>
            _users.ReplaceOne(contact => contact.Id == contactIn.Id, contactIn);

        public void Remove(User contactIn) =>
            _users.DeleteOne(contact => contact.Id == contactIn.Id);

        public void Remove(string id) =>
            _users.DeleteOne(contact => contact.Id == id);
    }
}
