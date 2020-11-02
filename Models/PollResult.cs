using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class PollResult
    {
        public int Id { get; set; }
        
        public Event Event { get; set; }

        public TimeFrameOption TimeFrame { get; set; }

        public List<Vote> Votes { get; set; }

    }
}
