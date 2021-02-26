using ProductMaintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void frmSplashTimer_Tick(object sender, EventArgs e)
        {
            frmSplashTimer.Enabled = false;
            frmBookProductMainenance frmStart = new frmBookProductMainenance();
            frmStart.Show();
            this.Hide();
        }
    }
}
