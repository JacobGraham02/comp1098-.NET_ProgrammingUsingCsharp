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

    public partial class frmStudentScores : Form
    {
        public List<string> studentScores = new List<string>();

        public frmStudentScores()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form addForm = new frmAddNewStudent();
            DialogResult result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                studentScores.Add(addForm.Tag.ToString());
                int lastIndex = studentScores.Count - 1;
                LoadStudentListBox(lastIndex);
            }
        }
        
        private void btnStudentScoresExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (studentScores.Count > 0)
            {
                int selectedIndex = lstBoxStudentScores.SelectedIndex;
                string student = (string)studentScores[selectedIndex];
                Form updateForm = new frmUpdateStudentScores();
                updateForm.Tag = student;
                DialogResult result = updateForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    studentScores.RemoveAt(selectedIndex);
                    studentScores.Insert(selectedIndex, updateForm.Tag.ToString());
                    LoadStudentListBox(selectedIndex);
                }
            }
        }

        private void lstBoxStudentScores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxStudentScores.SelectedIndex != -1)
            {
                string student = (string)studentScores[lstBoxStudentScores.SelectedIndex];

                string[] scores = student.Split('|');

                int total = 0;
                
                for (int i = 1; i < scores.Length; i++)
                    total += Convert.ToInt32(scores[i]);

                int count = scores.Length - 1;
                int average = 0;
                if (total > 0)
                {
                    average = total / count;
                }
                lblScoreTotalResult.Text = total.ToString();
                lblScoreCountResult.Text = count.ToString();
                lblAverageResult.Text = average.ToString();
            }
        }

        private void frmStudentScores_Load(object sender, EventArgs e)
        {
            studentScores.Add("Joel Murach|97|91|83");
            studentScores.Add("Doug Lowe|99|93|97");
            studentScores.Add("Anne Boehm|100|100|100");
            LoadStudentListBox();
        }
        private void LoadStudentListBox(int selectedIndex = 0)
        {
            lstBoxStudentScores.Items.Clear();
            foreach (string s in studentScores)
            {
                lstBoxStudentScores.Items.Add(s);
            }
            if (lstBoxStudentScores.Items.Count > 0)
                lstBoxStudentScores.SelectedIndex = selectedIndex;
            else
                ClearLabels();
            lstBoxStudentScores.Focus();
        }
        private void ClearLabels()
        {
            this.lblScoreTotalResult.Text = "";
            this.lblScoreCountResult.Text = "";
            this.lblAverageResult.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentScores.Count > 0)
            {
                studentScores.RemoveAt(lstBoxStudentScores.SelectedIndex);
                LoadStudentListBox();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
