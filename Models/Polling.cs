using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class Polling
    {
        public int Id { get; set; }

        public PollOption PollOption { get; set; }

        public int PollOptionId { get; set; }

        public List<Vote> Votes { get; set; }

        public Event Event { get; set; }

        public int EventId { get; set; }
    }
}
