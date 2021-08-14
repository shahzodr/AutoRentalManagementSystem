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
    public partial class frmERPSystemForm : Form
    {
        public frmERPSystemForm()
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

        private void btnCreditCardMS_Click(object sender, EventArgs e)
        {
            //Declare object of CreditCard Management System Form
            frmCreditCardMSForm objERP = new frmCreditCardMSForm();
            //Hide this form (frmERPSystemForm)
            this.Hide();
            //Display CreditCard Management System Form as Dialog Form
            //Dialog mode means program flow will STOP until the
            //CreditCard Management form Closes or Hides 
            objERP.ShowDialog();
            //Once the CreditCard Management System Form closes or hides,
            //Control goes back to this form and this form 
            //needs to Display itself since CreditCard Management System Form is
            //either hidden or closed.
            this.Show();
        }
    }
}
