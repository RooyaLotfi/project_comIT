using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class Vote
    {
        public string Id { get; set; }

        public List<User> User { get; set; }

        public TimeFrameOption TimeFrameOptions { get; set; }

    }
}
