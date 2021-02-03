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
        Dictionary<string, string> initialStudentNamesAndScores = new Dictionary<string, string>();
        
        public frmStudentScores()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form frmAddNewStudent = new frmAddNewStudent();
            DialogResult diaResult = frmAddNewStudent.ShowDialog();
        }

        private void btnStudentScoresExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form updateStudentFrm = new frmUpdateStudentScores();
            DialogResult updateStudentFrmResult = updateStudentFrm.ShowDialog();
        }

        private void lstBoxStudentScores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstBoxStudentScores.SelectedIndex;
        }

        // Dictionary<string, List<int>> initialStudentNamesAndScores = new Dictionary<string, List<int>>();
        /*
         * foreach(var pair in Employees)
{
    Console.WriteLine($"Employee with key {pair.Key}: Id={pair.Value.Id} Name={pair.Value.Name}");
}
         */
        private void frmStudentScores_Load(object sender, EventArgs e)
        {
            initialStudentNamesAndScores.Add("Joel Murach", "87, 91, 83");
            initialStudentNamesAndScores.Add("Doug Lowe", "99, 93, 97");
            initialStudentNamesAndScores.Add("Anne Boehm", "100, 100, 100");

            foreach(var item in initialStudentNamesAndScores)
            {
                lstBoxStudentScores.Items.Add(item.Key + item.Value);
            }
        }

        private void lblScoreTotalResult_Click(object sender, EventArgs e)
        {

        }

        private void lblAverageResult_Click(object sender, EventArgs e)
        {

        }


        private void lblScoreCountResult_Click(object sender, EventArgs e)
        {

        }
    }
}
