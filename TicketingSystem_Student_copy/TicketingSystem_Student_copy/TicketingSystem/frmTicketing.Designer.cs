namespace TicketingSystem
{
    partial class frmTicketing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNowServing = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.lblNextEntry = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOutstanding = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.secondTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNowServing);
            this.groupBox1.Location = new System.Drawing.Point(22, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(323, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests with the following tickets may now enter:";
            // 
            // lblNowServing
            // 
            this.lblNowServing.AutoSize = true;
            this.lblNowServing.Location = new System.Drawing.Point(15, 26);
            this.lblNowServing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNowServing.Name = "lblNowServing";
            this.lblNowServing.Size = new System.Drawing.Size(0, 15);
            this.lblNowServing.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTicket);
            this.groupBox2.Controls.Add(this.lblNextEntry);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblOutstanding);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(22, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(323, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Availability";
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(15, 70);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(125, 23);
            this.btnTicket.TabIndex = 4;
            this.btnTicket.Text = "Issue &Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // lblNextEntry
            // 
            this.lblNextEntry.AutoSize = true;
            this.lblNextEntry.Location = new System.Drawing.Point(175, 47);
            this.lblNextEntry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNextEntry.Name = "lblNextEntry";
            this.lblNextEntry.Size = new System.Drawing.Size(56, 15);
            this.lblNextEntry.TabIndex = 3;
            this.lblNextEntry.Text = "10:29 AM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Next available entry:";
            // 
            // lblOutstanding
            // 
            this.lblOutstanding.AutoSize = true;
            this.lblOutstanding.Location = new System.Drawing.Point(175, 24);
            this.lblOutstanding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutstanding.Name = "lblOutstanding";
            this.lblOutstanding.Size = new System.Drawing.Size(13, 15);
            this.lblOutstanding.TabIndex = 1;
            this.lblOutstanding.Text = "7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total tickets outstanding:";
            // 
            // lstTickets
            // 
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.ItemHeight = 15;
            this.lstTickets.Location = new System.Drawing.Point(22, 200);
            this.lstTickets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.ScrollAlwaysVisible = true;
            this.lstTickets.Size = new System.Drawing.Size(324, 124);
            this.lstTickets.TabIndex = 16;
            // 
            // btnOptions
            // 
            this.btnOptions.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOptions.Location = new System.Drawing.Point(22, 334);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(78, 23);
            this.btnOptions.TabIndex = 14;
            this.btnOptions.Text = "&Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(267, 334);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // secondTimer
            // 
            this.secondTimer.Interval = 1000;
            this.secondTimer.Tick += new System.EventHandler(this.secondTimer_Tick);
            // 
            // frmTicketing
            // 
            this.AcceptButton = this.btnTicket;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(370, 367);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lstTickets);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTicketing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTicketing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNowServing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Label lblNextEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOutstanding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer secondTimer;
    }
}

