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

        public List<UserEvent> UserEvents { get; set; }

        public PollResult? PollResult { get; set; }

        public int? PollResultId { get; set; }

        public EventStatus Status { get; set; }


        public Event()
        {
            Status = EventStatus.InPoll;
        }

    }
}
