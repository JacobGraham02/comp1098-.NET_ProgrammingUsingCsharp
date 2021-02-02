using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentForm
{
    public partial class frmPayments : Form
    {
        List<int> next5Years = new List<int>();
        public frmPayments()
        {
            InitializeComponent();
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i < 5; i++)
            {
                next5Years.Add(i);
            }
        }

        private void lstBoxCreditCardType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboExpirationYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboExpirationMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                this.SaveData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            lstBoxCreditCardType.Items.Add("Visa");
            lstBoxCreditCardType.Items.Add("Mastercard");
            lstBoxCreditCardType.Items.Add("American Express");
            lstBoxCreditCardType.SelectedIndex = 0;

            string[] months = {"Select a month...", "January","February","March","April","May",
                                                    "June","July","August","September","October",
                                                    "November","December"};

            foreach(string month in months)
            {
                cboExpirationMonth.Items.Add(month);
            }
            cboExpirationMonth.SelectedIndex = 0;

            int year = DateTime.Today.Year;
            int endYear = year + 8;
            cboExpirationYear.Items.Add("Select a year...");

            while (year < endYear)
            {
                cboExpirationYear.Items.Add(year);
                year++;
            }
            cboExpirationYear.SelectedIndex = 0;

        }
        private bool IsValidData()
        {
            if (rdoCreditCard.Checked)
            {
                if (lstBoxCreditCardType.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a credit card type.", "Entry Error");
                    lstBoxCreditCardType.Focus();
                    return false;
                }
                if (txtCardNumber.Text == "")
                {
                    MessageBox.Show("You must select a credit card number.", "Entry Error");
                    txtCardNumber.Focus();
                    return false;
                }
                if (cboExpirationMonth.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select an expiration month.", "Entry Error");
                    cboExpirationMonth.Focus();
                    return false;
                }
                if (cboExpirationYear.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select an expiration year.", "Entry Error");
                    cboExpirationYear.Focus();
                    return false;
                }

            }
            return true;
        }
        private void SaveData()
        {
            string msg = null;
            
            if (rdoCreditCard.Checked) // Implicity checks for 'true'
            {
                msg += "Charge to credit card." + "\n\n";
                msg += "Card type: " + lstBoxCreditCardType.Text + "\n";
                msg += "Card number: " + txtCardNumber.Text + "\n";
                msg += "Expiration date: " + cboExpirationMonth.Text + "/" + cboExpirationYear.Text + "\n";
            }
            else
            {
                msg += "Send bill to customer." + "\n\n";
            }

            bool isDefaultBilling = chkDefault.Checked;
            msg += "Default Billing: " + isDefaultBilling;

            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }

        private void rdoCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCreditCard.Checked)
            {
                EnableControls();
            } 
            else
            {
                DisableControls();
            }
        }

        private void EnableControls()
        {
            lstBoxCreditCardType.Enabled = true;
            txtCardNumber.Enabled = true;
            cboExpirationMonth.Enabled = true;
            cboExpirationYear.Enabled = true;
        }

        private void DisableControls()
        {
            lstBoxCreditCardType.Enabled = false;
            txtCardNumber.Enabled = false;
            cboExpirationMonth.Enabled = false;
            cboExpirationYear.Enabled = false;
        }

    }
}
