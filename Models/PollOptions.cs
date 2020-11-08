using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class PollOptions : EntityBase
    {
        public string Id { get; set; }

        public Event Event { get; set; }

        public string EventId { get; set;}

        public List<TimeFrame> TimeFrames { get; set; }

        public List<Place> Places { get; set; }

    }
}
