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
            if (this.Text == "Update Score")
            {
                btnAddScore.Text = "Update";
                txtAddScoreInput.Text = this.Tag.ToString();
            }
        }

        private void btnCancelAddScore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                this.Tag = Convert.ToInt32(txtAddScoreInput.Text);
                this.DialogResult = DialogResult.OK;
            }
        }
        private bool IsValidData()
        {
            return IsPresent(txtAddScoreInput, "Score") &&
                    IsInt32(txtAddScoreInput, "Score") &&
                    IsWithinRange(txtAddScoreInput, "Score", 0, 100);
        }
        private bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        private bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            string errorMsg = "The added score must be a number";

            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            } 
            else
            {
                MessageBox.Show(errorMsg);
                txtAddScoreInput.Focus();
                return false;
            }
        }
        // See if the score is from 1 to 100. 
        private bool IsWithinRange(TextBox txtBox, string name, decimal min, decimal max) 
        {
            decimal numInBox = Convert.ToDecimal(txtBox.Text);
            string errorMsg = "The added score must be between {0} and {1}";
            if (numInBox < min || numInBox > max)
            {
                MessageBox.Show(string.Format(errorMsg, min, max));
                txtAddScoreInput.Focus();
                return false;
            } else
            {
                return true;
            }
        }
    }
}
