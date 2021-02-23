using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Clairvoyant.Models
{
    public class Contact
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("FirstName")]
        [JsonProperty("Name")]
        public string FirstName { get; set; }
        [BsonElement("LastName")]
        public string LastName { get; set; }
        [BsonElement("Phone")]
        public string Phone { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Date")]
        [BsonDateTimeOptions]
        public DateTime DateCreated { get; set; } = DateTime.Now;


        
/*
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
        }*/
    }
}
