using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingSystem
{
    public class Ticket
    {
        // public properties
        public int Number { get; set; }
        public TimeWindow TimeWindow { get; set; }

        // public method
        public override string ToString() =>
            $"Ticket {Number}: {TimeWindow.StartTime.ToShortTimeString()}";
    }
}
