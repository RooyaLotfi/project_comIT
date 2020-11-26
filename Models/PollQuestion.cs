using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class PollQuestion
    {
        public int Id { get; set; }

        public int PollId { get; set; }

        public int QuestionId { get; set; }

        public Poll Poll { get; set; }

        public Question Question { get; set; }
    }
}
