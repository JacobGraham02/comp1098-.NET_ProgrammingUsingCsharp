
namespace _2_2_MaintainStudentScores
{
    partial class frmAddNewStudent
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSingleScore = new System.Windows.Forms.Label();
            this.lblMultipleScores = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSingleScore = new System.Windows.Forms.TextBox();
            this.txtMultipleScores = new System.Windows.Forms.TextBox();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnCancelForAddStudent = new System.Windows.Forms.Button();
            this.btnOkForAddStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblSingleScore
            // 
            this.lblSingleScore.AutoSize = true;
            this.lblSingleScore.Location = new System.Drawing.Point(12, 62);
            this.lblSingleScore.Name = "lblSingleScore";
            this.lblSingleScore.Size = new System.Drawing.Size(38, 13);
            this.lblSingleScore.TabIndex = 1;
            this.lblSingleScore.Text = "Score:";
            // 
            // lblMultipleScores
            // 
            this.lblMultipleScores.AutoSize = true;
            this.lblMultipleScores.Location = new System.Drawing.Point(12, 97);
            this.lblMultipleScores.Name = "lblMultipleScores";
            this.lblMultipleScores.Size = new System.Drawing.Size(43, 13);
            this.lblMultipleScores.TabIndex = 2;
            this.lblMultipleScores.Text = "Scores:";
            this.lblMultipleScores.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtSingleScore
            // 
            this.txtSingleScore.Location = new System.Drawing.Point(79, 59);
            this.txtSingleScore.Name = "txtSingleScore";
            this.txtSingleScore.Size = new System.Drawing.Size(100, 20);
            this.txtSingleScore.TabIndex = 2;
            // 
            // txtMultipleScores
            // 
            this.txtMultipleScores.Location = new System.Drawing.Point(79, 94);
            this.txtMultipleScores.Name = "txtMultipleScores";
            this.txtMultipleScores.ReadOnly = true;
            this.txtMultipleScores.Size = new System.Drawing.Size(182, 20);
            this.txtMultipleScores.TabIndex = 0;
            this.txtMultipleScores.TabStop = false;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(186, 59);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(75, 23);
            this.btnAddScore.TabIndex = 3;
            this.btnAddScore.Text = "&Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(186, 131);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(75, 23);
            this.btnClearScores.TabIndex = 4;
            this.btnClearScores.Text = "&Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnCancelForAddStudent
            // 
            this.btnCancelForAddStudent.Location = new System.Drawing.Point(186, 175);
            this.btnCancelForAddStudent.Name = "btnCancelForAddStudent";
            this.btnCancelForAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnCancelForAddStudent.TabIndex = 6;
            this.btnCancelForAddStudent.Text = "C&ancel";
            this.btnCancelForAddStudent.UseVisualStyleBackColor = true;
            this.btnCancelForAddStudent.Click += new System.EventHandler(this.btnCancelForAddStudent_Click);
            // 
            // btnOkForAddStudent
            // 
            this.btnOkForAddStudent.Location = new System.Drawing.Point(79, 175);
            this.btnOkForAddStudent.Name = "btnOkForAddStudent";
            this.btnOkForAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnOkForAddStudent.TabIndex = 5;
            this.btnOkForAddStudent.Text = "&Ok";
            this.btnOkForAddStudent.UseVisualStyleBackColor = true;
            this.btnOkForAddStudent.Click += new System.EventHandler(this.btnOkForAddStudent_Click);
            // 
            // frmAddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 237);
            this.Controls.Add(this.btnOkForAddStudent);
            this.Controls.Add(this.btnCancelForAddStudent);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.txtMultipleScores);
            this.Controls.Add(this.txtSingleScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMultipleScores);
            this.Controls.Add(this.lblSingleScore);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddNewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.frmAddNewStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSingleScore;
        private System.Windows.Forms.Label lblMultipleScores;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSingleScore;
        private System.Windows.Forms.TextBox txtMultipleScores;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnCancelForAddStudent;
        private System.Windows.Forms.Button btnOkForAddStudent;
    }
}