using ARMSBOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSClientApp
{
    public partial class frmCreditCardSearchForm : Form
    {
        CreditCard creditCardObj;
        public frmCreditCardSearchForm()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(creditCardObj != null)
            {
                creditCardObj.Print();
                MessageBox.Show("Card information has been saved to Network_Printer.txt");
            }
            else
            {
                MessageBox.Show("Enter Credit Card Number in \"Credit Card Search\" Section");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            creditCardObj = new CreditCard();
            

            if(creditCardObj.Load(txtCNumber.Text) != false)
            {
                txtCardNumber.Text = creditCardObj.CreditCardNumber;
                txtCardOwner.Text = creditCardObj.CreditCardOwnerName;
                txtCreditCardCompany.Text = creditCardObj.MerchantName;
                txtExpDate.Text = creditCardObj.ExpDate.ToString();
                txtAddressLine1.Text = creditCardObj.AddressLine1;
                txtAddressLine2.Text = creditCardObj.AddressLine2;
                txtCity.Text = creditCardObj.City;
                txtState.Text = creditCardObj.StateCode;
                txtZipCode.Text = creditCardObj.ZipCode;
                txtCountry.Text = creditCardObj.Country;
                txtCreditCardBalance.Text = creditCardObj.CreditCardBalance.ToString();
                txtCreditCardLimit.Text = creditCardObj.CreditCardLimit.ToString();

                txtActivationStatus.Text = creditCardObj.ActivationStatus ? "Activated" : "Deactivated";
            }
            else
            {
                MessageBox.Show("Credit Card Not found");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
