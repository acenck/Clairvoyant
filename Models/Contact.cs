using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Clairvoyant.Models
{
    [BsonIgnoreExtraElements]
    public class Contact
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("FirstName")]
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }
        [BsonElement("LastName")]
        public string LastName { get; set; }
        [BsonElement("Phone")]
        public string Phone { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Date")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [BsonElement("Event")]
        public Event EventType { get; set; }

        private string fullname;


        [BsonElement("FullName")]
        public string FullName
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = FirstName + LastName;
            }
        }






        public Contact()
        {
            
        }

        public Contact(string firstname, string lastname, string phone, string email, Event eventtype)
    {
        FirstName = firstname;
        LastName = lastname;
        Phone = phone;
        Email = email;
        EventType = eventtype;
            

            
           
          

    }

    /*        public override bool Equals(object obj)
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
