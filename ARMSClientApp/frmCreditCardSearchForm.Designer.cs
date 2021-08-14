namespace ARMSClientApp
{
    partial class frmCreditCardSearchForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardOwner = new System.Windows.Forms.Label();
            this.grpCardNumberSearch = new System.Windows.Forms.GroupBox();
            this.grpCCInfo = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtActivationStatus = new System.Windows.Forms.TextBox();
            this.lblActivationStatus = new System.Windows.Forms.Label();
            this.txtCreditCardLimit = new System.Windows.Forms.TextBox();
            this.lblCreditCardLimit = new System.Windows.Forms.Label();
            this.txtCreditCardBalance = new System.Windows.Forms.TextBox();
            this.lblCreditCardBalance = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.txtCreditCardCompany = new System.Windows.Forms.TextBox();
            this.lblCreditCardCompany = new System.Windows.Forms.Label();
            this.txtCardOwner = new System.Windows.Forms.TextBox();
            this.grpCardNumberSearch.SuspendLayout();
            this.grpCCInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(265, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Credit Card Search";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(0, 33);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(202, 13);
            this.lblEnter.TabIndex = 1;
            this.lblEnter.Text = "Enter Credit Card Number && Click Search:";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(3, 61);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(80, 13);
            this.lblCardNumber.TabIndex = 2;
            this.lblCardNumber.Text = "Card Number";
            // 
            // txtCNumber
            // 
            this.txtCNumber.Location = new System.Drawing.Point(160, 58);
            this.txtCNumber.Name = "txtCNumber";
            this.txtCNumber.Size = new System.Drawing.Size(147, 20);
            this.txtCNumber.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(327, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 24);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(117, 13);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Credit Card Information:";
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(3, 47);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(117, 13);
            this.lblCreditCardNumber.TabIndex = 6;
            this.lblCreditCardNumber.Text = "Credit Card Number";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(160, 44);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.ReadOnly = true;
            this.txtCardNumber.Size = new System.Drawing.Size(147, 20);
            this.txtCardNumber.TabIndex = 7;
            // 
            // lblCardOwner
            // 
            this.lblCardOwner.AutoSize = true;
            this.lblCardOwner.Location = new System.Drawing.Point(3, 73);
            this.lblCardOwner.Name = "lblCardOwner";
            this.lblCardOwner.Size = new System.Drawing.Size(94, 13);
            this.lblCardOwner.TabIndex = 8;
            this.lblCardOwner.Text = "Card Owner Name";
            // 
            // grpCardNumberSearch
            // 
            this.grpCardNumberSearch.Controls.Add(this.txtCNumber);
            this.grpCardNumberSearch.Controls.Add(this.lblEnter);
            this.grpCardNumberSearch.Controls.Add(this.lblCardNumber);
            this.grpCardNumberSearch.Controls.Add(this.btnSearch);
            this.grpCardNumberSearch.Location = new System.Drawing.Point(72, 67);
            this.grpCardNumberSearch.Name = "grpCardNumberSearch";
            this.grpCardNumberSearch.Size = new System.Drawing.Size(490, 100);
            this.grpCardNumberSearch.TabIndex = 9;
            this.grpCardNumberSearch.TabStop = false;
            // 
            // grpCCInfo
            // 
            this.grpCCInfo.Controls.Add(this.btnPrint);
            this.grpCCInfo.Controls.Add(this.btnExit);
            this.grpCCInfo.Controls.Add(this.txtActivationStatus);
            this.grpCCInfo.Controls.Add(this.lblActivationStatus);
            this.grpCCInfo.Controls.Add(this.txtCreditCardLimit);
            this.grpCCInfo.Controls.Add(this.lblCreditCardLimit);
            this.grpCCInfo.Controls.Add(this.txtCreditCardBalance);
            this.grpCCInfo.Controls.Add(this.lblCreditCardBalance);
            this.grpCCInfo.Controls.Add(this.txtZipCode);
            this.grpCCInfo.Controls.Add(this.lblZipCode);
            this.grpCCInfo.Controls.Add(this.txtCountry);
            this.grpCCInfo.Controls.Add(this.lblCountry);
            this.grpCCInfo.Controls.Add(this.txtState);
            this.grpCCInfo.Controls.Add(this.lblState);
            this.grpCCInfo.Controls.Add(this.txtCity);
            this.grpCCInfo.Controls.Add(this.txtAddressLine2);
            this.grpCCInfo.Controls.Add(this.lblCity);
            this.grpCCInfo.Controls.Add(this.lblAddressLine2);
            this.grpCCInfo.Controls.Add(this.txtAddressLine1);
            this.grpCCInfo.Controls.Add(this.lblAddressLine1);
            this.grpCCInfo.Controls.Add(this.txtExpDate);
            this.grpCCInfo.Controls.Add(this.lblExpDate);
            this.grpCCInfo.Controls.Add(this.txtCreditCardCompany);
            this.grpCCInfo.Controls.Add(this.lblCreditCardCompany);
            this.grpCCInfo.Controls.Add(this.txtCardOwner);
            this.grpCCInfo.Controls.Add(this.lblCreditCardNumber);
            this.grpCCInfo.Controls.Add(this.lblInfo);
            this.grpCCInfo.Controls.Add(this.lblCardOwner);
            this.grpCCInfo.Controls.Add(this.txtCardNumber);
            this.grpCCInfo.Location = new System.Drawing.Point(72, 183);
            this.grpCCInfo.Name = "grpCCInfo";
            this.grpCCInfo.Size = new System.Drawing.Size(490, 416);
            this.grpCCInfo.TabIndex = 10;
            this.grpCCInfo.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(358, 349);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 33;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(358, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtActivationStatus
            // 
            this.txtActivationStatus.Location = new System.Drawing.Point(160, 356);
            this.txtActivationStatus.Name = "txtActivationStatus";
            this.txtActivationStatus.ReadOnly = true;
            this.txtActivationStatus.Size = new System.Drawing.Size(147, 20);
            this.txtActivationStatus.TabIndex = 31;
            // 
            // lblActivationStatus
            // 
            this.lblActivationStatus.AutoSize = true;
            this.lblActivationStatus.Location = new System.Drawing.Point(3, 359);
            this.lblActivationStatus.Name = "lblActivationStatus";
            this.lblActivationStatus.Size = new System.Drawing.Size(87, 13);
            this.lblActivationStatus.TabIndex = 30;
            this.lblActivationStatus.Text = "Activation Status";
            // 
            // txtCreditCardLimit
            // 
            this.txtCreditCardLimit.Location = new System.Drawing.Point(160, 304);
            this.txtCreditCardLimit.Name = "txtCreditCardLimit";
            this.txtCreditCardLimit.ReadOnly = true;
            this.txtCreditCardLimit.Size = new System.Drawing.Size(147, 20);
            this.txtCreditCardLimit.TabIndex = 29;
            // 
            // lblCreditCardLimit
            // 
            this.lblCreditCardLimit.AutoSize = true;
            this.lblCreditCardLimit.Location = new System.Drawing.Point(3, 307);
            this.lblCreditCardLimit.Name = "lblCreditCardLimit";
            this.lblCreditCardLimit.Size = new System.Drawing.Size(83, 13);
            this.lblCreditCardLimit.TabIndex = 28;
            this.lblCreditCardLimit.Text = "Credit Card Limit";
            // 
            // txtCreditCardBalance
            // 
            this.txtCreditCardBalance.Location = new System.Drawing.Point(160, 330);
            this.txtCreditCardBalance.Name = "txtCreditCardBalance";
            this.txtCreditCardBalance.ReadOnly = true;
            this.txtCreditCardBalance.Size = new System.Drawing.Size(147, 20);
            this.txtCreditCardBalance.TabIndex = 27;
            // 
            // lblCreditCardBalance
            // 
            this.lblCreditCardBalance.AutoSize = true;
            this.lblCreditCardBalance.Location = new System.Drawing.Point(3, 333);
            this.lblCreditCardBalance.Name = "lblCreditCardBalance";
            this.lblCreditCardBalance.Size = new System.Drawing.Size(101, 13);
            this.lblCreditCardBalance.TabIndex = 26;
            this.lblCreditCardBalance.Text = "Credit Card Balance";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(160, 252);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.ReadOnly = true;
            this.txtZipCode.Size = new System.Drawing.Size(147, 20);
            this.txtZipCode.TabIndex = 25;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(3, 255);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 24;
            this.lblZipCode.Text = "Zip Code";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(160, 278);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(147, 20);
            this.txtCountry.TabIndex = 23;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(3, 281);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 22;
            this.lblCountry.Text = "Country";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(160, 226);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(147, 20);
            this.txtState.TabIndex = 21;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(3, 229);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 20;
            this.lblState.Text = "State";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(160, 200);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(147, 20);
            this.txtCity.TabIndex = 19;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(160, 174);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.ReadOnly = true;
            this.txtAddressLine2.Size = new System.Drawing.Size(147, 20);
            this.txtAddressLine2.TabIndex = 18;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(3, 203);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "City";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(3, 177);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 16;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(160, 148);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.ReadOnly = true;
            this.txtAddressLine1.Size = new System.Drawing.Size(147, 20);
            this.txtAddressLine1.TabIndex = 15;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(3, 151);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 14;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(160, 122);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.ReadOnly = true;
            this.txtExpDate.Size = new System.Drawing.Size(147, 20);
            this.txtExpDate.TabIndex = 13;
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(3, 125);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(79, 13);
            this.lblExpDate.TabIndex = 12;
            this.lblExpDate.Text = "Expiration Date";
            // 
            // txtCreditCardCompany
            // 
            this.txtCreditCardCompany.Location = new System.Drawing.Point(160, 96);
            this.txtCreditCardCompany.Name = "txtCreditCardCompany";
            this.txtCreditCardCompany.ReadOnly = true;
            this.txtCreditCardCompany.Size = new System.Drawing.Size(147, 20);
            this.txtCreditCardCompany.TabIndex = 11;
            // 
            // lblCreditCardCompany
            // 
            this.lblCreditCardCompany.AutoSize = true;
            this.lblCreditCardCompany.Location = new System.Drawing.Point(3, 99);
            this.lblCreditCardCompany.Name = "lblCreditCardCompany";
            this.lblCreditCardCompany.Size = new System.Drawing.Size(106, 13);
            this.lblCreditCardCompany.TabIndex = 10;
            this.lblCreditCardCompany.Text = "Credit Card Company";
            // 
            // txtCardOwner
            // 
            this.txtCardOwner.Location = new System.Drawing.Point(160, 70);
            this.txtCardOwner.Name = "txtCardOwner";
            this.txtCardOwner.ReadOnly = true;
            this.txtCardOwner.Size = new System.Drawing.Size(147, 20);
            this.txtCardOwner.TabIndex = 9;
            // 
            // frmCreditCardSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 608);
            this.Controls.Add(this.grpCCInfo);
            this.Controls.Add(this.grpCardNumberSearch);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCreditCardSearchForm";
            this.Text = "Credit Card Search";
            this.grpCardNumberSearch.ResumeLayout(false);
            this.grpCardNumberSearch.PerformLayout();
            this.grpCCInfo.ResumeLayout(false);
            this.grpCCInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardOwner;
        private System.Windows.Forms.GroupBox grpCardNumberSearch;
        private System.Windows.Forms.GroupBox grpCCInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtActivationStatus;
        private System.Windows.Forms.Label lblActivationStatus;
        private System.Windows.Forms.TextBox txtCreditCardLimit;
        private System.Windows.Forms.Label lblCreditCardLimit;
        private System.Windows.Forms.TextBox txtCreditCardBalance;
        private System.Windows.Forms.Label lblCreditCardBalance;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.TextBox txtCreditCardCompany;
        private System.Windows.Forms.Label lblCreditCardCompany;
        private System.Windows.Forms.TextBox txtCardOwner;
        private System.Windows.Forms.Button btnPrint;
    }
}