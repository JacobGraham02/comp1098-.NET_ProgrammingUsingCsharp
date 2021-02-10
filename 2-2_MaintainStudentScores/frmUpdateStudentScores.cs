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
    public partial class frmUpdateStudentScores : Form
    {
        public frmUpdateStudentScores()
        {
            InitializeComponent();
        }
        List<int> scoresList = new List<int>();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudentScores_Click(object sender, EventArgs e)
        {
            Form frmAddScore = new frmAddScore();
            frmAddScore.Text = "Add score";

            DialogResult result = frmAddScore.ShowDialog();
            if (result == DialogResult.OK)
            {
                int score = (int)frmAddScore.Tag;
                scoresList.Add(score);
                DisplayScores();
            }
        }

        private void btnUpdateScoreSelected_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstBoxScores.SelectedIndex;
            if (selectedIndex > -1)
            {
                Form updateForm = new frmAddScore
                {
                    Text = "Update score",
                    Tag = lstBoxScores.SelectedItem
                };

                DialogResult result = updateForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int score = (int)updateForm.Tag;
                    scoresList.RemoveAt(selectedIndex);
                    scoresList.Insert(selectedIndex, score);
                    DisplayScores();
                }
            }
        }
        
        private void frmUpdateStudentScores_Load(object sender, EventArgs e)
        {
            string student = (string)this.Tag;
            string[] nameAndScores = student.Split('|');

            string name = nameAndScores[0];
            lblNameInput.Text = name;

            if (nameAndScores.Length > 1)
            {
                for (int i = 1; i < nameAndScores.Length; i++)
                {
                    scoresList.Add(Convert.ToInt32(nameAndScores[i]));
                }
                DisplayScores();
            }
        }

        private void DisplayScores()
        {
            lstBoxScores.Items.Clear();

            if (scoresList.Count > 0)
            {
                foreach (int score in scoresList)
                {
                    lstBoxScores.Items.Add(score);
                }
                lstBoxScores.SelectedIndex = 0;
            }
        }
        private void btnOkUpdateStudentScores_Click(object sender, EventArgs e)
        {
            string studentScores = lblNameInput.Text;
            foreach(int i in scoresList)
                studentScores += "|" + i.ToString();
            this.Tag = studentScores;
            this.DialogResult = DialogResult.OK;
        }

        private void btnRemoveScoreSelected_Click(object sender, EventArgs e)
        {
            if (lstBoxScores.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an index to remove", "Removal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lstBoxScores.Items.Count > 0)
            {
                lstBoxScores.Items.RemoveAt(lstBoxScores.SelectedIndex);
            }
            else
            {
                MessageBox.Show("You must have some scores that can be removed", "Removal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearScoreList_Click(object sender, EventArgs e)
        {
            scoresList.Clear();
            DisplayScores();
        }
    }
}
