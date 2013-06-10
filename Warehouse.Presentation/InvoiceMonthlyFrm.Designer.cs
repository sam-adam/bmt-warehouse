namespace Warehouse.Presentation
{
    partial class InvoiceMonthlyFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stpInvoiceMonthly = new System.Windows.Forms.StatusStrip();
            this.tssHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHelpCustomerSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSave = new Warehouse.Presentation.Controls.ButtonStripItem();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txtCustomerTitle = new System.Windows.Forms.TextBox();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblRentalAgreementCustomer = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblRentalAgreementCustomerGroup = new System.Windows.Forms.Label();
            this.lneCustomerGroup = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lneDetailGroup = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lneOtherGroup = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lneRentalAgreementGroup = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblAgreementSalesName = new System.Windows.Forms.Label();
            this.txtAgreementSalesName = new System.Windows.Forms.TextBox();
            this.txtAgreementSales = new System.Windows.Forms.TextBox();
            this.lblAgreementSales = new System.Windows.Forms.Label();
            this.lblAgreement = new System.Windows.Forms.Label();
            this.txtAgreementId = new System.Windows.Forms.TextBox();
            this.lblRentalAgreementGroup = new System.Windows.Forms.Label();
            this.lblAgreementCutOffDate = new System.Windows.Forms.Label();
            this.txtAgreementCutOffDate = new System.Windows.Forms.TextBox();
            this.lblAgreementReference = new System.Windows.Forms.Label();
            this.txtAgreementReference = new System.Windows.Forms.TextBox();
            this.dtpAgreementDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAgreementCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOtherGroup = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountRemark = new System.Windows.Forms.Label();
            this.txtDiscountRemark = new System.Windows.Forms.TextBox();
            this.lblDetailGroup = new System.Windows.Forms.Label();
            this.dgvInvoiceMonthlyDetail = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSubcategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSubcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.stpInvoiceMonthly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceMonthlyDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // stpInvoiceMonthly
            // 
            this.stpInvoiceMonthly.AutoSize = false;
            this.stpInvoiceMonthly.BackColor = System.Drawing.Color.White;
            this.stpInvoiceMonthly.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stpInvoiceMonthly.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHelp,
            this.tssHelpCustomerSelection,
            this.btnSave});
            this.stpInvoiceMonthly.Location = new System.Drawing.Point(0, 705);
            this.stpInvoiceMonthly.Name = "stpInvoiceMonthly";
            this.stpInvoiceMonthly.Size = new System.Drawing.Size(840, 31);
            this.stpInvoiceMonthly.TabIndex = 69;
            // 
            // tssHelp
            // 
            this.tssHelp.BackColor = System.Drawing.Color.Transparent;
            this.tssHelp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssHelp.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelp.Name = "tssHelp";
            this.tssHelp.Padding = new System.Windows.Forms.Padding(10);
            this.tssHelp.Size = new System.Drawing.Size(164, 26);
            this.tssHelp.Text = "Create new invoice monthly";
            // 
            // tssHelpCustomerSelection
            // 
            this.tssHelpCustomerSelection.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelpCustomerSelection.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.tssHelpCustomerSelection.Name = "tssHelpCustomerSelection";
            this.tssHelpCustomerSelection.Padding = new System.Windows.Forms.Padding(10);
            this.tssHelpCustomerSelection.Size = new System.Drawing.Size(581, 26);
            this.tssHelpCustomerSelection.Spring = true;
            this.tssHelpCustomerSelection.Text = "F1 :  Open Customer Selection";
            this.tssHelpCustomerSelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 27);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Enabled = false;
            this.dtpTransactionDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpTransactionDate.Location = new System.Drawing.Point(111, 12);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(250, 21);
            this.dtpTransactionDate.TabIndex = 71;
            this.dtpTransactionDate.TabStop = false;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTransactionDate.Location = new System.Drawing.Point(12, 15);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(93, 13);
            this.lblTransactionDate.TabIndex = 70;
            this.lblTransactionDate.Text = "Transaction Date:";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerEmail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerEmail.Location = new System.Drawing.Point(516, 150);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.ReadOnly = true;
            this.txtCustomerEmail.Size = new System.Drawing.Size(250, 21);
            this.txtCustomerEmail.TabIndex = 84;
            this.txtCustomerEmail.TabStop = false;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerAddress.Location = new System.Drawing.Point(516, 68);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(294, 76);
            this.txtCustomerAddress.TabIndex = 83;
            this.txtCustomerAddress.TabStop = false;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerEmail.Location = new System.Drawing.Point(417, 153);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerEmail.TabIndex = 82;
            this.lblCustomerEmail.Text = "Email:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerAddress.Location = new System.Drawing.Point(417, 73);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(50, 13);
            this.lblCustomerAddress.TabIndex = 81;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // txtCustomerTitle
            // 
            this.txtCustomerTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerTitle.Location = new System.Drawing.Point(134, 94);
            this.txtCustomerTitle.Name = "txtCustomerTitle";
            this.txtCustomerTitle.ReadOnly = true;
            this.txtCustomerTitle.Size = new System.Drawing.Size(141, 21);
            this.txtCustomerTitle.TabIndex = 80;
            this.txtCustomerTitle.TabStop = false;
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerTitle.Location = new System.Drawing.Point(35, 98);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(31, 13);
            this.lblCustomerTitle.TabIndex = 79;
            this.lblCustomerTitle.Text = "Title:";
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnViewCustomer.Location = new System.Drawing.Point(240, 66);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(35, 23);
            this.btnViewCustomer.TabIndex = 2;
            this.btnViewCustomer.Text = "...";
            this.btnViewCustomer.UseVisualStyleBackColor = true;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerId.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerId.Location = new System.Drawing.Point(134, 67);
            this.txtCustomerId.MaxLength = 6;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 21);
            this.txtCustomerId.TabIndex = 1;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerPhone.Location = new System.Drawing.Point(134, 148);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ReadOnly = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(141, 21);
            this.txtCustomerPhone.TabIndex = 78;
            this.txtCustomerPhone.TabStop = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerName.Location = new System.Drawing.Point(35, 125);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 13);
            this.lblCustomerName.TabIndex = 74;
            this.lblCustomerName.Text = "Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerName.Location = new System.Drawing.Point(134, 121);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(250, 21);
            this.txtCustomerName.TabIndex = 75;
            this.txtCustomerName.TabStop = false;
            // 
            // lblRentalAgreementCustomer
            // 
            this.lblRentalAgreementCustomer.AutoSize = true;
            this.lblRentalAgreementCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblRentalAgreementCustomer.Location = new System.Drawing.Point(35, 71);
            this.lblRentalAgreementCustomer.Name = "lblRentalAgreementCustomer";
            this.lblRentalAgreementCustomer.Size = new System.Drawing.Size(57, 13);
            this.lblRentalAgreementCustomer.TabIndex = 76;
            this.lblRentalAgreementCustomer.Text = "Customer:";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerPhone.Location = new System.Drawing.Point(35, 151);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(41, 13);
            this.lblCustomerPhone.TabIndex = 77;
            this.lblCustomerPhone.Text = "Phone:";
            // 
            // lblRentalAgreementCustomerGroup
            // 
            this.lblRentalAgreementCustomerGroup.AutoSize = true;
            this.lblRentalAgreementCustomerGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRentalAgreementCustomerGroup.Location = new System.Drawing.Point(12, 42);
            this.lblRentalAgreementCustomerGroup.Name = "lblRentalAgreementCustomerGroup";
            this.lblRentalAgreementCustomerGroup.Size = new System.Drawing.Size(62, 13);
            this.lblRentalAgreementCustomerGroup.TabIndex = 85;
            this.lblRentalAgreementCustomerGroup.Text = "Customer";
            // 
            // lneCustomerGroup
            // 
            this.lneCustomerGroup.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.lneCustomerGroup.Name = "lneCustomerGroup";
            this.lneCustomerGroup.X1 = 78;
            this.lneCustomerGroup.X2 = 820;
            this.lneCustomerGroup.Y1 = 49;
            this.lneCustomerGroup.Y2 = 49;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lneDetailGroup,
            this.lneOtherGroup,
            this.lneRentalAgreementGroup,
            this.lneCustomerGroup});
            this.shapeContainer1.Size = new System.Drawing.Size(840, 736);
            this.shapeContainer1.TabIndex = 86;
            this.shapeContainer1.TabStop = false;
            // 
            // lneDetailGroup
            // 
            this.lneDetailGroup.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.lneDetailGroup.Name = "lneDetailGroup";
            this.lneDetailGroup.X1 = 53;
            this.lneDetailGroup.X2 = 812;
            this.lneDetailGroup.Y1 = 416;
            this.lneDetailGroup.Y2 = 416;
            // 
            // lneOtherGroup
            // 
            this.lneOtherGroup.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.lneOtherGroup.Name = "lneOtherGroup";
            this.lneOtherGroup.X1 = 54;
            this.lneOtherGroup.X2 = 813;
            this.lneOtherGroup.Y1 = 326;
            this.lneOtherGroup.Y2 = 326;
            // 
            // lneRentalAgreementGroup
            // 
            this.lneRentalAgreementGroup.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.lneRentalAgreementGroup.Name = "lneRentalAgreementGroup";
            this.lneRentalAgreementGroup.X1 = 76;
            this.lneRentalAgreementGroup.X2 = 818;
            this.lneRentalAgreementGroup.Y1 = 190;
            this.lneRentalAgreementGroup.Y2 = 190;
            // 
            // lblAgreementSalesName
            // 
            this.lblAgreementSalesName.AutoSize = true;
            this.lblAgreementSalesName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreementSalesName.Location = new System.Drawing.Point(35, 265);
            this.lblAgreementSalesName.Name = "lblAgreementSalesName";
            this.lblAgreementSalesName.Size = new System.Drawing.Size(38, 13);
            this.lblAgreementSalesName.TabIndex = 92;
            this.lblAgreementSalesName.Text = "Name:";
            // 
            // txtAgreementSalesName
            // 
            this.txtAgreementSalesName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAgreementSalesName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAgreementSalesName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgreementSalesName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAgreementSalesName.Location = new System.Drawing.Point(134, 261);
            this.txtAgreementSalesName.Name = "txtAgreementSalesName";
            this.txtAgreementSalesName.ReadOnly = true;
            this.txtAgreementSalesName.Size = new System.Drawing.Size(250, 21);
            this.txtAgreementSalesName.TabIndex = 93;
            this.txtAgreementSalesName.TabStop = false;
            // 
            // txtAgreementSales
            // 
            this.txtAgreementSales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAgreementSales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAgreementSales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgreementSales.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAgreementSales.Location = new System.Drawing.Point(134, 234);
            this.txtAgreementSales.Name = "txtAgreementSales";
            this.txtAgreementSales.ReadOnly = true;
            this.txtAgreementSales.Size = new System.Drawing.Size(100, 21);
            this.txtAgreementSales.TabIndex = 91;
            this.txtAgreementSales.TabStop = false;
            // 
            // lblAgreementSales
            // 
            this.lblAgreementSales.AutoSize = true;
            this.lblAgreementSales.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreementSales.Location = new System.Drawing.Point(35, 237);
            this.lblAgreementSales.Name = "lblAgreementSales";
            this.lblAgreementSales.Size = new System.Drawing.Size(36, 13);
            this.lblAgreementSales.TabIndex = 90;
            this.lblAgreementSales.Text = "Sales:";
            // 
            // lblAgreement
            // 
            this.lblAgreement.AutoSize = true;
            this.lblAgreement.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreement.Location = new System.Drawing.Point(35, 210);
            this.lblAgreement.Name = "lblAgreement";
            this.lblAgreement.Size = new System.Drawing.Size(21, 13);
            this.lblAgreement.TabIndex = 88;
            this.lblAgreement.Text = "Id:";
            // 
            // txtAgreementId
            // 
            this.txtAgreementId.AutoCompleteCustomSource.AddRange(new string[] {
            "HALO",
            "NAMA",
            "SAYA",
            "SAMUEL",
            "ADAM",
            "SUHENDRA"});
            this.txtAgreementId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAgreementId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAgreementId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgreementId.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAgreementId.Location = new System.Drawing.Point(134, 207);
            this.txtAgreementId.MaxLength = 15;
            this.txtAgreementId.Name = "txtAgreementId";
            this.txtAgreementId.ReadOnly = true;
            this.txtAgreementId.Size = new System.Drawing.Size(100, 21);
            this.txtAgreementId.TabIndex = 87;
            this.txtAgreementId.TabStop = false;
            // 
            // lblRentalAgreementGroup
            // 
            this.lblRentalAgreementGroup.AutoSize = true;
            this.lblRentalAgreementGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRentalAgreementGroup.Location = new System.Drawing.Point(12, 184);
            this.lblRentalAgreementGroup.Name = "lblRentalAgreementGroup";
            this.lblRentalAgreementGroup.Size = new System.Drawing.Size(111, 13);
            this.lblRentalAgreementGroup.TabIndex = 89;
            this.lblRentalAgreementGroup.Text = "Rental Agreement";
            // 
            // lblAgreementCutOffDate
            // 
            this.lblAgreementCutOffDate.AutoSize = true;
            this.lblAgreementCutOffDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreementCutOffDate.Location = new System.Drawing.Point(417, 210);
            this.lblAgreementCutOffDate.Name = "lblAgreementCutOffDate";
            this.lblAgreementCutOffDate.Size = new System.Drawing.Size(73, 13);
            this.lblAgreementCutOffDate.TabIndex = 94;
            this.lblAgreementCutOffDate.Text = "Cut Off Date:";
            // 
            // txtAgreementCutOffDate
            // 
            this.txtAgreementCutOffDate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAgreementCutOffDate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAgreementCutOffDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgreementCutOffDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAgreementCutOffDate.Location = new System.Drawing.Point(516, 207);
            this.txtAgreementCutOffDate.Name = "txtAgreementCutOffDate";
            this.txtAgreementCutOffDate.ReadOnly = true;
            this.txtAgreementCutOffDate.Size = new System.Drawing.Size(100, 21);
            this.txtAgreementCutOffDate.TabIndex = 95;
            this.txtAgreementCutOffDate.TabStop = false;
            // 
            // lblAgreementReference
            // 
            this.lblAgreementReference.AutoSize = true;
            this.lblAgreementReference.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreementReference.Location = new System.Drawing.Point(35, 292);
            this.lblAgreementReference.Name = "lblAgreementReference";
            this.lblAgreementReference.Size = new System.Drawing.Size(61, 13);
            this.lblAgreementReference.TabIndex = 96;
            this.lblAgreementReference.Text = "Reference:";
            // 
            // txtAgreementReference
            // 
            this.txtAgreementReference.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAgreementReference.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAgreementReference.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgreementReference.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAgreementReference.Location = new System.Drawing.Point(134, 288);
            this.txtAgreementReference.Name = "txtAgreementReference";
            this.txtAgreementReference.ReadOnly = true;
            this.txtAgreementReference.Size = new System.Drawing.Size(250, 21);
            this.txtAgreementReference.TabIndex = 97;
            this.txtAgreementReference.TabStop = false;
            // 
            // dtpAgreementDate
            // 
            this.dtpAgreementDate.Enabled = false;
            this.dtpAgreementDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpAgreementDate.Location = new System.Drawing.Point(516, 235);
            this.dtpAgreementDate.Name = "dtpAgreementDate";
            this.dtpAgreementDate.Size = new System.Drawing.Size(250, 21);
            this.dtpAgreementDate.TabIndex = 99;
            this.dtpAgreementDate.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(417, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Agreement Date:";
            // 
            // dtpAgreementCreatedDate
            // 
            this.dtpAgreementCreatedDate.Enabled = false;
            this.dtpAgreementCreatedDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpAgreementCreatedDate.Location = new System.Drawing.Point(516, 262);
            this.dtpAgreementCreatedDate.Name = "dtpAgreementCreatedDate";
            this.dtpAgreementCreatedDate.Size = new System.Drawing.Size(250, 21);
            this.dtpAgreementCreatedDate.TabIndex = 101;
            this.dtpAgreementCreatedDate.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(417, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Created Date:";
            // 
            // lblOtherGroup
            // 
            this.lblOtherGroup.AutoSize = true;
            this.lblOtherGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblOtherGroup.Location = new System.Drawing.Point(12, 319);
            this.lblOtherGroup.Name = "lblOtherGroup";
            this.lblOtherGroup.Size = new System.Drawing.Size(39, 13);
            this.lblOtherGroup.TabIndex = 102;
            this.lblOtherGroup.Text = "Other";
            // 
            // txtDiscount
            // 
            this.txtDiscount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDiscount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDiscount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiscount.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDiscount.Location = new System.Drawing.Point(134, 343);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 21);
            this.txtDiscount.TabIndex = 3;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblDiscount.Location = new System.Drawing.Point(35, 346);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(52, 13);
            this.lblDiscount.TabIndex = 103;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblDiscountRemark
            // 
            this.lblDiscountRemark.AutoSize = true;
            this.lblDiscountRemark.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblDiscountRemark.Location = new System.Drawing.Point(35, 374);
            this.lblDiscountRemark.Name = "lblDiscountRemark";
            this.lblDiscountRemark.Size = new System.Drawing.Size(91, 13);
            this.lblDiscountRemark.TabIndex = 105;
            this.lblDiscountRemark.Text = "Discount Remark:";
            // 
            // txtDiscountRemark
            // 
            this.txtDiscountRemark.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDiscountRemark.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDiscountRemark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiscountRemark.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDiscountRemark.Location = new System.Drawing.Point(134, 370);
            this.txtDiscountRemark.Name = "txtDiscountRemark";
            this.txtDiscountRemark.Size = new System.Drawing.Size(250, 21);
            this.txtDiscountRemark.TabIndex = 4;
            // 
            // lblDetailGroup
            // 
            this.lblDetailGroup.AutoSize = true;
            this.lblDetailGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDetailGroup.Location = new System.Drawing.Point(12, 404);
            this.lblDetailGroup.Name = "lblDetailGroup";
            this.lblDetailGroup.Size = new System.Drawing.Size(46, 13);
            this.lblDetailGroup.TabIndex = 107;
            this.lblDetailGroup.Text = "Details";
            // 
            // dgvInvoiceMonthlyDetail
            // 
            this.dgvInvoiceMonthlyDetail.AllowUserToAddRows = false;
            this.dgvInvoiceMonthlyDetail.AllowUserToDeleteRows = false;
            this.dgvInvoiceMonthlyDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInvoiceMonthlyDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvInvoiceMonthlyDetail.ColumnHeadersHeight = 25;
            this.dgvInvoiceMonthlyDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductCategoryId,
            this.ProductCategory,
            this.ProductSubcategoryId,
            this.ProductSubcategory,
            this.Brand,
            this.Description,
            this.Stock,
            this.Price,
            this.Subtotal});
            this.dgvInvoiceMonthlyDetail.EnableHeadersVisualStyles = false;
            this.dgvInvoiceMonthlyDetail.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInvoiceMonthlyDetail.Location = new System.Drawing.Point(15, 434);
            this.dgvInvoiceMonthlyDetail.Name = "dgvInvoiceMonthlyDetail";
            this.dgvInvoiceMonthlyDetail.ReadOnly = true;
            this.dgvInvoiceMonthlyDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInvoiceMonthlyDetail.RowHeadersVisible = false;
            this.dgvInvoiceMonthlyDetail.Size = new System.Drawing.Size(806, 224);
            this.dgvInvoiceMonthlyDetail.TabIndex = 108;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            this.ProductId.Width = 79;
            // 
            // ProductCategoryId
            // 
            this.ProductCategoryId.HeaderText = "Category Id";
            this.ProductCategoryId.Name = "ProductCategoryId";
            this.ProductCategoryId.ReadOnly = true;
            this.ProductCategoryId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductCategoryId.Visible = false;
            this.ProductCategoryId.Width = 84;
            // 
            // ProductCategory
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProductCategory.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProductCategory.HeaderText = "Category";
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            this.ProductCategory.Width = 74;
            // 
            // ProductSubcategoryId
            // 
            this.ProductSubcategoryId.HeaderText = "Subcategory Id";
            this.ProductSubcategoryId.Name = "ProductSubcategoryId";
            this.ProductSubcategoryId.ReadOnly = true;
            this.ProductSubcategoryId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductSubcategoryId.Visible = false;
            this.ProductSubcategoryId.Width = 102;
            // 
            // ProductSubcategory
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProductSubcategory.DefaultCellStyle = dataGridViewCellStyle5;
            this.ProductSubcategory.HeaderText = "Subcategory";
            this.ProductSubcategory.Name = "ProductSubcategory";
            this.ProductSubcategory.ReadOnly = true;
            this.ProductSubcategory.Width = 92;
            // 
            // Brand
            // 
            dataGridViewCellStyle6.Format = "C2";
            this.Brand.DefaultCellStyle = dataGridViewCellStyle6;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 60;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 85;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 60;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 56;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 71;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTotal.Location = new System.Drawing.Point(608, 664);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(158, 21);
            this.txtTotal.TabIndex = 110;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTotal.Location = new System.Drawing.Point(567, 667);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 109;
            this.lblTotal.Text = "Total:";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpInvoiceDate.Location = new System.Drawing.Point(516, 343);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(250, 21);
            this.dtpInvoiceDate.TabIndex = 112;
            this.dtpInvoiceDate.TabStop = false;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblInvoiceDate.Location = new System.Drawing.Point(417, 346);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(72, 13);
            this.lblInvoiceDate.TabIndex = 111;
            this.lblInvoiceDate.Text = "Invoice Date:";
            // 
            // InvoiceMonthlyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 736);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvInvoiceMonthlyDetail);
            this.Controls.Add(this.lblDetailGroup);
            this.Controls.Add(this.lblDiscountRemark);
            this.Controls.Add(this.txtDiscountRemark);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblOtherGroup);
            this.Controls.Add(this.dtpAgreementCreatedDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpAgreementDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAgreementReference);
            this.Controls.Add(this.txtAgreementReference);
            this.Controls.Add(this.lblAgreementCutOffDate);
            this.Controls.Add(this.txtAgreementCutOffDate);
            this.Controls.Add(this.lblAgreementSalesName);
            this.Controls.Add(this.txtAgreementSalesName);
            this.Controls.Add(this.txtAgreementSales);
            this.Controls.Add(this.lblAgreementSales);
            this.Controls.Add(this.lblAgreement);
            this.Controls.Add(this.txtAgreementId);
            this.Controls.Add(this.lblRentalAgreementGroup);
            this.Controls.Add(this.lblRentalAgreementCustomerGroup);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.txtCustomerTitle);
            this.Controls.Add(this.lblCustomerTitle);
            this.Controls.Add(this.btnViewCustomer);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblRentalAgreementCustomer);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.dtpTransactionDate);
            this.Controls.Add(this.lblTransactionDate);
            this.Controls.Add(this.stpInvoiceMonthly);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "InvoiceMonthlyFrm";
            this.Text = "Invoice Monthly";
            this.stpInvoiceMonthly.ResumeLayout(false);
            this.stpInvoiceMonthly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceMonthlyDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stpInvoiceMonthly;
        private System.Windows.Forms.ToolStripStatusLabel tssHelp;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpCustomerSelection;
        private Controls.ButtonStripItem btnSave;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerTitle;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblRentalAgreementCustomer;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblRentalAgreementCustomerGroup;
        private Microsoft.VisualBasic.PowerPacks.LineShape lneCustomerGroup;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lblAgreementSalesName;
        private System.Windows.Forms.TextBox txtAgreementSalesName;
        private System.Windows.Forms.TextBox txtAgreementSales;
        private System.Windows.Forms.Label lblAgreementSales;
        private System.Windows.Forms.Label lblAgreement;
        private System.Windows.Forms.TextBox txtAgreementId;
        private System.Windows.Forms.Label lblRentalAgreementGroup;
        private Microsoft.VisualBasic.PowerPacks.LineShape lneRentalAgreementGroup;
        private System.Windows.Forms.Label lblAgreementCutOffDate;
        private System.Windows.Forms.TextBox txtAgreementCutOffDate;
        private System.Windows.Forms.Label lblAgreementReference;
        private System.Windows.Forms.TextBox txtAgreementReference;
        private System.Windows.Forms.DateTimePicker dtpAgreementDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAgreementCreatedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOtherGroup;
        private Microsoft.VisualBasic.PowerPacks.LineShape lneOtherGroup;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountRemark;
        private System.Windows.Forms.TextBox txtDiscountRemark;
        private System.Windows.Forms.Label lblDetailGroup;
        private Microsoft.VisualBasic.PowerPacks.LineShape lneDetailGroup;
        private System.Windows.Forms.DataGridView dgvInvoiceMonthlyDetail;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubcategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceDate;
    }
}