
namespace _2_2_MaintainStudentScores
{
    partial class frmAddScore
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
            this.lblScore = new System.Windows.Forms.Label();
            this.txtAddScoreInput = new System.Windows.Forms.TextBox();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.btnCancelAddScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(32, 36);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            // 
            // txtAddScoreInput
            // 
            this.txtAddScoreInput.Location = new System.Drawing.Point(76, 33);
            this.txtAddScoreInput.Name = "txtAddScoreInput";
            this.txtAddScoreInput.Size = new System.Drawing.Size(100, 20);
            this.txtAddScoreInput.TabIndex = 1;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(35, 84);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(75, 23);
            this.btnAddScore.TabIndex = 2;
            this.btnAddScore.Text = "Add";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // btnCancelAddScore
            // 
            this.btnCancelAddScore.Location = new System.Drawing.Point(116, 84);
            this.btnCancelAddScore.Name = "btnCancelAddScore";
            this.btnCancelAddScore.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddScore.TabIndex = 3;
            this.btnCancelAddScore.Text = "Cancel";
            this.btnCancelAddScore.UseVisualStyleBackColor = true;
            this.btnCancelAddScore.Click += new System.EventHandler(this.btnCancelAddScore_Click);
            // 
            // frmAddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 151);
            this.Controls.Add(this.btnCancelAddScore);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.txtAddScoreInput);
            this.Controls.Add(this.lblScore);
            this.Name = "frmAddScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Score";
            this.Load += new System.EventHandler(this.frmAddScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtAddScoreInput;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Button btnCancelAddScore;
    }
}