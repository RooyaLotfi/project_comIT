using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class User : EntityBase
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<UserEvent> UserEvents { get; set; }

        public List<Vote> Vote { get; set; }

        public string Email { get; set; }

    }
}
