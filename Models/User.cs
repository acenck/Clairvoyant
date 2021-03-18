using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime Date { get; } = DateTime.Now;

       /* public User()
        {

        }

        public User(string username, string email, string password, DateTime date)
        {
            Username = username;
            Email = email;
            Password = password;
            Date = date;
        }*/
    }
}
