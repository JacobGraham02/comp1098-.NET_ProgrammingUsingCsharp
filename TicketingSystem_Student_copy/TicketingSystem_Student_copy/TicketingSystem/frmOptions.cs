using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketingSystem
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        public Options Options { get; set; }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            Options = new Options();
            txtMinutesPerWindow.Text = Options.MinutesPerWindow.ToString();
            txtGuestsPerWindow.Text = Options.GuestsPerWindow.ToString();
            txtStartTime.Text = Options.StartTime.ToShortTimeString();
            txtEndTime.Text = Options.EndTime.ToShortTimeString();
            txtFirstTicket.Text = Options.TicketNumber.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                Options.MinutesPerWindow = Convert.ToInt16(txtMinutesPerWindow.Text);
                Options.GuestsPerWindow = Convert.ToInt16(txtGuestsPerWindow.Text);
                Options.StartTime = DateTime.Parse(txtStartTime.Text);
                Options.EndTime = DateTime.Parse(txtEndTime.Text);
                Options.TicketNumber = Convert.ToInt16(txtFirstTicket.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private bool IsValidData()
        {
            if (!IsPresent(txtMinutesPerWindow, "Minutes per window"))
                return false;
            if (!IsInt32(txtMinutesPerWindow, "Minutes per window"))
                return false;
            if (!IsPresent(txtGuestsPerWindow, "Guests per window"))
                return false;
            if (!IsInt32(txtGuestsPerWindow, "Guests per window"))
                return false;
            if (!IsPresent(txtStartTime, "Start time"))
                return false;
            if (!IsDateTime(txtStartTime, "Start time"))
                return false;
            if (!IsPresent(txtEndTime, "End time"))
                return false;
            if (!IsDateTime(txtEndTime, "End time"))
                return false;
            if (!IsPresent(txtFirstTicket, "First ticket number"))
                return false;
            if (!IsInt32(txtFirstTicket, "First ticket number"))
                return false;

            DateTime startTime = Convert.ToDateTime(txtStartTime.Text);
            DateTime endTime = Convert.ToDateTime(txtEndTime.Text);
            int minutesPerWindow = Convert.ToInt32(txtMinutesPerWindow.Text);

            if (startTime.AddMinutes(minutesPerWindow) > endTime)
            {
                string msg = $"End time must be at least {minutesPerWindow} minutes after start time.";
                MessageBox.Show(msg, "Entry Error");
                return false;
            }

            return true;
        }

        private bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show($"{name} is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsInt32(TextBox textBox, string name)
        {
            if (Int32.TryParse(textBox.Text, out int number))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{name} must be a valid integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsDateTime(TextBox textBox, string name)
        {
            if (DateTime.TryParse(textBox.Text, out DateTime dateTime))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{name} must be a valid date.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }
    }
}
