using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class User
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<UserEvent> UserEvents { get; set; }

        public List<Vote> Vote { get; set; }

    }
}
