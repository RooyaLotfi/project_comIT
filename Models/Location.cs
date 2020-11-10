using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class Location : EntityBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Vote Vote { get; set; }

        public int VoteId { get; set; }

    }
}
