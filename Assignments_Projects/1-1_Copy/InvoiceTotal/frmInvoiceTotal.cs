using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }


        private void frmInvoiceTotal_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
         * 0m is how you say (decimal)0 because m is the suffix that means decimal.
        Other suffixes are f for float, d for double, u for unsigned, and l for long. 
        They can be either upper- or lower-case and u can be combined with l in either order to make a ulong.
         * 
         */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = 0m;

            if (subtotal > 500)
            {
                discountPercent = .2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            else if (subtotal >= 100 && subtotal < 250) 
            {
                discountPercent = .1m;
            }
            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            // Arguments for ToString is formatted text; c is 'currency'
            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c"); 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
