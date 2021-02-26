using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_2_AssignTicketsWithTimeSlots
{
    public partial class frmOptions : Form
    {

        private TimeWindow timeWindow = null;
        private Ticket ticket = null;

        public frmOptions()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string startTime = txtStartTime.Text;
            this.Tag = startTime;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            
            string currentTime = string.Format("{0:HH:mm tt}", DateTime.Now);
            txtMinutesPerWindow.Text = "5";
            txtGuestsPerWindow.Text = "5";
            txtStartTime.Text = currentTime;
            txtEndTime.Text = string.Format("{0:HH:mm tt}", DateTime.Now.AddHours(4));
            txtFirstTicketNumber.Text = "1";
        }
    }
}
