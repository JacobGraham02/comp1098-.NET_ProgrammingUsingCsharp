using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TicketingSystem
{
    public class Tickets
    {
        /* private fields */
        private int nextAvailTimeWindowIndex;          // Index of next available time window
        private int currentTimeWindowIndex;            // Index of the current time window

        private List<TimeWindow> timeWindows;
        private Queue<Ticket> ticketQueue;

        /* public properties */
        public Options Options { get; set; }   
        public int Count => ticketQueue.Count;
        public DateTime NextAvailableStartTime => timeWindows[nextAvailTimeWindowIndex].StartTime;
        public bool IsOpen =>
            DateTime.Now > Options.StartTime 
            && DateTime.Now < Options.EndTime.AddMinutes(Options.MinutesPerWindow);
        public bool HasMoreTimeWindows => nextAvailTimeWindowIndex < timeWindows.Count;
        public bool IsLastTimeSlot => currentTimeWindowIndex == timeWindows.Count;
        public bool IsSoldOut => nextAvailTimeWindowIndex + 1 == timeWindows.Count;

        /* public methods */
        public void Start(Options options)
        {
            Options = options;
            currentTimeWindowIndex = 0;
            nextAvailTimeWindowIndex = 0;
            ticketQueue = new Queue<Ticket>();
            timeWindows = new List<TimeWindow>();

            // load time windows
            DateTime windowStart = Options.StartTime.AddMinutes(Options.MinutesPerWindow);
            while (windowStart < Options.EndTime.AddMinutes(Options.MinutesPerWindow))
            {
                timeWindows.Add(new TimeWindow(windowStart, Options.MinutesPerWindow, options.GuestsPerWindow));
                windowStart = windowStart.AddMinutes(Options.MinutesPerWindow);
            }
            // Adjust start time to start time of first ticket window
            Options.StartTime = (timeWindows[0]).StartTime;  
        }

        public Ticket Add()
        {
            Ticket newTicket = new Ticket
            {
                TimeWindow = timeWindows[nextAvailTimeWindowIndex],
                Number = Options.TicketNumber++
            };
            newTicket.TimeWindow.GuestsAssigned++;

            ticketQueue.Enqueue(newTicket);

            return newTicket;
        }

        public void MoveToNextTimeWindow() => nextAvailTimeWindowIndex++;

        public bool IsNewTimeWindowStarted()
        {
            bool newTimeWindowStarted = false;
            if (currentTimeWindowIndex < timeWindows.Count)
            {
                if (DateTime.Now.ToShortTimeString() == (timeWindows[currentTimeWindowIndex]).StartTime.ToShortTimeString())
                {
                    newTimeWindowStarted = true;
                    currentTimeWindowIndex++;
                }
            }
            return newTimeWindowStarted;
        }

        public string UpdateTicketList(ListBox.ObjectCollection items)
        {
            int firstTicket = 0;
            bool firstTicketFound = false;
            int lastTicket = 0;
            
            // Examine the queue to determine which tickets are for the
            // current time slot. All tickets for the current time slot
            // are removed from the queue and the firstTicket and lastTicket
            // fields are set to the first and last ticket numbers.
            //
            while (ticketQueue.Count >= 1)
            {
                Ticket ticket = ticketQueue.Peek();
                if (ticket.TimeWindow.StartTime < DateTime.Now)
                {
                    ticketQueue.Dequeue();
                    if (!firstTicketFound)
                    {
                        firstTicket = ticket.Number;
                        firstTicketFound = true;
                    }
                    lastTicket = ticket.Number;
                    items.RemoveAt(0);
                }
                else
                    break;
            }
            
            // Return message that indicates which ticket numbers may now enter.
            //
            if (!firstTicketFound)                 //No tickets currently served
            {
                return "";
            }
            else
            {
                if (firstTicket == lastTicket)     //One ticket currently served
                {
                    return firstTicket.ToString();
                }
                else                               //More than one ticket currently served
                {
                    return firstTicket.ToString() + " - " + lastTicket.ToString();
                }
            }
        }

    }
}
