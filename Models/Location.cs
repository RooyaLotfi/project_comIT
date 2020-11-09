using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class Location : EntityBase
    {
        public string Id { get; set; }

        public string Name { get; set; }

        //Nullable should not be used for properties with type of objects/classes
        public Vote? Vote { get; set; }

        //Nullable should not be used for properties with type of string
        public string? VoteId { get; set; }

    }
}
