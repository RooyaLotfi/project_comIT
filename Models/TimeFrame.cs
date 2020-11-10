using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class TimeFrame : EntityBase
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Vote Vote { get; set; }

        public int VoteId { get; set; }

    }
}
