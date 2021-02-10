
namespace _2_2_MaintainStudentScores
{
    partial class frmStudentScores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStudents = new System.Windows.Forms.Label();
            this.lstBoxStudentScores = new System.Windows.Forms.ListBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblAverageOfScores = new System.Windows.Forms.Label();
            this.lblScoreTotalResult = new System.Windows.Forms.Label();
            this.lblScoreCountResult = new System.Windows.Forms.Label();
            this.lblAverageResult = new System.Windows.Forms.Label();
            this.btnStudentScoresExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(13, 13);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(49, 13);
            this.lblStudents.TabIndex = 0;
            this.lblStudents.Text = "Students";
            // 
            // lstBoxStudentScores
            // 
            this.lstBoxStudentScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxStudentScores.FormattingEnabled = true;
            this.lstBoxStudentScores.ItemHeight = 16;
            this.lstBoxStudentScores.Location = new System.Drawing.Point(16, 30);
            this.lstBoxStudentScores.Name = "lstBoxStudentScores";
            this.lstBoxStudentScores.Size = new System.Drawing.Size(270, 116);
            this.lstBoxStudentScores.TabIndex = 1;
            this.lstBoxStudentScores.SelectedIndexChanged += new System.EventHandler(this.lstBoxStudentScores_SelectedIndexChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(293, 30);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "&Add New...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(293, 78);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "&Update...";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(293, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.Location = new System.Drawing.Point(84, 184);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(61, 13);
            this.lblScoreTotal.TabIndex = 5;
            this.lblScoreTotal.Text = "&Score total:";
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.Location = new System.Drawing.Point(84, 216);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(68, 13);
            this.lblScoreCount.TabIndex = 6;
            this.lblScoreCount.Text = "&Score count:";
            // 
            // lblAverageOfScores
            // 
            this.lblAverageOfScores.AutoSize = true;
            this.lblAverageOfScores.Location = new System.Drawing.Point(84, 245);
            this.lblAverageOfScores.Name = "lblAverageOfScores";
            this.lblAverageOfScores.Size = new System.Drawing.Size(50, 13);
            this.lblAverageOfScores.TabIndex = 7;
            this.lblAverageOfScores.Text = "&Average:";
            // 
            // lblScoreTotalResult
            // 
            this.lblScoreTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreTotalResult.Location = new System.Drawing.Point(161, 183);
            this.lblScoreTotalResult.Name = "lblScoreTotalResult";
            this.lblScoreTotalResult.Size = new System.Drawing.Size(100, 23);
            this.lblScoreTotalResult.TabIndex = 8;
            // 
            // lblScoreCountResult
            // 
            this.lblScoreCountResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreCountResult.Location = new System.Drawing.Point(161, 215);
            this.lblScoreCountResult.Name = "lblScoreCountResult";
            this.lblScoreCountResult.Size = new System.Drawing.Size(100, 23);
            this.lblScoreCountResult.TabIndex = 9;
            // 
            // lblAverageResult
            // 
            this.lblAverageResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageResult.Location = new System.Drawing.Point(161, 244);
            this.lblAverageResult.Name = "lblAverageResult";
            this.lblAverageResult.Size = new System.Drawing.Size(100, 23);
            this.lblAverageResult.TabIndex = 12;
            // 
            // btnStudentScoresExit
            // 
            this.btnStudentScoresExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStudentScoresExit.Location = new System.Drawing.Point(293, 244);
            this.btnStudentScoresExit.Name = "btnStudentScoresExit";
            this.btnStudentScoresExit.Size = new System.Drawing.Size(75, 23);
            this.btnStudentScoresExit.TabIndex = 11;
            this.btnStudentScoresExit.Text = "E&xit";
            this.btnStudentScoresExit.UseVisualStyleBackColor = true;
            this.btnStudentScoresExit.Click += new System.EventHandler(this.btnStudentScoresExit_Click);
            // 
            // frmStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStudentScoresExit;
            this.ClientSize = new System.Drawing.Size(413, 300);
            this.Controls.Add(this.btnStudentScoresExit);
            this.Controls.Add(this.lblAverageResult);
            this.Controls.Add(this.lblScoreCountResult);
            this.Controls.Add(this.lblScoreTotalResult);
            this.Controls.Add(this.lblAverageOfScores);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lstBoxStudentScores);
            this.Controls.Add(this.lblStudents);
            this.Name = "frmStudentScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.frmStudentScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.ListBox lstBoxStudentScores;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblAverageOfScores;
        private System.Windows.Forms.Label lblScoreTotalResult;
        private System.Windows.Forms.Label lblScoreCountResult;
        private System.Windows.Forms.Label lblAverageResult;
        private System.Windows.Forms.Button btnStudentScoresExit;
    }
}

