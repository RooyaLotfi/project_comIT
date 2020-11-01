using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class Poll
    {
        public int Id { get; set; }

        public List<UserPoll> UserPolls { get; set; }
        
        public Event Event { get; set; }

        public Dictionary<TimeFrame, int> PollResult { get; set; }

    }
}
