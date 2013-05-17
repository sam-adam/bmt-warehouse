namespace Warehouse.Presentation
{
    partial class RentalReceiptFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.lblAgreement = new System.Windows.Forms.Label();
            this.txtAgreementId = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnViewRentalAgreement = new System.Windows.Forms.Button();
            this.lblRentalAgreementCustomer = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblRentalAgreementGroup = new System.Windows.Forms.Label();
            this.lneRentalAgreementGroup = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lneCustomerGroup = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.stpRentalReceipt = new System.Windows.Forms.StatusStrip();
            this.tssHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHelpCustomerSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHelpRentalAgreementSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.txtAgreementSales = new System.Windows.Forms.TextBox();
            this.lblAgreementSales = new System.Windows.Forms.Label();
            this.lblAgreementSalesName = new System.Windows.Forms.Label();
            this.txtAgreementSalesName = new System.Windows.Forms.TextBox();
            this.lblRentalAgreementCustomerGroup = new System.Windows.Forms.Label();
            this.txtCustomerTitle = new System.Windows.Forms.TextBox();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.lblDetailGroup = new System.Windows.Forms.Label();
            this.lblOtherGroup = new System.Windows.Forms.Label();
            this.lneOtherGroup = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dtpAgreementDate = new System.Windows.Forms.DateTimePicker();
            this.lblRentalDate = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.lblExtReference = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dgvRentalReceiptDetail = new System.Windows.Forms.DataGridView();
            this.ProductCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSubcategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSubcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stpRentalReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalReceiptDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Enabled = false;
            this.dtpTransactionDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpTransactionDate.Location = new System.Drawing.Point(111, 12);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(250, 21);
            this.dtpTransactionDate.TabIndex = 6;
            this.dtpTransactionDate.TabStop = false;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTransactionDate.Location = new System.Drawing.Point(12, 15);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(93, 13);
            this.lblTransactionDate.TabIndex = 5;
            this.lblTransactionDate.Text = "Transaction Date:";
            // 
            // lblAgreement
            // 
            this.lblAgreement.AutoSize = true;
            this.lblAgreement.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreement.Location = new System.Drawing.Point(35, 69);
            this.lblAgreement.Name = "lblAgreement";
            this.lblAgreement.Size = new System.Drawing.Size(21, 13);
            this.lblAgreement.TabIndex = 20;
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
            this.txtAgreementId.Location = new System.Drawing.Point(134, 65);
            this.txtAgreementId.MaxLength = 15;
            this.txtAgreementId.Name = "txtAgreementId";
            this.txtAgreementId.Size = new System.Drawing.Size(100, 21);
            this.txtAgreementId.TabIndex = 1;
            this.txtAgreementId.TextChanged += new System.EventHandler(this.txtAgreementId_TextChanged);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerPhone.Location = new System.Drawing.Point(134, 255);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ReadOnly = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(141, 21);
            this.txtCustomerPhone.TabIndex = 31;
            this.txtCustomerPhone.TabStop = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerName.Location = new System.Drawing.Point(35, 232);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 13);
            this.lblCustomerName.TabIndex = 23;
            this.lblCustomerName.Text = "Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerName.Location = new System.Drawing.Point(134, 228);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(250, 21);
            this.txtCustomerName.TabIndex = 24;
            this.txtCustomerName.TabStop = false;
            // 
            // btnViewRentalAgreement
            // 
            this.btnViewRentalAgreement.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnViewRentalAgreement.Location = new System.Drawing.Point(240, 64);
            this.btnViewRentalAgreement.Name = "btnViewRentalAgreement";
            this.btnViewRentalAgreement.Size = new System.Drawing.Size(35, 23);
            this.btnViewRentalAgreement.TabIndex = 5;
            this.btnViewRentalAgreement.Text = "...";
            this.btnViewRentalAgreement.UseVisualStyleBackColor = true;
            this.btnViewRentalAgreement.Click += new System.EventHandler(this.btnViewRentalAgreement_Click);
            // 
            // lblRentalAgreementCustomer
            // 
            this.lblRentalAgreementCustomer.AutoSize = true;
            this.lblRentalAgreementCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblRentalAgreementCustomer.Location = new System.Drawing.Point(35, 178);
            this.lblRentalAgreementCustomer.Name = "lblRentalAgreementCustomer";
            this.lblRentalAgreementCustomer.Size = new System.Drawing.Size(57, 13);
            this.lblRentalAgreementCustomer.TabIndex = 25;
            this.lblRentalAgreementCustomer.Text = "Customer:";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerPhone.Location = new System.Drawing.Point(35, 258);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(41, 13);
            this.lblCustomerPhone.TabIndex = 28;
            this.lblCustomerPhone.Text = "Phone:";
            // 
            // lblRentalAgreementGroup
            // 
            this.lblRentalAgreementGroup.AutoSize = true;
            this.lblRentalAgreementGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRentalAgreementGroup.Location = new System.Drawing.Point(12, 42);
            this.lblRentalAgreementGroup.Name = "lblRentalAgreementGroup";
            this.lblRentalAgreementGroup.Size = new System.Drawing.Size(111, 13);
            this.lblRentalAgreementGroup.TabIndex = 26;
            this.lblRentalAgreementGroup.Text = "Rental Agreement";
            // 
            // lneRentalAgreementGroup
            // 
            this.lneRentalAgreementGroup.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.lneRentalAgreementGroup.Name = "lneRentalAgreementGroup";
            this.lneRentalAgreementGroup.X1 = 78;
            this.lneRentalAgreementGroup.X2 = 820;
            this.lneRentalAgreementGroup.Y1 = 49;
            this.lneRentalAgreementGroup.Y2 = 49;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lneOtherGroup,
            this.lneCustomerGroup,
            this.lneRentalAgreementGroup});
            this.shapeContainer1.Size = new System.Drawing.Size(840, 689);
            this.shapeContainer1.TabIndex = 34;
            this.shapeContainer1.TabStop = false;
            // 
            // lneCustomerGroup
            // 
            this.lneCustomerGroup.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.lneCustomerGroup.Name = "lneCustomerGroup";
            this.lneCustomerGroup.X1 = 79;
            this.lneCustomerGroup.X2 = 821;
            this.lneCustomerGroup.Y1 = 155;
            this.lneCustomerGroup.Y2 = 155;
            // 
            // stpRentalReceipt
            // 
            this.stpRentalReceipt.AutoSize = false;
            this.stpRentalReceipt.BackColor = System.Drawing.Color.White;
            this.stpRentalReceipt.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stpRentalReceipt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHelp,
            this.tssHelpCustomerSelection,
            this.tssHelpRentalAgreementSelection});
            this.stpRentalReceipt.Location = new System.Drawing.Point(0, 658);
            this.stpRentalReceipt.Name = "stpRentalReceipt";
            this.stpRentalReceipt.Size = new System.Drawing.Size(840, 31);
            this.stpRentalReceipt.TabIndex = 35;
            // 
            // tssHelp
            // 
            this.tssHelp.BackColor = System.Drawing.Color.Transparent;
            this.tssHelp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssHelp.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelp.Name = "tssHelp";
            this.tssHelp.Padding = new System.Windows.Forms.Padding(10);
            this.tssHelp.Size = new System.Drawing.Size(154, 26);
            this.tssHelp.Text = "Create new rental receipt";
            // 
            // tssHelpCustomerSelection
            // 
            this.tssHelpCustomerSelection.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssHelpCustomerSelection.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelpCustomerSelection.Name = "tssHelpCustomerSelection";
            this.tssHelpCustomerSelection.Padding = new System.Windows.Forms.Padding(10);
            this.tssHelpCustomerSelection.Size = new System.Drawing.Size(177, 26);
            this.tssHelpCustomerSelection.Text = "F1 :  Open Customer Selection";
            // 
            // tssHelpRentalAgreementSelection
            // 
            this.tssHelpRentalAgreementSelection.Name = "tssHelpRentalAgreementSelection";
            this.tssHelpRentalAgreementSelection.Padding = new System.Windows.Forms.Padding(10);
            this.tssHelpRentalAgreementSelection.Size = new System.Drawing.Size(214, 26);
            this.tssHelpRentalAgreementSelection.Text = "F2 :  Open Rental Agreement Selection";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerId.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerId.Location = new System.Drawing.Point(134, 174);
            this.txtCustomerId.MaxLength = 6;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 21);
            this.txtCustomerId.TabIndex = 10;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnViewCustomer.Location = new System.Drawing.Point(240, 173);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(35, 23);
            this.btnViewCustomer.TabIndex = 15;
            this.btnViewCustomer.Text = "...";
            this.btnViewCustomer.UseVisualStyleBackColor = true;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // txtAgreementSales
            // 
            this.txtAgreementSales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAgreementSales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAgreementSales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgreementSales.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAgreementSales.Location = new System.Drawing.Point(134, 92);
            this.txtAgreementSales.Name = "txtAgreementSales";
            this.txtAgreementSales.ReadOnly = true;
            this.txtAgreementSales.Size = new System.Drawing.Size(100, 21);
            this.txtAgreementSales.TabIndex = 37;
            this.txtAgreementSales.TabStop = false;
            // 
            // lblAgreementSales
            // 
            this.lblAgreementSales.AutoSize = true;
            this.lblAgreementSales.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreementSales.Location = new System.Drawing.Point(35, 95);
            this.lblAgreementSales.Name = "lblAgreementSales";
            this.lblAgreementSales.Size = new System.Drawing.Size(36, 13);
            this.lblAgreementSales.TabIndex = 36;
            this.lblAgreementSales.Text = "Sales:";
            // 
            // lblAgreementSalesName
            // 
            this.lblAgreementSalesName.AutoSize = true;
            this.lblAgreementSalesName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreementSalesName.Location = new System.Drawing.Point(35, 123);
            this.lblAgreementSalesName.Name = "lblAgreementSalesName";
            this.lblAgreementSalesName.Size = new System.Drawing.Size(38, 13);
            this.lblAgreementSalesName.TabIndex = 38;
            this.lblAgreementSalesName.Text = "Name:";
            // 
            // txtAgreementSalesName
            // 
            this.txtAgreementSalesName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAgreementSalesName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAgreementSalesName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgreementSalesName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAgreementSalesName.Location = new System.Drawing.Point(134, 119);
            this.txtAgreementSalesName.Name = "txtAgreementSalesName";
            this.txtAgreementSalesName.ReadOnly = true;
            this.txtAgreementSalesName.Size = new System.Drawing.Size(250, 21);
            this.txtAgreementSalesName.TabIndex = 39;
            this.txtAgreementSalesName.TabStop = false;
            // 
            // lblRentalAgreementCustomerGroup
            // 
            this.lblRentalAgreementCustomerGroup.AutoSize = true;
            this.lblRentalAgreementCustomerGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRentalAgreementCustomerGroup.Location = new System.Drawing.Point(12, 149);
            this.lblRentalAgreementCustomerGroup.Name = "lblRentalAgreementCustomerGroup";
            this.lblRentalAgreementCustomerGroup.Size = new System.Drawing.Size(62, 13);
            this.lblRentalAgreementCustomerGroup.TabIndex = 40;
            this.lblRentalAgreementCustomerGroup.Text = "Customer";
            // 
            // txtCustomerTitle
            // 
            this.txtCustomerTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerTitle.Location = new System.Drawing.Point(134, 201);
            this.txtCustomerTitle.Name = "txtCustomerTitle";
            this.txtCustomerTitle.ReadOnly = true;
            this.txtCustomerTitle.Size = new System.Drawing.Size(141, 21);
            this.txtCustomerTitle.TabIndex = 42;
            this.txtCustomerTitle.TabStop = false;
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerTitle.Location = new System.Drawing.Point(35, 205);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(31, 13);
            this.lblCustomerTitle.TabIndex = 41;
            this.lblCustomerTitle.Text = "Title:";
            // 
            // lblDetailGroup
            // 
            this.lblDetailGroup.AutoSize = true;
            this.lblDetailGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDetailGroup.Location = new System.Drawing.Point(12, 339);
            this.lblDetailGroup.Name = "lblDetailGroup";
            this.lblDetailGroup.Size = new System.Drawing.Size(46, 13);
            this.lblDetailGroup.TabIndex = 44;
            this.lblDetailGroup.Text = "Details";
            // 
            // lblOtherGroup
            // 
            this.lblOtherGroup.AutoSize = true;
            this.lblOtherGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblOtherGroup.Location = new System.Drawing.Point(12, 285);
            this.lblOtherGroup.Name = "lblOtherGroup";
            this.lblOtherGroup.Size = new System.Drawing.Size(39, 13);
            this.lblOtherGroup.TabIndex = 43;
            this.lblOtherGroup.Text = "Other";
            // 
            // lneOtherGroup
            // 
            this.lneOtherGroup.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.lneOtherGroup.Name = "lneOtherGroup";
            this.lneOtherGroup.X1 = 53;
            this.lneOtherGroup.X2 = 818;
            this.lneOtherGroup.Y1 = 292;
            this.lneOtherGroup.Y2 = 292;
            // 
            // dtpAgreementDate
            // 
            this.dtpAgreementDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpAgreementDate.Location = new System.Drawing.Point(134, 310);
            this.dtpAgreementDate.Name = "dtpAgreementDate";
            this.dtpAgreementDate.Size = new System.Drawing.Size(250, 21);
            this.dtpAgreementDate.TabIndex = 45;
            // 
            // lblRentalDate
            // 
            this.lblRentalDate.AutoSize = true;
            this.lblRentalDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblRentalDate.Location = new System.Drawing.Point(35, 314);
            this.lblRentalDate.Name = "lblRentalDate";
            this.lblRentalDate.Size = new System.Drawing.Size(68, 13);
            this.lblRentalDate.TabIndex = 48;
            this.lblRentalDate.Text = "Rental Date:";
            // 
            // txtReference
            // 
            this.txtReference.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtReference.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtReference.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReference.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtReference.Location = new System.Drawing.Point(516, 310);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(141, 21);
            this.txtReference.TabIndex = 46;
            // 
            // lblExtReference
            // 
            this.lblExtReference.AutoSize = true;
            this.lblExtReference.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblExtReference.Location = new System.Drawing.Point(417, 314);
            this.lblExtReference.Name = "lblExtReference";
            this.lblExtReference.Size = new System.Drawing.Size(84, 13);
            this.lblExtReference.TabIndex = 47;
            this.lblExtReference.Text = "Ext. Reference:";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerEmail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerEmail.Location = new System.Drawing.Point(516, 257);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.ReadOnly = true;
            this.txtCustomerEmail.Size = new System.Drawing.Size(250, 21);
            this.txtCustomerEmail.TabIndex = 52;
            this.txtCustomerEmail.TabStop = false;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerAddress.Location = new System.Drawing.Point(516, 175);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(294, 76);
            this.txtCustomerAddress.TabIndex = 51;
            this.txtCustomerAddress.TabStop = false;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerEmail.Location = new System.Drawing.Point(417, 260);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerEmail.TabIndex = 50;
            this.lblCustomerEmail.Text = "Email:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerAddress.Location = new System.Drawing.Point(417, 180);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(50, 13);
            this.lblCustomerAddress.TabIndex = 49;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 59;
            this.lineShape1.X2 = 818;
            this.lineShape1.Y1 = 346;
            this.lineShape1.Y2 = 346;
            // 
            // dgvRentalReceiptDetail
            // 
            this.dgvRentalReceiptDetail.AllowUserToAddRows = false;
            this.dgvRentalReceiptDetail.AllowUserToDeleteRows = false;
            this.dgvRentalReceiptDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRentalReceiptDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvRentalReceiptDetail.ColumnHeadersHeight = 25;
            this.dgvRentalReceiptDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCategoryId,
            this.ProductCategory,
            this.ProductSubcategoryId,
            this.ProductSubcategory,
            this.Price});
            this.dgvRentalReceiptDetail.EnableHeadersVisualStyles = false;
            this.dgvRentalReceiptDetail.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRentalReceiptDetail.Location = new System.Drawing.Point(16, 367);
            this.dgvRentalReceiptDetail.Name = "dgvRentalReceiptDetail";
            this.dgvRentalReceiptDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRentalReceiptDetail.RowHeadersVisible = false;
            this.dgvRentalReceiptDetail.Size = new System.Drawing.Size(806, 283);
            this.dgvRentalReceiptDetail.TabIndex = 53;
            // 
            // ProductCategoryId
            // 
            this.ProductCategoryId.HeaderText = "Category Id";
            this.ProductCategoryId.Name = "ProductCategoryId";
            this.ProductCategoryId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductCategoryId.Visible = false;
            this.ProductCategoryId.Width = 86;
            // 
            // ProductCategory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProductCategory.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProductCategory.HeaderText = "Category";
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            this.ProductCategory.Width = 74;
            // 
            // ProductSubcategoryId
            // 
            this.ProductSubcategoryId.HeaderText = "Subcategory Id";
            this.ProductSubcategoryId.Name = "ProductSubcategoryId";
            this.ProductSubcategoryId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductSubcategoryId.Visible = false;
            this.ProductSubcategoryId.Width = 104;
            // 
            // ProductSubcategory
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProductSubcategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductSubcategory.HeaderText = "Subcategory";
            this.ProductSubcategory.Name = "ProductSubcategory";
            this.ProductSubcategory.ReadOnly = true;
            this.ProductSubcategory.Width = 92;
            // 
            // Price
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Price.DefaultCellStyle = dataGridViewCellStyle3;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 56;
            // 
            // RentalReceiptFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 689);
            this.Controls.Add(this.dgvRentalReceiptDetail);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.dtpAgreementDate);
            this.Controls.Add(this.lblRentalDate);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.lblExtReference);
            this.Controls.Add(this.lblDetailGroup);
            this.Controls.Add(this.lblOtherGroup);
            this.Controls.Add(this.txtCustomerTitle);
            this.Controls.Add(this.lblCustomerTitle);
            this.Controls.Add(this.lblRentalAgreementCustomerGroup);
            this.Controls.Add(this.lblAgreementSalesName);
            this.Controls.Add(this.txtAgreementSalesName);
            this.Controls.Add(this.txtAgreementSales);
            this.Controls.Add(this.lblAgreementSales);
            this.Controls.Add(this.btnViewCustomer);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.stpRentalReceipt);
            this.Controls.Add(this.lblAgreement);
            this.Controls.Add(this.txtAgreementId);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnViewRentalAgreement);
            this.Controls.Add(this.lblRentalAgreementCustomer);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblRentalAgreementGroup);
            this.Controls.Add(this.dtpTransactionDate);
            this.Controls.Add(this.lblTransactionDate);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "RentalReceiptFrm";
            this.Text = "Rental Receipt";
            this.stpRentalReceipt.ResumeLayout(false);
            this.stpRentalReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalReceiptDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.Label lblAgreement;
        private System.Windows.Forms.TextBox txtAgreementId;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnViewRentalAgreement;
        private System.Windows.Forms.Label lblRentalAgreementCustomer;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblRentalAgreementGroup;
        private Microsoft.VisualBasic.PowerPacks.LineShape lneRentalAgreementGroup;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.StatusStrip stpRentalReceipt;
        private System.Windows.Forms.ToolStripStatusLabel tssHelp;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpCustomerSelection;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpRentalAgreementSelection;
        private System.Windows.Forms.TextBox txtAgreementSales;
        private System.Windows.Forms.Label lblAgreementSales;
        private System.Windows.Forms.Label lblAgreementSalesName;
        private System.Windows.Forms.TextBox txtAgreementSalesName;
        private System.Windows.Forms.Label lblRentalAgreementCustomerGroup;
        private Microsoft.VisualBasic.PowerPacks.LineShape lneCustomerGroup;
        private System.Windows.Forms.TextBox txtCustomerTitle;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.Label lblDetailGroup;
        private System.Windows.Forms.Label lblOtherGroup;
        private Microsoft.VisualBasic.PowerPacks.LineShape lneOtherGroup;
        private System.Windows.Forms.DateTimePicker dtpAgreementDate;
        private System.Windows.Forms.Label lblRentalDate;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label lblExtReference;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerAddress;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridView dgvRentalReceiptDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubcategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}