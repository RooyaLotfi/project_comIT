using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class Vote
    {
        public string Id { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public Polling Poll { get; set; }

        public int PollId { get; set; }

        public List<PollOption> Options { get; set; }

    }
}
