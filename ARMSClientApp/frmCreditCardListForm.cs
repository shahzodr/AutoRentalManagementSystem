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
    public partial class frmCreditCardListForm : Form
    {
        public frmCreditCardListForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close this form
            //program flow automatically goes back to Main Form
            //which opened this form aa a dialog form.
            this.Close();
        }

        private void frmCreditCardListForm_Load(object sender, EventArgs e)
        {
            dgvCreditCardList.AutoGenerateColumns = false;

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvCreditCardList.DataSource = CreditCard.GetAllCreditCards();
            dgvCreditCardList.Columns["cohCreditCardNumber"].DataPropertyName = "CreditCardNumber";
            dgvCreditCardList.Columns["cohCreditCardOwnerName"].DataPropertyName = "CreditCardOwnerName";
            dgvCreditCardList.Columns["cohCreditCardBank"].DataPropertyName = "MerchantName";
            dgvCreditCardList.Columns["cohExpirationDate"].DataPropertyName = "ExpDate";
            dgvCreditCardList.Columns["cohAddressLine1"].DataPropertyName = "AddressLine1";
            dgvCreditCardList.Columns["cohAddressLine2"].DataPropertyName = "AddressLine2";
            dgvCreditCardList.Columns["cohCity"].DataPropertyName = "City";
            dgvCreditCardList.Columns["cohState"].DataPropertyName = "State";
            dgvCreditCardList.Columns["cohZipCode"].DataPropertyName = "ZipCode";
            dgvCreditCardList.Columns["cohCountry"].DataPropertyName = "Country";
            dgvCreditCardList.Columns["cohCreditCardLimit"].DataPropertyName = "CreditCardLimit";
            dgvCreditCardList.Columns["cohCreditCardBalance"].DataPropertyName = "CreditCardBalance";
            dgvCreditCardList.Columns["cohActivationStatus"].DataPropertyName = "ActivationStatus";
        }
    }
}
