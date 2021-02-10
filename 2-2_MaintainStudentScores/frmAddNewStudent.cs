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
        List<int> scoresList = new List<int>();

        public frmAddNewStudent()
        {
            InitializeComponent();
        }
        private void btnCancelForAddStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if (IsValidScore())
            {
                int score = Convert.ToInt32(txtSingleScore.Text);
                scoresList.Add(score);
                DisplayScores();
                txtSingleScore.Clear();
                txtSingleScore.Focus();
            }
        }

        private void frmAddNewStudent_Load(object sender, EventArgs e)
        {

        }
        

        private void btnOkForAddStudent_Click(object sender, EventArgs e)
        {
            if (IsValidName())
            {
                string studentScores = txtName.Text;
                foreach (int i in scoresList)
                    studentScores += "|" + i.ToString();
                this.Tag = studentScores;
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool IsValidScore()
        {
            return
                IsPresent(txtSingleScore, "Score") &&
                IsInt32(txtSingleScore, "Score") &&
                IsWithinRange(txtSingleScore, "Score", 0, 100);
        }
        private bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a valid integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }
        private bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        private bool IsValidName()
        {
            return IsPresent(txtName, "Name");
        }
        

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            scoresList.Clear();
            DisplayScores();
            txtSingleScore.Focus();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

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
        private void DisplayScores()
        {
            string scores = "";
            foreach (int i in scoresList)
            {
                scores += i.ToString() + " ";
            }
            txtMultipleScores.Text = scores;

        }
    }
}
