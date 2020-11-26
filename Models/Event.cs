using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    public enum EventStatus: byte
    {
        InPoll,
        Submitted,
        Decided,
        Cancelled 
    }
    class Event : EntityBase
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public User Creator { get; set; }

        public int CreatorId { get; set; }

        //public PollResult PollResult { get; set; }

        //public int? PollResultId { get; set; }

        public EventStatus Status { get; set; }

        public DateTime EventDateTime{ get; set; }

        public Poll Poll { get; set; }

        public Event()
        {
            Status = EventStatus.InPoll;
        }

    }
}
