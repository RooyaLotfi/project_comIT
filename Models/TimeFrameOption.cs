using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    class TimeFrameOption
    {
        public int Id { get; set; }

        public DateTime StartFrame { get; set; }

        public DateTime EndFrame { get; set; }
    }
}
