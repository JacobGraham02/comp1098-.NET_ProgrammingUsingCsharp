
namespace _2_2_MaintainStudentScores
{
    partial class frmUpdateScore
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
            this.lblUpdateScore = new System.Windows.Forms.Label();
            this.txtUpdateScoreInput = new System.Windows.Forms.TextBox();
            this.btnUpdateScore = new System.Windows.Forms.Button();
            this.btnCancelScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUpdateScore
            // 
            this.lblUpdateScore.AutoSize = true;
            this.lblUpdateScore.Location = new System.Drawing.Point(25, 24);
            this.lblUpdateScore.Name = "lblUpdateScore";
            this.lblUpdateScore.Size = new System.Drawing.Size(38, 13);
            this.lblUpdateScore.TabIndex = 0;
            this.lblUpdateScore.Text = "Score:";
            // 
            // txtUpdateScoreInput
            // 
            this.txtUpdateScoreInput.Location = new System.Drawing.Point(69, 21);
            this.txtUpdateScoreInput.Name = "txtUpdateScoreInput";
            this.txtUpdateScoreInput.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateScoreInput.TabIndex = 1;
            // 
            // btnUpdateScore
            // 
            this.btnUpdateScore.Location = new System.Drawing.Point(28, 59);
            this.btnUpdateScore.Name = "btnUpdateScore";
            this.btnUpdateScore.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateScore.TabIndex = 2;
            this.btnUpdateScore.Text = "Update";
            this.btnUpdateScore.UseVisualStyleBackColor = true;
            this.btnUpdateScore.Click += new System.EventHandler(this.btnUpdateScore_Click);
            // 
            // btnCancelScore
            // 
            this.btnCancelScore.Location = new System.Drawing.Point(109, 59);
            this.btnCancelScore.Name = "btnCancelScore";
            this.btnCancelScore.Size = new System.Drawing.Size(75, 23);
            this.btnCancelScore.TabIndex = 3;
            this.btnCancelScore.Text = "Cancel";
            this.btnCancelScore.UseVisualStyleBackColor = true;
            this.btnCancelScore.Click += new System.EventHandler(this.btnCancelScore_Click);
            // 
            // frmUpdateScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 160);
            this.Controls.Add(this.btnCancelScore);
            this.Controls.Add(this.btnUpdateScore);
            this.Controls.Add(this.txtUpdateScoreInput);
            this.Controls.Add(this.lblUpdateScore);
            this.Name = "frmUpdateScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Score";
            this.Load += new System.EventHandler(this.frmUpdateScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateScore;
        private System.Windows.Forms.TextBox txtUpdateScoreInput;
        private System.Windows.Forms.Button btnUpdateScore;
        private System.Windows.Forms.Button btnCancelScore;
    }
}