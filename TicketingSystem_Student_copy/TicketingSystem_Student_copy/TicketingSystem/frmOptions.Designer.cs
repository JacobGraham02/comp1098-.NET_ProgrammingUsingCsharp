namespace TicketingSystem
{
    partial class frmOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinutesPerWindow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuestsPerWindow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstTicket = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutes per window:";
            // 
            // txtMinutesPerWindow
            // 
            this.txtMinutesPerWindow.Location = new System.Drawing.Point(155, 16);
            this.txtMinutesPerWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMinutesPerWindow.Name = "txtMinutesPerWindow";
            this.txtMinutesPerWindow.Size = new System.Drawing.Size(106, 23);
            this.txtMinutesPerWindow.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Guests per window:";
            // 
            // txtGuestsPerWindow
            // 
            this.txtGuestsPerWindow.Location = new System.Drawing.Point(155, 44);
            this.txtGuestsPerWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGuestsPerWindow.Name = "txtGuestsPerWindow";
            this.txtGuestsPerWindow.Size = new System.Drawing.Size(106, 23);
            this.txtGuestsPerWindow.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start time:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(155, 71);
            this.txtStartTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(106, 23);
            this.txtStartTime.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "End time:";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(155, 99);
            this.txtEndTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(106, 23);
            this.txtEndTime.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "First ticket number:";
            // 
            // txtFirstTicket
            // 
            this.txtFirstTicket.Location = new System.Drawing.Point(155, 127);
            this.txtFirstTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstTicket.Name = "txtFirstTicket";
            this.txtFirstTicket.Size = new System.Drawing.Size(106, 23);
            this.txtFirstTicket.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(155, 160);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmOptions
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 199);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFirstTicket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGuestsPerWindow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinutesPerWindow);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinutesPerWindow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuestsPerWindow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstTicket;
        private System.Windows.Forms.Button btnOK;
    }
}