
namespace XeroAPI2Tests
{
    partial class Form1
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
            this.simpleButton1 = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contactStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skypeUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccountDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsReceivableTaxTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsPayableTaxTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeroNetworkKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDefaultAccountCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasesDefaultAccountCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingCategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingCategoryOptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTermsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDateUTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandingThemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchPaymentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balancesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasAttachmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasValidationErrorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusAttributeStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Basic Stuff";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lstResults
            // 
            this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(14, 51);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(1439, 381);
            this.lstResults.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create Invoice";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Xero.Net.Api.Model.Accounting.Contact);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactStatusDataGridViewTextBoxColumn,
            this.contactIDDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.skypeUserNameDataGridViewTextBoxColumn,
            this.bankAccountDetailsDataGridViewTextBoxColumn,
            this.bankAccountNameDataGridViewTextBoxColumn,
            this.taxNumberDataGridViewTextBoxColumn,
            this.accountsReceivableTaxTypeDataGridViewTextBoxColumn,
            this.accountsPayableTaxTypeDataGridViewTextBoxColumn,
            this.isSupplierDataGridViewTextBoxColumn,
            this.isCustomerDataGridViewTextBoxColumn,
            this.xeroNetworkKeyDataGridViewTextBoxColumn,
            this.salesDefaultAccountCodeDataGridViewTextBoxColumn,
            this.purchasesDefaultAccountCodeDataGridViewTextBoxColumn,
            this.trackingCategoryNameDataGridViewTextBoxColumn,
            this.trackingCategoryOptionDataGridViewTextBoxColumn,
            this.paymentTermsDataGridViewTextBoxColumn,
            this.updatedDateUTCDataGridViewTextBoxColumn,
            this.websiteDataGridViewTextBoxColumn,
            this.brandingThemeDataGridViewTextBoxColumn,
            this.batchPaymentsDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.balancesDataGridViewTextBoxColumn,
            this.hasAttachmentsDataGridViewTextBoxColumn,
            this.hasValidationErrorsDataGridViewTextBoxColumn,
            this.statusAttributeStringDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1439, 200);
            this.dataGridView1.TabIndex = 4;
            // 
            // contactStatusDataGridViewTextBoxColumn
            // 
            this.contactStatusDataGridViewTextBoxColumn.DataPropertyName = "ContactStatus";
            this.contactStatusDataGridViewTextBoxColumn.HeaderText = "ContactStatus";
            this.contactStatusDataGridViewTextBoxColumn.Name = "contactStatusDataGridViewTextBoxColumn";
            // 
            // contactIDDataGridViewTextBoxColumn
            // 
            this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.HeaderText = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // skypeUserNameDataGridViewTextBoxColumn
            // 
            this.skypeUserNameDataGridViewTextBoxColumn.DataPropertyName = "SkypeUserName";
            this.skypeUserNameDataGridViewTextBoxColumn.HeaderText = "SkypeUserName";
            this.skypeUserNameDataGridViewTextBoxColumn.Name = "skypeUserNameDataGridViewTextBoxColumn";
            // 
            // bankAccountDetailsDataGridViewTextBoxColumn
            // 
            this.bankAccountDetailsDataGridViewTextBoxColumn.DataPropertyName = "BankAccountDetails";
            this.bankAccountDetailsDataGridViewTextBoxColumn.HeaderText = "BankAccountDetails";
            this.bankAccountDetailsDataGridViewTextBoxColumn.Name = "bankAccountDetailsDataGridViewTextBoxColumn";
            // 
            // bankAccountNameDataGridViewTextBoxColumn
            // 
            this.bankAccountNameDataGridViewTextBoxColumn.DataPropertyName = "BankAccountName";
            this.bankAccountNameDataGridViewTextBoxColumn.HeaderText = "BankAccountName";
            this.bankAccountNameDataGridViewTextBoxColumn.Name = "bankAccountNameDataGridViewTextBoxColumn";
            // 
            // taxNumberDataGridViewTextBoxColumn
            // 
            this.taxNumberDataGridViewTextBoxColumn.DataPropertyName = "TaxNumber";
            this.taxNumberDataGridViewTextBoxColumn.HeaderText = "TaxNumber";
            this.taxNumberDataGridViewTextBoxColumn.Name = "taxNumberDataGridViewTextBoxColumn";
            // 
            // accountsReceivableTaxTypeDataGridViewTextBoxColumn
            // 
            this.accountsReceivableTaxTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountsReceivableTaxType";
            this.accountsReceivableTaxTypeDataGridViewTextBoxColumn.HeaderText = "AccountsReceivableTaxType";
            this.accountsReceivableTaxTypeDataGridViewTextBoxColumn.Name = "accountsReceivableTaxTypeDataGridViewTextBoxColumn";
            // 
            // accountsPayableTaxTypeDataGridViewTextBoxColumn
            // 
            this.accountsPayableTaxTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountsPayableTaxType";
            this.accountsPayableTaxTypeDataGridViewTextBoxColumn.HeaderText = "AccountsPayableTaxType";
            this.accountsPayableTaxTypeDataGridViewTextBoxColumn.Name = "accountsPayableTaxTypeDataGridViewTextBoxColumn";
            // 
            // isSupplierDataGridViewTextBoxColumn
            // 
            this.isSupplierDataGridViewTextBoxColumn.DataPropertyName = "IsSupplier";
            this.isSupplierDataGridViewTextBoxColumn.HeaderText = "IsSupplier";
            this.isSupplierDataGridViewTextBoxColumn.Name = "isSupplierDataGridViewTextBoxColumn";
            // 
            // isCustomerDataGridViewTextBoxColumn
            // 
            this.isCustomerDataGridViewTextBoxColumn.DataPropertyName = "IsCustomer";
            this.isCustomerDataGridViewTextBoxColumn.HeaderText = "IsCustomer";
            this.isCustomerDataGridViewTextBoxColumn.Name = "isCustomerDataGridViewTextBoxColumn";
            // 
            // xeroNetworkKeyDataGridViewTextBoxColumn
            // 
            this.xeroNetworkKeyDataGridViewTextBoxColumn.DataPropertyName = "XeroNetworkKey";
            this.xeroNetworkKeyDataGridViewTextBoxColumn.HeaderText = "XeroNetworkKey";
            this.xeroNetworkKeyDataGridViewTextBoxColumn.Name = "xeroNetworkKeyDataGridViewTextBoxColumn";
            // 
            // salesDefaultAccountCodeDataGridViewTextBoxColumn
            // 
            this.salesDefaultAccountCodeDataGridViewTextBoxColumn.DataPropertyName = "SalesDefaultAccountCode";
            this.salesDefaultAccountCodeDataGridViewTextBoxColumn.HeaderText = "SalesDefaultAccountCode";
            this.salesDefaultAccountCodeDataGridViewTextBoxColumn.Name = "salesDefaultAccountCodeDataGridViewTextBoxColumn";
            // 
            // purchasesDefaultAccountCodeDataGridViewTextBoxColumn
            // 
            this.purchasesDefaultAccountCodeDataGridViewTextBoxColumn.DataPropertyName = "PurchasesDefaultAccountCode";
            this.purchasesDefaultAccountCodeDataGridViewTextBoxColumn.HeaderText = "PurchasesDefaultAccountCode";
            this.purchasesDefaultAccountCodeDataGridViewTextBoxColumn.Name = "purchasesDefaultAccountCodeDataGridViewTextBoxColumn";
            // 
            // trackingCategoryNameDataGridViewTextBoxColumn
            // 
            this.trackingCategoryNameDataGridViewTextBoxColumn.DataPropertyName = "TrackingCategoryName";
            this.trackingCategoryNameDataGridViewTextBoxColumn.HeaderText = "TrackingCategoryName";
            this.trackingCategoryNameDataGridViewTextBoxColumn.Name = "trackingCategoryNameDataGridViewTextBoxColumn";
            // 
            // trackingCategoryOptionDataGridViewTextBoxColumn
            // 
            this.trackingCategoryOptionDataGridViewTextBoxColumn.DataPropertyName = "TrackingCategoryOption";
            this.trackingCategoryOptionDataGridViewTextBoxColumn.HeaderText = "TrackingCategoryOption";
            this.trackingCategoryOptionDataGridViewTextBoxColumn.Name = "trackingCategoryOptionDataGridViewTextBoxColumn";
            // 
            // paymentTermsDataGridViewTextBoxColumn
            // 
            this.paymentTermsDataGridViewTextBoxColumn.DataPropertyName = "PaymentTerms";
            this.paymentTermsDataGridViewTextBoxColumn.HeaderText = "PaymentTerms";
            this.paymentTermsDataGridViewTextBoxColumn.Name = "paymentTermsDataGridViewTextBoxColumn";
            // 
            // updatedDateUTCDataGridViewTextBoxColumn
            // 
            this.updatedDateUTCDataGridViewTextBoxColumn.DataPropertyName = "UpdatedDateUTC";
            this.updatedDateUTCDataGridViewTextBoxColumn.HeaderText = "UpdatedDateUTC";
            this.updatedDateUTCDataGridViewTextBoxColumn.Name = "updatedDateUTCDataGridViewTextBoxColumn";
            this.updatedDateUTCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // websiteDataGridViewTextBoxColumn
            // 
            this.websiteDataGridViewTextBoxColumn.DataPropertyName = "Website";
            this.websiteDataGridViewTextBoxColumn.HeaderText = "Website";
            this.websiteDataGridViewTextBoxColumn.Name = "websiteDataGridViewTextBoxColumn";
            this.websiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandingThemeDataGridViewTextBoxColumn
            // 
            this.brandingThemeDataGridViewTextBoxColumn.DataPropertyName = "BrandingTheme";
            this.brandingThemeDataGridViewTextBoxColumn.HeaderText = "BrandingTheme";
            this.brandingThemeDataGridViewTextBoxColumn.Name = "brandingThemeDataGridViewTextBoxColumn";
            // 
            // batchPaymentsDataGridViewTextBoxColumn
            // 
            this.batchPaymentsDataGridViewTextBoxColumn.DataPropertyName = "BatchPayments";
            this.batchPaymentsDataGridViewTextBoxColumn.HeaderText = "BatchPayments";
            this.batchPaymentsDataGridViewTextBoxColumn.Name = "batchPaymentsDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balancesDataGridViewTextBoxColumn
            // 
            this.balancesDataGridViewTextBoxColumn.DataPropertyName = "Balances";
            this.balancesDataGridViewTextBoxColumn.HeaderText = "Balances";
            this.balancesDataGridViewTextBoxColumn.Name = "balancesDataGridViewTextBoxColumn";
            // 
            // hasAttachmentsDataGridViewTextBoxColumn
            // 
            this.hasAttachmentsDataGridViewTextBoxColumn.DataPropertyName = "HasAttachments";
            this.hasAttachmentsDataGridViewTextBoxColumn.HeaderText = "HasAttachments";
            this.hasAttachmentsDataGridViewTextBoxColumn.Name = "hasAttachmentsDataGridViewTextBoxColumn";
            // 
            // hasValidationErrorsDataGridViewTextBoxColumn
            // 
            this.hasValidationErrorsDataGridViewTextBoxColumn.DataPropertyName = "HasValidationErrors";
            this.hasValidationErrorsDataGridViewTextBoxColumn.HeaderText = "HasValidationErrors";
            this.hasValidationErrorsDataGridViewTextBoxColumn.Name = "hasValidationErrorsDataGridViewTextBoxColumn";
            // 
            // statusAttributeStringDataGridViewTextBoxColumn
            // 
            this.statusAttributeStringDataGridViewTextBoxColumn.DataPropertyName = "StatusAttributeString";
            this.statusAttributeStringDataGridViewTextBoxColumn.HeaderText = "StatusAttributeString";
            this.statusAttributeStringDataGridViewTextBoxColumn.Name = "statusAttributeStringDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Load Contacts Grid";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Load Contact";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(656, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Find Contact:";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(805, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 20);
            this.txtName.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 650);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button simpleButton1;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skypeUserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAccountDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAccountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountsReceivableTaxTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountsPayableTaxTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeroNetworkKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDefaultAccountCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasesDefaultAccountCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingCategoryOptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTermsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDateUTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn websiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandingThemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchPaymentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balancesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasAttachmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasValidationErrorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusAttributeStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtName;
    }
}

