using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.Models
{
    
    public class Event
    {

        

        [BsonElement(elementName:"Name")]
        public string Name { get; set; }
        [BsonElement(elementName: "Date")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date { get; set; }

        [BsonElement(elementName: "Message")]
        public string Message { get; set; }




        public Event()
        {

        }

        public Event(string name, DateTime date, string message)
        {
            Name = name;
            Date = date;
            Message = message;
        }

    }
}
