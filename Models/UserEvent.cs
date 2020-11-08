using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class UserEvent
    {
        public int? EventId { get; set; }
        
        public List<Event> Events { get; set; }

        public int UserId { get; set; }

        public List<User> Users { get; set; }
    }
}
