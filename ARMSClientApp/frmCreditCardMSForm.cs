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
    public partial class frmCreditCardMSForm : Form
    {
        public frmCreditCardMSForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Declare object of Update Form
            frmCreditCardUpdateForm objERP3 = new frmCreditCardUpdateForm();
            //Hide this form (frmCreditCardMSForm)
            this.Hide();
            //Display Update Form as Dialog Form
            //Dialog mode means program flow will STOP until the
            //Update form Closes or Hides 
            objERP3.ShowDialog();
            //Once the Update Form closes or hides,
            //Control goes back to this form and this form 
            //needs to Display itself since Update Form is
            //either hidden or closed.
            this.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            //Declare object of Registration Form
            frmCreditCardRegistrationForm objERP2 = new frmCreditCardRegistrationForm();
            //Hide this form (frmCreditCardMSForm)
            this.Hide();
            //Display Registration Form as Dialog Form
            //Dialog mode means program flow will STOP until the
            //Registration form Closes or Hides 
            objERP2.ShowDialog();
            //Once the Registration Form closes or hides,
            //Control goes back to this form and this form 
            //needs to Display itself since Registration Form is
            //either hidden or closed.
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close this form
            //program flow automatically goes back to ERP System Form
            //which opened this form aa a dialog form.
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Declare object of Search Form
            frmCreditCardSearchForm objERP1 = new frmCreditCardSearchForm();
            //Hide this form (frmCreditCardMSForm)
            this.Hide();
            //Display Search Form as Dialog Form
            //Dialog mode means program flow will STOP until the
            //Search form Closes or Hides 
            objERP1.ShowDialog();
            //Once the Search Form closes or hides,
            //Control goes back to this form and this form 
            //needs to Display itself since Search Form is
            //either hidden or closed.
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Declare object of Delete Form
            frmCreditCardDeleteForm objERP4 = new frmCreditCardDeleteForm();
            //Hide this form (frmCreditCardMSForm)
            this.Hide();
            //Display Delete Form as Dialog Form
            //Dialog mode means program flow will STOP until the
            //Delete form Closes or Hides 
            objERP4.ShowDialog();
            //Once the Delete Form closes or hides,
            //Control goes back to this form and this form 
            //needs to Display itself since Delete Form is
            //either hidden or closed.
            this.Show();
        }

        private void btnCreditCardList_Click(object sender, EventArgs e)
        {
            //Declare object of Delete Form
            frmCreditCardListForm objERP5 = new frmCreditCardListForm();
            //Hide this form (frmCreditCardMSForm)
            this.Hide();
            //Display Delete Form as Dialog Form
            //Dialog mode means program flow will STOP until the
            //Delete form Closes or Hides 
            objERP5.ShowDialog();
            //Once the Delete Form closes or hides,
            //Control goes back to this form and this form 
            //needs to Display itself since Delete Form is
            //either hidden or closed.
            this.Show();
        }
    }
}
