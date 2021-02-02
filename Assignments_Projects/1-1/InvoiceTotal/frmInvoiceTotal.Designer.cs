
namespace InvoiceTotal
{
    partial class frmInvoiceTotal
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(112, 248);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(213, 248);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(72, 82);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(54, 15);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "&Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Location = new System.Drawing.Point(72, 121);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(100, 15);
            this.lblDiscountPercent.TabIndex = 7;
            this.lblDiscountPercent.Text = "&Discount Percent:";
            this.lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Location = new System.Drawing.Point(72, 164);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(104, 15);
            this.lblDiscountAmount.TabIndex = 8;
            this.lblDiscountAmount.Text = "&Discount Amount:";
            this.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(72, 203);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 15);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "&Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(188, 79);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.TabIndex = 1;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(188, 118);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(100, 23);
            this.txtDiscountPercent.TabIndex = 11;
            this.txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(188, 161);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 23);
            this.txtDiscountAmount.TabIndex = 12;
            this.txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(188, 200);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(138, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(152, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Jacob Graham";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmInvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(409, 351);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmInvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.Load += new System.EventHandler(this.frmInvoiceTotal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblName;
    }
}

