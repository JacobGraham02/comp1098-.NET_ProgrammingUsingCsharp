
namespace Lab3_2_AssignTicketsWithTimeSlots
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
            this.lblMinutesPerWindow = new System.Windows.Forms.Label();
            this.lblGuestsPerWindow = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblFirstTicketNumber = new System.Windows.Forms.Label();
            this.txtMinutesPerWindow = new System.Windows.Forms.TextBox();
            this.txtFirstTicketNumber = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtGuestsPerWindow = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMinutesPerWindow
            // 
            this.lblMinutesPerWindow.AutoSize = true;
            this.lblMinutesPerWindow.Location = new System.Drawing.Point(13, 16);
            this.lblMinutesPerWindow.Name = "lblMinutesPerWindow";
            this.lblMinutesPerWindow.Size = new System.Drawing.Size(104, 13);
            this.lblMinutesPerWindow.TabIndex = 0;
            this.lblMinutesPerWindow.Text = "Minutes per window:";
            // 
            // lblGuestsPerWindow
            // 
            this.lblGuestsPerWindow.AutoSize = true;
            this.lblGuestsPerWindow.Location = new System.Drawing.Point(12, 47);
            this.lblGuestsPerWindow.Name = "lblGuestsPerWindow";
            this.lblGuestsPerWindow.Size = new System.Drawing.Size(100, 13);
            this.lblGuestsPerWindow.TabIndex = 1;
            this.lblGuestsPerWindow.Text = "Guests per window:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(13, 86);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(54, 13);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "Start time:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(13, 125);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(51, 13);
            this.lblEndTime.TabIndex = 3;
            this.lblEndTime.Text = "End time:";
            // 
            // lblFirstTicketNumber
            // 
            this.lblFirstTicketNumber.AutoSize = true;
            this.lblFirstTicketNumber.Location = new System.Drawing.Point(12, 163);
            this.lblFirstTicketNumber.Name = "lblFirstTicketNumber";
            this.lblFirstTicketNumber.Size = new System.Drawing.Size(96, 13);
            this.lblFirstTicketNumber.TabIndex = 4;
            this.lblFirstTicketNumber.Text = "First ticket number:";
            // 
            // txtMinutesPerWindow
            // 
            this.txtMinutesPerWindow.Location = new System.Drawing.Point(114, 13);
            this.txtMinutesPerWindow.Name = "txtMinutesPerWindow";
            this.txtMinutesPerWindow.Size = new System.Drawing.Size(100, 20);
            this.txtMinutesPerWindow.TabIndex = 1;
            // 
            // txtFirstTicketNumber
            // 
            this.txtFirstTicketNumber.Location = new System.Drawing.Point(114, 160);
            this.txtFirstTicketNumber.Name = "txtFirstTicketNumber";
            this.txtFirstTicketNumber.Size = new System.Drawing.Size(100, 20);
            this.txtFirstTicketNumber.TabIndex = 5;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(114, 122);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(100, 20);
            this.txtEndTime.TabIndex = 4;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(114, 83);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(100, 20);
            this.txtStartTime.TabIndex = 3;
            // 
            // txtGuestsPerWindow
            // 
            this.txtGuestsPerWindow.Location = new System.Drawing.Point(114, 44);
            this.txtGuestsPerWindow.Name = "txtGuestsPerWindow";
            this.txtGuestsPerWindow.Size = new System.Drawing.Size(100, 20);
            this.txtGuestsPerWindow.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(73, 209);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(164, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 244);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtGuestsPerWindow);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtFirstTicketNumber);
            this.Controls.Add(this.txtMinutesPerWindow);
            this.Controls.Add(this.lblFirstTicketNumber);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblGuestsPerWindow);
            this.Controls.Add(this.lblMinutesPerWindow);
            this.Name = "frmOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinutesPerWindow;
        private System.Windows.Forms.Label lblGuestsPerWindow;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblFirstTicketNumber;
        private System.Windows.Forms.TextBox txtMinutesPerWindow;
        private System.Windows.Forms.TextBox txtFirstTicketNumber;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtGuestsPerWindow;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}