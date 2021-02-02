
namespace PaymentForm
{
    partial class frmCustomers
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
            this.cboNames = new System.Windows.Forms.ComboBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelectPayment = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboNames
            // 
            this.cboNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNames.FormattingEnabled = true;
            this.cboNames.Location = new System.Drawing.Point(121, 30);
            this.cboNames.Name = "cboNames";
            this.cboNames.Size = new System.Drawing.Size(152, 21);
            this.cboNames.TabIndex = 0;
            this.cboNames.SelectedIndexChanged += new System.EventHandler(this.cboNames_SelectedIndexChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(22, 33);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(83, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "&Customer name:";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(345, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "S&ave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelectPayment
            // 
            this.btnSelectPayment.Location = new System.Drawing.Point(279, 93);
            this.btnSelectPayment.Name = "btnSelectPayment";
            this.btnSelectPayment.Size = new System.Drawing.Size(91, 23);
            this.btnSelectPayment.TabIndex = 4;
            this.btnSelectPayment.Text = "S&elect Payment";
            this.btnSelectPayment.UseVisualStyleBackColor = true;
            this.btnSelectPayment.Click += new System.EventHandler(this.btnSelectPayment_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayment.Location = new System.Drawing.Point(25, 93);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(248, 83);
            this.lblPayment.TabIndex = 5;
            this.lblPayment.Text = "PlaceholderText";
            this.lblPayment.TextChanged += new System.EventHandler(this.lblPayment_TextChanged);
            this.lblPayment.Click += new System.EventHandler(this.lblPayment_Click);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(22, 65);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(89, 13);
            this.lblPaymentMethod.TabIndex = 6;
            this.lblPaymentMethod.Text = "&Payment method:";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 267);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.btnSelectPayment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.cboNames);
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomers_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNames;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelectPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblPaymentMethod;
    }
}