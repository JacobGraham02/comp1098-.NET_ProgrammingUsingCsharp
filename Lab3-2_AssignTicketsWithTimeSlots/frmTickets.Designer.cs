
namespace Lab3_2_AssignTicketsWithTimeSlots
{
    partial class frmTickets
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
            this.grpBoxGuestsWithFollowingTickets = new System.Windows.Forms.GroupBox();
            this.lblGuestsWithFollowingTickets = new System.Windows.Forms.Label();
            this.grpBoxTicketAvailability = new System.Windows.Forms.GroupBox();
            this.btnIssueTicket = new System.Windows.Forms.Button();
            this.txtNextAvailableEntry = new System.Windows.Forms.TextBox();
            this.txtTotalTicketsOutstanding = new System.Windows.Forms.TextBox();
            this.lblNextAvailableEntry = new System.Windows.Forms.Label();
            this.lblTotalTicketsOutstanding = new System.Windows.Forms.Label();
            this.lstBoxTickets = new System.Windows.Forms.ListBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxGuestsWithFollowingTickets.SuspendLayout();
            this.grpBoxTicketAvailability.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxGuestsWithFollowingTickets
            // 
            this.grpBoxGuestsWithFollowingTickets.Controls.Add(this.lblGuestsWithFollowingTickets);
            this.grpBoxGuestsWithFollowingTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxGuestsWithFollowingTickets.Location = new System.Drawing.Point(15, 12);
            this.grpBoxGuestsWithFollowingTickets.Name = "grpBoxGuestsWithFollowingTickets";
            this.grpBoxGuestsWithFollowingTickets.Size = new System.Drawing.Size(327, 68);
            this.grpBoxGuestsWithFollowingTickets.TabIndex = 1;
            this.grpBoxGuestsWithFollowingTickets.TabStop = false;
            this.grpBoxGuestsWithFollowingTickets.Text = "Guests with the following tickets may enter:";
            // 
            // lblGuestsWithFollowingTickets
            // 
            this.lblGuestsWithFollowingTickets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGuestsWithFollowingTickets.Location = new System.Drawing.Point(6, 30);
            this.lblGuestsWithFollowingTickets.Name = "lblGuestsWithFollowingTickets";
            this.lblGuestsWithFollowingTickets.Size = new System.Drawing.Size(87, 20);
            this.lblGuestsWithFollowingTickets.TabIndex = 0;
            this.lblGuestsWithFollowingTickets.Text = "placeholder";
            // 
            // grpBoxTicketAvailability
            // 
            this.grpBoxTicketAvailability.Controls.Add(this.btnIssueTicket);
            this.grpBoxTicketAvailability.Controls.Add(this.txtNextAvailableEntry);
            this.grpBoxTicketAvailability.Controls.Add(this.txtTotalTicketsOutstanding);
            this.grpBoxTicketAvailability.Controls.Add(this.lblNextAvailableEntry);
            this.grpBoxTicketAvailability.Controls.Add(this.lblTotalTicketsOutstanding);
            this.grpBoxTicketAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTicketAvailability.Location = new System.Drawing.Point(15, 87);
            this.grpBoxTicketAvailability.Name = "grpBoxTicketAvailability";
            this.grpBoxTicketAvailability.Size = new System.Drawing.Size(327, 134);
            this.grpBoxTicketAvailability.TabIndex = 2;
            this.grpBoxTicketAvailability.TabStop = false;
            this.grpBoxTicketAvailability.Text = "Ticket Availability:";
            // 
            // btnIssueTicket
            // 
            this.btnIssueTicket.Location = new System.Drawing.Point(7, 94);
            this.btnIssueTicket.Name = "btnIssueTicket";
            this.btnIssueTicket.Size = new System.Drawing.Size(136, 24);
            this.btnIssueTicket.TabIndex = 1;
            this.btnIssueTicket.Text = "Issue Ticket";
            this.btnIssueTicket.UseVisualStyleBackColor = true;
            this.btnIssueTicket.Click += new System.EventHandler(this.btnIssueTicket_Click);
            // 
            // txtNextAvailableEntry
            // 
            this.txtNextAvailableEntry.Enabled = false;
            this.txtNextAvailableEntry.Location = new System.Drawing.Point(178, 54);
            this.txtNextAvailableEntry.Name = "txtNextAvailableEntry";
            this.txtNextAvailableEntry.Size = new System.Drawing.Size(100, 22);
            this.txtNextAvailableEntry.TabIndex = 3;
            this.txtNextAvailableEntry.TabStop = false;
            // 
            // txtTotalTicketsOutstanding
            // 
            this.txtTotalTicketsOutstanding.Enabled = false;
            this.txtTotalTicketsOutstanding.Location = new System.Drawing.Point(178, 20);
            this.txtTotalTicketsOutstanding.Name = "txtTotalTicketsOutstanding";
            this.txtTotalTicketsOutstanding.Size = new System.Drawing.Size(100, 22);
            this.txtTotalTicketsOutstanding.TabIndex = 2;
            this.txtTotalTicketsOutstanding.TabStop = false;
            // 
            // lblNextAvailableEntry
            // 
            this.lblNextAvailableEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNextAvailableEntry.Location = new System.Drawing.Point(7, 56);
            this.lblNextAvailableEntry.Name = "lblNextAvailableEntry";
            this.lblNextAvailableEntry.Size = new System.Drawing.Size(165, 19);
            this.lblNextAvailableEntry.TabIndex = 1;
            this.lblNextAvailableEntry.Text = "Next available entry:";
            // 
            // lblTotalTicketsOutstanding
            // 
            this.lblTotalTicketsOutstanding.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalTicketsOutstanding.Location = new System.Drawing.Point(7, 22);
            this.lblTotalTicketsOutstanding.Name = "lblTotalTicketsOutstanding";
            this.lblTotalTicketsOutstanding.Size = new System.Drawing.Size(165, 19);
            this.lblTotalTicketsOutstanding.TabIndex = 0;
            this.lblTotalTicketsOutstanding.Text = "Total tickets outstanding:";
            // 
            // lstBoxTickets
            // 
            this.lstBoxTickets.FormattingEnabled = true;
            this.lstBoxTickets.Location = new System.Drawing.Point(13, 228);
            this.lstBoxTickets.Name = "lstBoxTickets";
            this.lstBoxTickets.ScrollAlwaysVisible = true;
            this.lstBoxTickets.Size = new System.Drawing.Size(329, 147);
            this.lstBoxTickets.TabIndex = 3;
            this.lstBoxTickets.TabStop = false;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(13, 396);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(242, 396);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lstBoxTickets);
            this.Controls.Add(this.grpBoxTicketAvailability);
            this.Controls.Add(this.grpBoxGuestsWithFollowingTickets);
            this.Name = "frmTickets";
            this.grpBoxGuestsWithFollowingTickets.ResumeLayout(false);
            this.grpBoxTicketAvailability.ResumeLayout(false);
            this.grpBoxTicketAvailability.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxGuestsWithFollowingTickets;
        private System.Windows.Forms.GroupBox grpBoxTicketAvailability;
        private System.Windows.Forms.Label lblGuestsWithFollowingTickets;
        private System.Windows.Forms.Label lblNextAvailableEntry;
        private System.Windows.Forms.Label lblTotalTicketsOutstanding;
        private System.Windows.Forms.TextBox txtNextAvailableEntry;
        private System.Windows.Forms.TextBox txtTotalTicketsOutstanding;
        private System.Windows.Forms.Button btnIssueTicket;
        private System.Windows.Forms.ListBox lstBoxTickets;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
    }
}

