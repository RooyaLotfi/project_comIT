using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class Vote : EntityBase
    {
        public string Id { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public PollResult Poll { get; set; }

        public int PollId { get; set; }

        public List<TimeFrame>? TimeFrames { get; set; }

        public List<Location>? Places { get; set; }

    }
}
