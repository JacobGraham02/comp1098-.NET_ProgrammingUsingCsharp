using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_2_MaintainStudentScores
{
    public partial class frmAddScore : Form
    {
        public frmAddScore()
        {
            InitializeComponent();
        }

        private void frmAddScore_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelAddScore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
