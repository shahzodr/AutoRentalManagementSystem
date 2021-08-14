
namespace ARMSClientApp
{
    partial class frmCreditCardListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvCreditCardList = new System.Windows.Forms.DataGridView();
            this.cohCreditCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCreditCardOwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCreditCardBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohAddressLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohAddressLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCreditCardLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohCreditCardBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohActivationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREDITCARDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnList = new System.Windows.Forms.Button();
            this.txtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCardList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITCARDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnExit.Location = new System.Drawing.Point(451, 492);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 26);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvCreditCardList
            // 
            this.dgvCreditCardList.AllowUserToAddRows = false;
            this.dgvCreditCardList.AllowUserToDeleteRows = false;
            this.dgvCreditCardList.AllowUserToResizeColumns = false;
            this.dgvCreditCardList.AllowUserToResizeRows = false;
            this.dgvCreditCardList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreditCardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCreditCardList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cohCreditCardNumber,
            this.cohCreditCardOwnerName,
            this.cohCreditCardBank,
            this.cohExpirationDate,
            this.cohAddressLine1,
            this.cohAddressLine2,
            this.cohCity,
            this.cohState,
            this.cohZipCode,
            this.cohCountry,
            this.cohCreditCardLimit,
            this.cohCreditCardBalance,
            this.cohActivationStatus});
            this.dgvCreditCardList.EnableHeadersVisualStyles = false;
            this.dgvCreditCardList.Location = new System.Drawing.Point(1, 53);
            this.dgvCreditCardList.MultiSelect = false;
            this.dgvCreditCardList.Name = "dgvCreditCardList";
            this.dgvCreditCardList.ReadOnly = true;
            this.dgvCreditCardList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCreditCardList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditCardList.Size = new System.Drawing.Size(1253, 412);
            this.dgvCreditCardList.TabIndex = 1;
            // 
            // cohCreditCardNumber
            // 
            this.cohCreditCardNumber.HeaderText = "Card Number";
            this.cohCreditCardNumber.Name = "cohCreditCardNumber";
            this.cohCreditCardNumber.ReadOnly = true;
            this.cohCreditCardNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cohCreditCardOwnerName
            // 
            this.cohCreditCardOwnerName.HeaderText = "Owner Name";
            this.cohCreditCardOwnerName.Name = "cohCreditCardOwnerName";
            this.cohCreditCardOwnerName.ReadOnly = true;
            // 
            // cohCreditCardBank
            // 
            this.cohCreditCardBank.HeaderText = "Card Company";
            this.cohCreditCardBank.Name = "cohCreditCardBank";
            this.cohCreditCardBank.ReadOnly = true;
            // 
            // cohExpirationDate
            // 
            this.cohExpirationDate.HeaderText = "Expiration Date";
            this.cohExpirationDate.Name = "cohExpirationDate";
            this.cohExpirationDate.ReadOnly = true;
            // 
            // cohAddressLine1
            // 
            this.cohAddressLine1.HeaderText = "Address Line 1";
            this.cohAddressLine1.Name = "cohAddressLine1";
            this.cohAddressLine1.ReadOnly = true;
            // 
            // cohAddressLine2
            // 
            this.cohAddressLine2.HeaderText = "Address Line 2";
            this.cohAddressLine2.Name = "cohAddressLine2";
            this.cohAddressLine2.ReadOnly = true;
            // 
            // cohCity
            // 
            this.cohCity.HeaderText = "City";
            this.cohCity.Name = "cohCity";
            this.cohCity.ReadOnly = true;
            // 
            // cohState
            // 
            this.cohState.HeaderText = "State";
            this.cohState.Name = "cohState";
            this.cohState.ReadOnly = true;
            // 
            // cohZipCode
            // 
            this.cohZipCode.HeaderText = "ZipCode";
            this.cohZipCode.Name = "cohZipCode";
            this.cohZipCode.ReadOnly = true;
            // 
            // cohCountry
            // 
            this.cohCountry.HeaderText = "Country";
            this.cohCountry.Name = "cohCountry";
            this.cohCountry.ReadOnly = true;
            // 
            // cohCreditCardLimit
            // 
            this.cohCreditCardLimit.HeaderText = "Credit Limit";
            this.cohCreditCardLimit.Name = "cohCreditCardLimit";
            this.cohCreditCardLimit.ReadOnly = true;
            // 
            // cohCreditCardBalance
            // 
            this.cohCreditCardBalance.HeaderText = "Credit Balance";
            this.cohCreditCardBalance.Name = "cohCreditCardBalance";
            this.cohCreditCardBalance.ReadOnly = true;
            // 
            // cohActivationStatus
            // 
            this.cohActivationStatus.HeaderText = "Activation Status";
            this.cohActivationStatus.Name = "cohActivationStatus";
            this.cohActivationStatus.ReadOnly = true;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnList.Location = new System.Drawing.Point(647, 492);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(135, 26);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "List All Credit Cards";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.txtLabel.Location = new System.Drawing.Point(564, 18);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(126, 18);
            this.txtLabel.TabIndex = 3;
            this.txtLabel.Text = "Credit Card List";
            // 
            // frmCreditCardListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 542);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dgvCreditCardList);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCreditCardListForm";
            this.Text = "Credit Card List";
            this.Load += new System.EventHandler(this.frmCreditCardListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCardList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITCARDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvCreditCardList;
        private System.Windows.Forms.BindingSource cREDITCARDBindingSource;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardOwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohAddressLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohAddressLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohCreditCardBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohActivationStatus;
    }
}