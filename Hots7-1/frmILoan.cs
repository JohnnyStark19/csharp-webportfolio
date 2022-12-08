using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hots7_1
{
    public partial class frmILoan : Form
    {
        public frmILoan()
        {
            InitializeComponent();
        }

        const double SHORT = 450;
        const double SHORTINT = 0.10;
        const double LONG = 200;
        const double LONGINT = 0.05;
        

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblNameOutput_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtAmount.Text);
            if (num <= 0)
            {
                MessageBox.Show("Loan amount can not be a negative", "PLEASE INPUT ANOTHER LOAN AMOUNT", MessageBoxButtons.OK);

            }
            else
            {
                RadioIsChecked();
            }

        }

        private void RadioIsChecked()
        {
            if (rbShortTerm.Checked)
            {
                double st = Convert.ToDouble(txtAmount.Text);
                lblNameOutput.Text = txtName.Text;
                lblTypeAndAmount.Text = "Short-Term Loan of" + " " + st.ToString("c");
               
            }
            else if (rbLongTerm.Checked)
            {
                double lt = Convert.ToDouble(txtAmount.Text);
                lblNameOutput.Text = txtName.Text;
                lblTypeAndAmount.Text = "Long-Term Loan of" + " " + lt.ToString("c");
            }
            
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            if (rbShortTerm.Checked)
            {
                double st = Convert.ToDouble(txtAmount.Text);
                double pay = st - SHORT;
                double pay2 = pay * SHORTINT;
                double pay3 = pay + pay2;
                lblPaymentOutput.Text = "After the last payment the loan is down to" + " " + pay.ToString("c");  
                lblInterestOutput.Text = "After the last interest accumulation the loan is now" + " " + pay3.ToString("c");
            }
            else if (rbLongTerm.Checked)
            {
                double lt = Convert.ToDouble(txtAmount.Text);
                double pay = lt - LONG;
                double pay2 = pay * LONGINT;
                double pay3 = pay + pay2;
                lblPaymentOutput.Text = "After the last payment the loan is down to" + " " + pay.ToString("c");
                lblInterestOutput.Text = "After the last interest accumulation the loan is now" + " " + pay3.ToString("c");
            }
        }
    }
}
