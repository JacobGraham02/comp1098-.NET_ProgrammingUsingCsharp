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
    public partial class frmTickets : Form
    {
        private Ticket ticket = null;
        public frmTickets()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Form optionsForm = new frmOptions();
            DialogResult formResult = optionsForm.ShowDialog();
        }

        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
            Form frmTicket = new frmOptions();
            MessageBox.Show(frmTicket.Tag.ToString());
            //ticket = new Ticket();
        }
    }
}
