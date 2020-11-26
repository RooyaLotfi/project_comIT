using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class Poll
    {
        public int Id { get; set; }

        public int EventId { get; set; }

        public Event Event { get; set; }

        public List<Response> Responses { get; set; }

        public List<PollQuestion> PollQuestions { get; set; }
    }
}
