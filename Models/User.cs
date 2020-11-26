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

        public List<Event> Events { get; set; }

        public List<Response> Responses { get; set; }

        public string Email { get; set; }

    }
}
