using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingSystem
{
    public class TimeWindow
    {
        // private field
        private int maxGuests { get; set; }

        // public properties
        public DateTime StartTime { get; set; }
        public int Interval { get; set; }
        public int GuestsAssigned { get; set; }
        public bool IsFull => maxGuests == GuestsAssigned;

        // constructor
        public TimeWindow(DateTime startTime, int interval, int guestsPerWindow)
        {
            maxGuests = guestsPerWindow;
            StartTime = startTime;
            Interval = interval;
            GuestsAssigned = 0;
        }
    }
}
