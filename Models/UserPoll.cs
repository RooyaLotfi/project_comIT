using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class UserPoll
    {
        public int Id { get; set; }

        public List<User> Users { get; set; }

        public List<Poll> Polls { get; set; }
    }
}
