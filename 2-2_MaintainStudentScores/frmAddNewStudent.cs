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
    public partial class frmAddNewStudent : Form
    {
        public frmAddNewStudent()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelForAddStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            txtMultipleScores.Text += txtSingleScore.Text + " ";
            txtSingleScore.Text = "";
        }

        private void frmAddNewStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnOkForAddStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            txtMultipleScores.Text = "";
            txtSingleScore.Text = "";
            txtName.Text = "";
        }
    }
}
