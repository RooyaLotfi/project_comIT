using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class EntityBase
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedDatetime { get; set; }

        public string? UpdatedBy { get; set; }

        public DateTime? UpdateDatetime { get; set; }
    }
}
