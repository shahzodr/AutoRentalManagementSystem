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
    public partial class frmCreditCardRegistrationForm : Form
    {
        private string creditCardLmtInitalVal = "3000";
        private string creditCardBalInitalVal = "3000";

        public frmCreditCardRegistrationForm()
        {
            InitializeComponent();
        }

        private void frmCreditCardRegistrationForm_Load(object sender, EventArgs e)
        {
            fillComboBoxes();
            initilizeFields();
        }

        private void fillComboBoxes()
        {
            comboBoxState.DataSource = USState.GetAllUSStates();
            comboBoxState.DisplayMember = "StateName";
            comboBoxState.ValueMember = "StateCode";

            comboBoxCountry.DataSource = Country.GetAllCountry();
            comboBoxCountry.DisplayMember = "CountryName";
            comboBoxCountry.ValueMember = "CountryName";
            comboBoxActivationStatus.Text = "Activated";
        }

        private void initilizeFields()
        {
            txtCreditCardBalance.Text = creditCardBalInitalVal;
            txtCreditCardLimit.Text = creditCardLmtInitalVal;
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            
            //Create CreditCard Object
            CreditCard objCard = new CreditCard();

            //Set Credit Card Object with Data from form
            objCard.CreditCardNumber = txtCreditCardNumber.Text;
            objCard.CreditCardOwnerName = txtCardOwner.Text;
            objCard.MerchantName = txtCreditCardCompany.Text;
            objCard.ExpDate = dateTimePickerExpDate.Value.Date;
            objCard.AddressLine1 = txtAddressLine1.Text;
            objCard.AddressLine2 = txtAddressLine2.Text;
            objCard.City = txtCity.Text;
            
            objCard.StateCode = comboBoxState.SelectedValue.ToString();
            objCard.ZipCode = txtZipCode.Text;
            objCard.Country = comboBoxCountry.Text;
            
            objCard.CreditCardLimit = Convert.ToDecimal(txtCreditCardLimit.Text);
            objCard.CreditCardBalance = Convert.ToDecimal(txtCreditCardBalance.Text);
            
           

            //Call Insert() to add data to database

            bool success = objCard.Insert();

            if (success)
            {
                MessageBox.Show("Customer Added");
            }
            else
            {
                MessageBox.Show("Invalid Entry");
            }
            clearForm();
            
        }

        private void clearForm()
        {
            txtCreditCardNumber.Text = "";
            txtCardOwner.Text = "";
            txtCreditCardCompany.Text = "";
            txtAddressLine1.Text = "";
            txtAddressLine2.Text = "";
            txtCity.Text = "";
            txtZipCode.Text = "";
            initilizeFields();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerExpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
