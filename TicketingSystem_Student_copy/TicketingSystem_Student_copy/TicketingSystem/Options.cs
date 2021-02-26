using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingSystem
{
    public class Options
    {
        // public properties
        public int MinutesPerWindow { get; set; } 
        public int GuestsPerWindow { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TicketNumber { get; set; }

        // constructor
        public Options()
        {
            // set default values
            MinutesPerWindow = 5;
            GuestsPerWindow = 5;
            StartTime = DateTime.Now;
            EndTime = StartTime.AddHours(4);
            TicketNumber = 1;
        }
    }
}
