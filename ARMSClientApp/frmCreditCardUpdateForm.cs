using System;
using ARMSBOLayer;
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
    public partial class frmCreditCardUpdateForm : Form
    {
        public frmCreditCardUpdateForm()
        {
            InitializeComponent();
        }

        CreditCard objCreditCard;

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close this form
            //program flow automatically goes back to Main Form
            //which opened this form a dialog form.
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Call Credit Card Object Load(key) method to execute SELECT query
            //to the database and populate itself with the record returned
            //from the query
            bool success = objCreditCard.Load(txtCNumber.Text.Trim());

            //Step 2-If validate credit card is found
            if (success)
            {
                //Step 3-Then Data is extracted from customer object & placed on textboxes
                txtCreditCardNumber.Text = objCreditCard.CreditCardNumber;
                txtCardOwner.Text = objCreditCard.CreditCardOwnerName;
                txtCreditCardCompany.Text = objCreditCard.MerchantName;
                dateTimePickerExpDate.Text = objCreditCard.ExpDate.ToString();
                txtAddressLine1.Text = objCreditCard.AddressLine1;
                txtAddressLine2.Text = objCreditCard.AddressLine2;
                txtCity.Text = objCreditCard.City;
                comboBoxState.SelectedValue = objCreditCard.StateCode;
                txtZipcode.Text = objCreditCard.ZipCode;
                comboBoxCountry.SelectedValue = objCreditCard.Country;
                txtCreditCardBalance.Text = objCreditCard.CreditCardBalance.ToString();
                txtCreditCardLimit.Text = objCreditCard.CreditCardLimit.ToString();
                if (objCreditCard.ActivationStatus == true)
                {
                    txtActivationStatus.Text = "Activated";
                }
                else
                {
                    txtActivationStatus.Text = "Deactivated";
                }
            }
            else
            {
                //Step 4-prompt user credit card not found
                MessageBox.Show("Credit Card Not Found");
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Set Object with parameters values
            objCreditCard.CreditCardOwnerName = txtCardOwner.Text.Trim();
            objCreditCard.MerchantName = txtCreditCardCompany.Text.Trim();
            objCreditCard.ExpDate = Convert.ToDateTime(dateTimePickerExpDate.Text.Trim());
            objCreditCard.AddressLine1 = txtAddressLine1.Text.Trim();
            objCreditCard.AddressLine2 = txtAddressLine2.Text.Trim();
            objCreditCard.City = txtCity.Text.Trim();
            objCreditCard.StateCode = comboBoxState.SelectedValue.ToString();
            objCreditCard.ZipCode = txtZipcode.Text.Trim();
            objCreditCard.Country = comboBoxCountry.SelectedValue.ToString();
            objCreditCard.CreditCardLimit = Decimal.Parse(txtCreditCardLimit.Text.Trim());
            objCreditCard.CreditCardBalance = Decimal.Parse(txtCreditCardBalance.Text.Trim());

            //Call Credit Card Object Update()) method to execute Update query
            //Using the populated object's data to create Update query
            bool success = objCreditCard.Update();

            //Step 2-If validate credit card was added
            if (success)
            {
                //Prompt user customer was added
                MessageBox.Show("Credit Card Updated!");
                clearForm();
                fillComboBoxes();

            }
            else
            {
                //prompt user customer was not added
                MessageBox.Show("Error! Credit Card was not updated!");

            }
        }

        private void frmCreditCardUpdateForm_Load(object sender, EventArgs e)
        {
            objCreditCard = new CreditCard();
            fillComboBoxes();
        }

        private void clearForm()
        {
            txtCNumber.Text = "";
            txtCreditCardNumber.Text = "";
            txtCardOwner.Text = "";
            txtCreditCardCompany.Text = "";
            dateTimePickerExpDate.Value = DateTime.Now;
            txtAddressLine1.Text = "";
            txtAddressLine2.Text = "";
            txtCity.Text = "";
            comboBoxState.Text = "";
            txtZipcode.Text = "";
            comboBoxCountry.Text = "";
            txtCreditCardLimit.Text = "";
            txtCreditCardBalance.Text = "";
            txtActivationStatus.Text = "";

        }

        private void fillComboBoxes()
        {
            //objCreditCard = new CreditCard();
            comboBoxState.DataSource = USState.GetAllUSStates();
            comboBoxState.DisplayMember = "StateName";
            comboBoxState.ValueMember = "StateCode";

            comboBoxCountry.DataSource = Country.GetAllCountry();
            comboBoxCountry.DisplayMember = "CountryName";
            comboBoxCountry.ValueMember = "CountryName";
        }
    }
}
