
namespace _2_2_MaintainStudentScores
{
    partial class frmUpdateStudentScores
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
            this.lblNameUpdateStudentScores = new System.Windows.Forms.Label();
            this.lblScoresUpdateStudentScores = new System.Windows.Forms.Label();
            this.lstBoxScores = new System.Windows.Forms.ListBox();
            this.lblNameInput = new System.Windows.Forms.Label();
            this.btnAddStudentScores = new System.Windows.Forms.Button();
            this.btnUpdateScoreSelected = new System.Windows.Forms.Button();
            this.btnRemoveScoreSelected = new System.Windows.Forms.Button();
            this.btnClearScoreList = new System.Windows.Forms.Button();
            this.btnOkUpdateStudentScores = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameUpdateStudentScores
            // 
            this.lblNameUpdateStudentScores.AutoSize = true;
            this.lblNameUpdateStudentScores.Location = new System.Drawing.Point(16, 13);
            this.lblNameUpdateStudentScores.Name = "lblNameUpdateStudentScores";
            this.lblNameUpdateStudentScores.Size = new System.Drawing.Size(38, 13);
            this.lblNameUpdateStudentScores.TabIndex = 0;
            this.lblNameUpdateStudentScores.Text = "Name:";
            // 
            // lblScoresUpdateStudentScores
            // 
            this.lblScoresUpdateStudentScores.AutoSize = true;
            this.lblScoresUpdateStudentScores.Location = new System.Drawing.Point(16, 48);
            this.lblScoresUpdateStudentScores.Name = "lblScoresUpdateStudentScores";
            this.lblScoresUpdateStudentScores.Size = new System.Drawing.Size(43, 13);
            this.lblScoresUpdateStudentScores.TabIndex = 1;
            this.lblScoresUpdateStudentScores.Text = "Scores:";
            // 
            // lstBoxScores
            // 
            this.lstBoxScores.FormattingEnabled = true;
            this.lstBoxScores.Location = new System.Drawing.Point(68, 48);
            this.lstBoxScores.Name = "lstBoxScores";
            this.lstBoxScores.Size = new System.Drawing.Size(120, 108);
            this.lstBoxScores.TabIndex = 2;
            // 
            // lblNameInput
            // 
            this.lblNameInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameInput.Location = new System.Drawing.Point(68, 13);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.Size = new System.Drawing.Size(215, 23);
            this.lblNameInput.TabIndex = 3;
            // 
            // btnAddStudentScores
            // 
            this.btnAddStudentScores.Location = new System.Drawing.Point(195, 48);
            this.btnAddStudentScores.Name = "btnAddStudentScores";
            this.btnAddStudentScores.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudentScores.TabIndex = 4;
            this.btnAddStudentScores.Text = "Add";
            this.btnAddStudentScores.UseVisualStyleBackColor = true;
            this.btnAddStudentScores.Click += new System.EventHandler(this.btnAddStudentScores_Click);
            // 
            // btnUpdateScoreSelected
            // 
            this.btnUpdateScoreSelected.Location = new System.Drawing.Point(195, 78);
            this.btnUpdateScoreSelected.Name = "btnUpdateScoreSelected";
            this.btnUpdateScoreSelected.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateScoreSelected.TabIndex = 5;
            this.btnUpdateScoreSelected.Text = "Update";
            this.btnUpdateScoreSelected.UseVisualStyleBackColor = true;
            this.btnUpdateScoreSelected.Click += new System.EventHandler(this.btnUpdateScoreSelected_Click);
            // 
            // btnRemoveScoreSelected
            // 
            this.btnRemoveScoreSelected.Location = new System.Drawing.Point(195, 107);
            this.btnRemoveScoreSelected.Name = "btnRemoveScoreSelected";
            this.btnRemoveScoreSelected.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveScoreSelected.TabIndex = 6;
            this.btnRemoveScoreSelected.Text = "Remove";
            this.btnRemoveScoreSelected.UseVisualStyleBackColor = true;
            this.btnRemoveScoreSelected.Click += new System.EventHandler(this.btnRemoveScoreSelected_Click);
            // 
            // btnClearScoreList
            // 
            this.btnClearScoreList.Location = new System.Drawing.Point(194, 136);
            this.btnClearScoreList.Name = "btnClearScoreList";
            this.btnClearScoreList.Size = new System.Drawing.Size(75, 23);
            this.btnClearScoreList.TabIndex = 7;
            this.btnClearScoreList.Text = "Clear Scores";
            this.btnClearScoreList.UseVisualStyleBackColor = true;
            this.btnClearScoreList.Click += new System.EventHandler(this.btnClearScoreList_Click);
            // 
            // btnOkUpdateStudentScores
            // 
            this.btnOkUpdateStudentScores.Location = new System.Drawing.Point(96, 187);
            this.btnOkUpdateStudentScores.Name = "btnOkUpdateStudentScores";
            this.btnOkUpdateStudentScores.Size = new System.Drawing.Size(75, 23);
            this.btnOkUpdateStudentScores.TabIndex = 8;
            this.btnOkUpdateStudentScores.Text = "Ok";
            this.btnOkUpdateStudentScores.UseVisualStyleBackColor = true;
            this.btnOkUpdateStudentScores.Click += new System.EventHandler(this.btnOkUpdateStudentScores_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(195, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmUpdateStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 239);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkUpdateStudentScores);
            this.Controls.Add(this.btnClearScoreList);
            this.Controls.Add(this.btnRemoveScoreSelected);
            this.Controls.Add(this.btnUpdateScoreSelected);
            this.Controls.Add(this.btnAddStudentScores);
            this.Controls.Add(this.lblNameInput);
            this.Controls.Add(this.lstBoxScores);
            this.Controls.Add(this.lblScoresUpdateStudentScores);
            this.Controls.Add(this.lblNameUpdateStudentScores);
            this.Name = "frmUpdateStudentScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update student scores";
            this.Load += new System.EventHandler(this.frmUpdateStudentScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameUpdateStudentScores;
        private System.Windows.Forms.Label lblScoresUpdateStudentScores;
        private System.Windows.Forms.ListBox lstBoxScores;
        private System.Windows.Forms.Label lblNameInput;
        private System.Windows.Forms.Button btnAddStudentScores;
        private System.Windows.Forms.Button btnUpdateScoreSelected;
        private System.Windows.Forms.Button btnRemoveScoreSelected;
        private System.Windows.Forms.Button btnClearScoreList;
        private System.Windows.Forms.Button btnOkUpdateStudentScores;
        private System.Windows.Forms.Button btnCancel;
    }
}