using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class Response : EntityBase
    {
        public int Id { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        //public PollResult PollResult { get; set; }

        public int PollId { get; set; }

        public Poll Poll { get; set; }

        public DateTime VotingDatetime{ get; set; }

        public Question Question { get; set; }

        public int QuestionId { get; set; }

    }
}

