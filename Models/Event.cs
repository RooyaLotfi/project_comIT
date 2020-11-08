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

        public string Type { get; set; }

        public List<UserEvent> UserEvents { get; set; }

        public Polling Poll { get; set; }

        public int? PollId { get; set; }

        public TimeFrame TimeFrame { get; set; }

        public int TimeFrameId { get; set; }

        public EventStatus Status { get; set; }

        public Event()
        {
            Status = EventStatus.InPoll;
        }

    }
}
