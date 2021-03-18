using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.ViewModels
{
    public class AddEventViewModel
    {
        public string id { get; set; }

        public string EventType { get; set; }

        public DateTime Date { get; set; }

        public string Message { get; set; }

    }
}
