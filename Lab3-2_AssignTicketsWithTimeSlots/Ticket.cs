using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2_AssignTicketsWithTimeSlots
{
    class Ticket
    {
        private int ticketNumber;
        private string ticketTime;

        public Ticket()
        {

        }
        public Ticket(int ticketNum, string ticketTme)
        {
            this.TicketNumber = ticketNum;
            this.TicketTime = ticketTme;
        }

        public int TicketNumber
        {
            get { return ticketNumber; }
            set { ticketNumber = value; }
        }

        public string TicketTime
        {
            get { return ticketTime; }
            set { ticketTime = value; }
        }
    }
}
