﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class PollResult : EntityBase
    {
        public int Id { get; set; }

        public List<Response> Votes { get; set; }

        public Event Event { get; set; }

        public int EventId { get; set; }
    }
}
