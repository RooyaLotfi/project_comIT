using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class PollOption
    {
        public string Id { get; set; }

        public Polling Polling { get; set; }

        public int PollingId { get; set; }

        public List<TimeFrame> TimeFrames { get; set; }

        public List<Vote> Votes { get; set; }

        public List<Event> Events { get; set; }
    }
}
