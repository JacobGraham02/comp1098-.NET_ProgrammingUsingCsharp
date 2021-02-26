using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketingSystem
{
    public partial class frmTicketing : Form
    {
        public frmTicketing()
        {
            InitializeComponent();
        }

        private Tickets tickets = new Tickets();

        private void frmTicketing_Load(object sender, System.EventArgs e)
        {
            SetOptions();
        }

        private void btnOptions_Click(object sender, System.EventArgs e)
        {
            string msg = "This action will delete all outstanding tickets. "
                + "Are you sure you want to continue?";
            DialogResult response = MessageBox.Show(msg, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
            {
                SetOptions();
            }
                
        }

        private void SetOptions()
        {
            secondTimer.Enabled = false;

            frmOptions optionsForm = new frmOptions();
            if (optionsForm.ShowDialog() == DialogResult.OK)
            {
                secondTimer.Enabled = true;
                tickets.Start(optionsForm.Options);

                UpdateDisplay();

                lstTickets.Items.Clear();
                btnTicket.Enabled = true;
            }
        }

        private void UpdateDisplay()
        {
            lblOutstanding.Text = tickets.Count.ToString();
            if (btnTicket.Enabled)
            {
                if (tickets.HasMoreTimeWindows)
                {
                    lblNextEntry.Text = tickets.NextAvailableStartTime.ToShortTimeString();
                }
            }
        }

        private void btnTicket_Click(object sender, System.EventArgs e)
        {
            Ticket newTicket = tickets.Add();

            if (newTicket.TimeWindow.IsFull)
            {
                if (tickets.IsSoldOut)
                {
                    btnTicket.Enabled = false;
                    lblNextEntry.Text = "Sold out.";
                }
                else
                {
                    tickets.MoveToNextTimeWindow();
                }
            }
            UpdateDisplay();

            lstTickets.Items.Add(newTicket);
        }

        private void secondTimer_Tick(object sender, System.EventArgs e)
        {
            // Update the time display in the title bar
            this.Text = DateTime.Now.ToLongTimeString();
            if (tickets.IsOpen)
            {
                this.Text += " (Open)";
            }
            else
            {
                this.Text += " (Closed)";
                lblNowServing.Text = "";
            }

            // Execute only at one-minute increments.
            if (DateTime.Now.Second == 0)
            {
                // Determine if a new time window as been reached 
                bool newTimeWindowStarted = tickets.IsNewTimeWindowStarted();

                // Disable the ticket button when the last time slot begins.
                if (newTimeWindowStarted && tickets.IsLastTimeSlot)
                {
                    btnTicket.Enabled = false;
                    lblNextEntry.Text = "Closed.";
                }

                if (newTimeWindowStarted)
                {
                    // Update the ticket list and Now Serving label
                    lblNowServing.Text = tickets.UpdateTicketList(lstTickets.Items);
                    
                    //Move to next time window if next available time window is == current window
                    //to prevent selling a ticket for the current time window.
                    if (lblNextEntry.Text == DateTime.Now.ToShortTimeString())
                    {
                        tickets.MoveToNextTimeWindow();
                    }
                    UpdateDisplay();
                }
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
