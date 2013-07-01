namespace Warehouse.Presentation
{
    partial class InvoiceWithdrawalFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInvoiceWithdrawalDetail = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSubcategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSubcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.Subtotal = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.dtpAgreementCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAgreementDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgreementReference = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAgreementReference = new System.Windows.Forms.Label();
            this.lblAgreementCutOffDate = new System.Windows.Forms.Label();
            this.txtAgreementCutOffDate = new System.Windows.Forms.TextBox();
            this.btnPrint = new Warehouse.Presentation.Controls.ButtonStripItem();
            this.tssHelpInvoiceWithdrawalSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnViewInvoiceWithdrawal = new System.Windows.Forms.Button();
            this.txtAgreementSales = new System.Windows.Forms.TextBox();
            this.lblAgreementSales = new System.Windows.Forms.Label();
            this.lblAgreement = new System.Windows.Forms.Label();
            this.txtAgreementId = new System.Windows.Forms.TextBox();
            this.tssHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAgreementSalesName = new System.Windows.Forms.Label();
            this.txtAgreementSalesName = new System.Windows.Forms.TextBox();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.stpInvoiceWithdrawal = new System.Windows.Forms.StatusStrip();
            this.lblInvoiceWithdrawal = new System.Windows.Forms.Label();
            this.txtWithdrawalId = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txtCustomerTitle = new System.Windows.Forms.TextBox();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblRentalAgreementCustomer = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.gbxInvoiceWithdrawal = new System.Windows.Forms.GroupBox();
            this.gbxRentalAgreement = new System.Windows.Forms.GroupBox();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.pnlDetailTotal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceWithdrawalDetail)).BeginInit();
            this.stpInvoiceWithdrawal.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.gbxInvoiceWithdrawal.SuspendLayout();
            this.gbxRentalAgreement.SuspendLayout();
            this.gbxCustomer.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.pnlDetailTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvoiceWithdrawalDetail
            // 
            this.dgvInvoiceWithdrawalDetail.AllowUserToAddRows = false;
            this.dgvInvoiceWithdrawalDetail.AllowUserToDeleteRows = false;
            this.dgvInvoiceWithdrawalDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInvoiceWithdrawalDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvInvoiceWithdrawalDetail.ColumnHeadersHeight = 25;
            this.dgvInvoiceWithdrawalDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductCategoryId,
            this.ProductCategory,
            this.ProductSubcategoryId,
            this.ProductSubcategory,
            this.Brand,
            this.Description,
            this.Quantity,
            this.Price,
            this.Subtotal});
            this.dgvInvoiceWithdrawalDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceWithdrawalDetail.EnableHeadersVisualStyles = false;
            this.dgvInvoiceWithdrawalDetail.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInvoiceWithdrawalDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoiceWithdrawalDetail.Name = "dgvInvoiceWithdrawalDetail";
            this.dgvInvoiceWithdrawalDetail.ReadOnly = true;
            this.dgvInvoiceWithdrawalDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInvoiceWithdrawalDetail.RowHeadersVisible = false;
            this.dgvInvoiceWithdrawalDetail.Size = new System.Drawing.Size(840, 312);
            this.dgvInvoiceWithdrawalDetail.TabIndex = 151;
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
            this.ProductSubcategoryId.ReadOnly = true;
            this.ProductSubcategoryId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductSubcategoryId.Visible = false;
            this.ProductSubcategoryId.Width = 102;
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
            // Brand
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Format = "C2";
            this.Brand.DefaultCellStyle = dataGridViewCellStyle3;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 60;
            // 
            // Description
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Description.DefaultCellStyle = dataGridViewCellStyle4;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 85;
            // 
            // Quantity
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 71;
            // 
            // Price
            // 
            // 
            // 
            // 
            this.Price.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Price.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Price.DefaultCellStyle = dataGridViewCellStyle6;
            this.Price.HeaderText = "Price";
            this.Price.Increment = 1D;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Price.Width = 56;
            // 
            // Subtotal
            // 
            // 
            // 
            // 
            this.Subtotal.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Subtotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Increment = 1D;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Subtotal.Width = 71;
            // 
            // dtpAgreementCreatedDate
            // 
            this.dtpAgreementCreatedDate.Enabled = false;
            this.dtpAgreementCreatedDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpAgreementCreatedDate.Location = new System.Drawing.Point(507, 71);
            this.dtpAgreementCreatedDate.Name = "dtpAgreementCreatedDate";
            this.dtpAgreementCreatedDate.Size = new System.Drawing.Size(250, 21);
            this.dtpAgreementCreatedDate.TabIndex = 146;
            this.dtpAgreementCreatedDate.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(404, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 145;
            this.label2.Text = "Created Date:";
            // 
            // dtpAgreementDate
            // 
            this.dtpAgreementDate.Enabled = false;
            this.dtpAgreementDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpAgreementDate.Location = new System.Drawing.Point(507, 44);
            this.dtpAgreementDate.Name = "dtpAgreementDate";
            this.dtpAgreementDate.Size = new System.Drawing.Size(250, 21);
            this.dtpAgreementDate.TabIndex = 144;
            this.dtpAgreementDate.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(404, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 143;
            this.label1.Text = "Agreement Date:";
            // 
            // txtAgreementReference
            // 
            this.txtAgreementReference.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAgreementReference.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAgreementReference.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgreementReference.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAgreementReference.Location = new System.Drawing.Point(124, 98);
            this.txtAgreementReference.Name = "txtAgreementReference";
            this.txtAgreementReference.ReadOnly = true;
            this.txtAgreementReference.Size = new System.Drawing.Size(250, 21);
            this.txtAgreementReference.TabIndex = 142;
            this.txtAgreementReference.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTotal.Location = new System.Drawing.Point(639, 6);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(158, 21);
            this.txtTotal.TabIndex = 153;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTotal.Location = new System.Drawing.Point(598, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 152;
            this.lblTotal.Text = "Total:";
            // 
            // lblAgreementReference
            // 
            this.lblAgreementReference.AutoSize = true;
            this.lblAgreementReference.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreementReference.Location = new System.Drawing.Point(25, 101);
            this.lblAgreementReference.Name = "lblAgreementReference";
            this.lblAgreementReference.Size = new System.Drawing.Size(61, 13);
            this.lblAgreementReference.TabIndex = 141;
            this.lblAgreementReference.Text = "Reference:";
            // 
            // lblAgreementCutOffDate
            // 
            this.lblAgreementCutOffDate.AutoSize = true;
            this.lblAgreementCutOffDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreementCutOffDate.Location = new System.Drawing.Point(404, 20);
            this.lblAgreementCutOffDate.Name = "lblAgreementCutOffDate";
            this.lblAgreementCutOffDate.Size = new System.Drawing.Size(73, 13);
            this.lblAgreementCutOffDate.TabIndex = 139;
            this.lblAgreementCutOffDate.Text = "Cut Off Date:";
            // 
            // txtAgreementCutOffDate
            // 
            this.txtAgreementCutOffDate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAgreementCutOffDate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAgreementCutOffDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgreementCutOffDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAgreementCutOffDate.Location = new System.Drawing.Point(507, 17);
            this.txtAgreementCutOffDate.Name = "txtAgreementCutOffDate";
            this.txtAgreementCutOffDate.ReadOnly = true;
            this.txtAgreementCutOffDate.Size = new System.Drawing.Size(100, 21);
            this.txtAgreementCutOffDate.TabIndex = 140;
            this.txtAgreementCutOffDate.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 27);
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tssHelpInvoiceWithdrawalSelection
            // 
            this.tssHelpInvoiceWithdrawalSelection.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelpInvoiceWithdrawalSelection.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.tssHelpInvoiceWithdrawalSelection.Name = "tssHelpInvoiceWithdrawalSelection";
            this.tssHelpInvoiceWithdrawalSelection.Padding = new System.Windows.Forms.Padding(10);
            this.tssHelpInvoiceWithdrawalSelection.Size = new System.Drawing.Size(561, 26);
            this.tssHelpInvoiceWithdrawalSelection.Spring = true;
            this.tssHelpInvoiceWithdrawalSelection.Text = "F1 :  Open Invoice Withdrawal Selection";
            this.tssHelpInvoiceWithdrawalSelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnViewInvoiceWithdrawal
            // 
            this.btnViewInvoiceWithdrawal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnViewInvoiceWithdrawal.Location = new System.Drawing.Point(271, 16);
            this.btnViewInvoiceWithdrawal.Name = "btnViewInvoiceWithdrawal";
            this.btnViewInvoiceWithdrawal.Size = new System.Drawing.Size(35, 23);
            this.btnViewInvoiceWithdrawal.TabIndex = 114;
            this.btnViewInvoiceWithdrawal.Text = "...";
            this.btnViewInvoiceWithdrawal.UseVisualStyleBackColor = true;
            this.btnViewInvoiceWithdrawal.Click += new System.EventHandler(this.btnViewInvoiceWithdrawal_Click);
            // 
            // txtAgreementSales
            // 
            this.txtAgreementSales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAgreementSales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAgreementSales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgreementSales.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAgreementSales.Location = new System.Drawing.Point(124, 44);
            this.txtAgreementSales.Name = "txtAgreementSales";
            this.txtAgreementSales.ReadOnly = true;
            this.txtAgreementSales.Size = new System.Drawing.Size(100, 21);
            this.txtAgreementSales.TabIndex = 136;
            this.txtAgreementSales.TabStop = false;
            // 
            // lblAgreementSales
            // 
            this.lblAgreementSales.AutoSize = true;
            this.lblAgreementSales.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreementSales.Location = new System.Drawing.Point(25, 47);
            this.lblAgreementSales.Name = "lblAgreementSales";
            this.lblAgreementSales.Size = new System.Drawing.Size(36, 13);
            this.lblAgreementSales.TabIndex = 135;
            this.lblAgreementSales.Text = "Sales:";
            // 
            // lblAgreement
            // 
            this.lblAgreement.AutoSize = true;
            this.lblAgreement.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreement.Location = new System.Drawing.Point(25, 20);
            this.lblAgreement.Name = "lblAgreement";
            this.lblAgreement.Size = new System.Drawing.Size(21, 13);
            this.lblAgreement.TabIndex = 133;
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
            this.txtAgreementId.Location = new System.Drawing.Point(124, 17);
            this.txtAgreementId.MaxLength = 15;
            this.txtAgreementId.Name = "txtAgreementId";
            this.txtAgreementId.ReadOnly = true;
            this.txtAgreementId.Size = new System.Drawing.Size(100, 21);
            this.txtAgreementId.TabIndex = 132;
            this.txtAgreementId.TabStop = false;
            // 
            // tssHelp
            // 
            this.tssHelp.BackColor = System.Drawing.Color.Transparent;
            this.tssHelp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssHelp.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelp.Name = "tssHelp";
            this.tssHelp.Padding = new System.Windows.Forms.Padding(10);
            this.tssHelp.Size = new System.Drawing.Size(184, 26);
            this.tssHelp.Text = "Print existing invoice withdrawal";
            // 
            // lblAgreementSalesName
            // 
            this.lblAgreementSalesName.AutoSize = true;
            this.lblAgreementSalesName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreementSalesName.Location = new System.Drawing.Point(25, 74);
            this.lblAgreementSalesName.Name = "lblAgreementSalesName";
            this.lblAgreementSalesName.Size = new System.Drawing.Size(38, 13);
            this.lblAgreementSalesName.TabIndex = 137;
            this.lblAgreementSalesName.Text = "Name:";
            // 
            // txtAgreementSalesName
            // 
            this.txtAgreementSalesName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAgreementSalesName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAgreementSalesName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgreementSalesName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAgreementSalesName.Location = new System.Drawing.Point(124, 71);
            this.txtAgreementSalesName.Name = "txtAgreementSalesName";
            this.txtAgreementSalesName.ReadOnly = true;
            this.txtAgreementSalesName.Size = new System.Drawing.Size(250, 21);
            this.txtAgreementSalesName.TabIndex = 138;
            this.txtAgreementSalesName.TabStop = false;
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Enabled = false;
            this.dtpTransactionDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpTransactionDate.Location = new System.Drawing.Point(112, 10);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(250, 21);
            this.dtpTransactionDate.TabIndex = 119;
            this.dtpTransactionDate.TabStop = false;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTransactionDate.Location = new System.Drawing.Point(13, 13);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(93, 13);
            this.lblTransactionDate.TabIndex = 118;
            this.lblTransactionDate.Text = "Transaction Date:";
            // 
            // stpInvoiceWithdrawal
            // 
            this.stpInvoiceWithdrawal.AutoSize = false;
            this.stpInvoiceWithdrawal.BackColor = System.Drawing.Color.White;
            this.stpInvoiceWithdrawal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stpInvoiceWithdrawal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHelp,
            this.tssHelpInvoiceWithdrawalSelection,
            this.btnPrint});
            this.stpInvoiceWithdrawal.Location = new System.Drawing.Point(0, 705);
            this.stpInvoiceWithdrawal.Name = "stpInvoiceWithdrawal";
            this.stpInvoiceWithdrawal.Size = new System.Drawing.Size(840, 31);
            this.stpInvoiceWithdrawal.TabIndex = 117;
            // 
            // lblInvoiceWithdrawal
            // 
            this.lblInvoiceWithdrawal.AutoSize = true;
            this.lblInvoiceWithdrawal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblInvoiceWithdrawal.Location = new System.Drawing.Point(25, 20);
            this.lblInvoiceWithdrawal.Name = "lblInvoiceWithdrawal";
            this.lblInvoiceWithdrawal.Size = new System.Drawing.Size(21, 13);
            this.lblInvoiceWithdrawal.TabIndex = 155;
            this.lblInvoiceWithdrawal.Text = "Id:";
            // 
            // txtWithdrawalId
            // 
            this.txtWithdrawalId.AutoCompleteCustomSource.AddRange(new string[] {
            "HALO",
            "NAMA",
            "SAYA",
            "SAMUEL",
            "ADAM",
            "SUHENDRA"});
            this.txtWithdrawalId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtWithdrawalId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtWithdrawalId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWithdrawalId.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtWithdrawalId.Location = new System.Drawing.Point(124, 17);
            this.txtWithdrawalId.MaxLength = 15;
            this.txtWithdrawalId.Name = "txtWithdrawalId";
            this.txtWithdrawalId.Size = new System.Drawing.Size(141, 21);
            this.txtWithdrawalId.TabIndex = 154;
            this.txtWithdrawalId.TabStop = false;
            this.txtWithdrawalId.TextChanged += new System.EventHandler(this.txtWithdrawalId_TextChanged);
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerEmail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerEmail.Location = new System.Drawing.Point(503, 98);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.ReadOnly = true;
            this.txtCustomerEmail.Size = new System.Drawing.Size(250, 21);
            this.txtCustomerEmail.TabIndex = 168;
            this.txtCustomerEmail.TabStop = false;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerAddress.Location = new System.Drawing.Point(503, 17);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(294, 75);
            this.txtCustomerAddress.TabIndex = 167;
            this.txtCustomerAddress.TabStop = false;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerAddress.Location = new System.Drawing.Point(404, 20);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(50, 13);
            this.lblCustomerAddress.TabIndex = 165;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // txtCustomerTitle
            // 
            this.txtCustomerTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerTitle.Location = new System.Drawing.Point(124, 44);
            this.txtCustomerTitle.Name = "txtCustomerTitle";
            this.txtCustomerTitle.ReadOnly = true;
            this.txtCustomerTitle.Size = new System.Drawing.Size(141, 21);
            this.txtCustomerTitle.TabIndex = 164;
            this.txtCustomerTitle.TabStop = false;
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerTitle.Location = new System.Drawing.Point(25, 47);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerTitle.TabIndex = 163;
            this.lblCustomerTitle.Text = "Type:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerId.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerId.Location = new System.Drawing.Point(124, 17);
            this.txtCustomerId.MaxLength = 6;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(141, 21);
            this.txtCustomerId.TabIndex = 157;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerEmail.Location = new System.Drawing.Point(404, 101);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerEmail.TabIndex = 166;
            this.lblCustomerEmail.Text = "Email:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerPhone.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerPhone.Location = new System.Drawing.Point(124, 98);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ReadOnly = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(141, 21);
            this.txtCustomerPhone.TabIndex = 162;
            this.txtCustomerPhone.TabStop = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerName.Location = new System.Drawing.Point(25, 74);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 13);
            this.lblCustomerName.TabIndex = 158;
            this.lblCustomerName.Text = "Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerName.Location = new System.Drawing.Point(124, 71);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(250, 21);
            this.txtCustomerName.TabIndex = 159;
            this.txtCustomerName.TabStop = false;
            // 
            // lblRentalAgreementCustomer
            // 
            this.lblRentalAgreementCustomer.AutoSize = true;
            this.lblRentalAgreementCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblRentalAgreementCustomer.Location = new System.Drawing.Point(25, 20);
            this.lblRentalAgreementCustomer.Name = "lblRentalAgreementCustomer";
            this.lblRentalAgreementCustomer.Size = new System.Drawing.Size(21, 13);
            this.lblRentalAgreementCustomer.TabIndex = 160;
            this.lblRentalAgreementCustomer.Text = "Id:";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerPhone.Location = new System.Drawing.Point(25, 101);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(41, 13);
            this.lblCustomerPhone.TabIndex = 161;
            this.lblCustomerPhone.Text = "Phone:";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTransactionDate);
            this.pnlTop.Controls.Add(this.dtpTransactionDate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(840, 39);
            this.pnlTop.TabIndex = 172;
            // 
            // gbxInvoiceWithdrawal
            // 
            this.gbxInvoiceWithdrawal.Controls.Add(this.lblInvoiceWithdrawal);
            this.gbxInvoiceWithdrawal.Controls.Add(this.btnViewInvoiceWithdrawal);
            this.gbxInvoiceWithdrawal.Controls.Add(this.txtWithdrawalId);
            this.gbxInvoiceWithdrawal.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxInvoiceWithdrawal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbxInvoiceWithdrawal.Location = new System.Drawing.Point(0, 0);
            this.gbxInvoiceWithdrawal.Name = "gbxInvoiceWithdrawal";
            this.gbxInvoiceWithdrawal.Size = new System.Drawing.Size(840, 52);
            this.gbxInvoiceWithdrawal.TabIndex = 173;
            this.gbxInvoiceWithdrawal.TabStop = false;
            this.gbxInvoiceWithdrawal.Text = "Invoice Withdrawal";
            // 
            // gbxRentalAgreement
            // 
            this.gbxRentalAgreement.Controls.Add(this.lblAgreement);
            this.gbxRentalAgreement.Controls.Add(this.txtAgreementSalesName);
            this.gbxRentalAgreement.Controls.Add(this.lblAgreementSalesName);
            this.gbxRentalAgreement.Controls.Add(this.txtAgreementId);
            this.gbxRentalAgreement.Controls.Add(this.lblAgreementSales);
            this.gbxRentalAgreement.Controls.Add(this.txtAgreementSales);
            this.gbxRentalAgreement.Controls.Add(this.txtAgreementCutOffDate);
            this.gbxRentalAgreement.Controls.Add(this.lblAgreementCutOffDate);
            this.gbxRentalAgreement.Controls.Add(this.lblAgreementReference);
            this.gbxRentalAgreement.Controls.Add(this.txtAgreementReference);
            this.gbxRentalAgreement.Controls.Add(this.label1);
            this.gbxRentalAgreement.Controls.Add(this.dtpAgreementDate);
            this.gbxRentalAgreement.Controls.Add(this.label2);
            this.gbxRentalAgreement.Controls.Add(this.dtpAgreementCreatedDate);
            this.gbxRentalAgreement.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxRentalAgreement.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbxRentalAgreement.Location = new System.Drawing.Point(0, 52);
            this.gbxRentalAgreement.Name = "gbxRentalAgreement";
            this.gbxRentalAgreement.Size = new System.Drawing.Size(840, 129);
            this.gbxRentalAgreement.TabIndex = 174;
            this.gbxRentalAgreement.TabStop = false;
            this.gbxRentalAgreement.Text = "Rental Agreement";
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.lblRentalAgreementCustomer);
            this.gbxCustomer.Controls.Add(this.lblCustomerPhone);
            this.gbxCustomer.Controls.Add(this.txtCustomerName);
            this.gbxCustomer.Controls.Add(this.lblCustomerName);
            this.gbxCustomer.Controls.Add(this.txtCustomerEmail);
            this.gbxCustomer.Controls.Add(this.txtCustomerPhone);
            this.gbxCustomer.Controls.Add(this.txtCustomerAddress);
            this.gbxCustomer.Controls.Add(this.lblCustomerEmail);
            this.gbxCustomer.Controls.Add(this.lblCustomerAddress);
            this.gbxCustomer.Controls.Add(this.txtCustomerId);
            this.gbxCustomer.Controls.Add(this.txtCustomerTitle);
            this.gbxCustomer.Controls.Add(this.lblCustomerTitle);
            this.gbxCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbxCustomer.Location = new System.Drawing.Point(0, 181);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Size = new System.Drawing.Size(840, 130);
            this.gbxCustomer.TabIndex = 175;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "Customer";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.gbxCustomer);
            this.pnlHeader.Controls.Add(this.gbxRentalAgreement);
            this.pnlHeader.Controls.Add(this.gbxInvoiceWithdrawal);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 39);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(840, 320);
            this.pnlHeader.TabIndex = 176;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.dgvInvoiceWithdrawalDetail);
            this.pnlDetail.Controls.Add(this.pnlDetailTotal);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 359);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(840, 346);
            this.pnlDetail.TabIndex = 177;
            // 
            // pnlDetailTotal
            // 
            this.pnlDetailTotal.Controls.Add(this.txtTotal);
            this.pnlDetailTotal.Controls.Add(this.lblTotal);
            this.pnlDetailTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetailTotal.Location = new System.Drawing.Point(0, 312);
            this.pnlDetailTotal.Name = "pnlDetailTotal";
            this.pnlDetailTotal.Size = new System.Drawing.Size(840, 34);
            this.pnlDetailTotal.TabIndex = 152;
            // 
            // InvoiceWithdrawalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 736);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.stpInvoiceWithdrawal);
            this.Name = "InvoiceWithdrawalFrm";
            this.Text = "Invoice Withdrawal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceWithdrawalDetail)).EndInit();
            this.stpInvoiceWithdrawal.ResumeLayout(false);
            this.stpInvoiceWithdrawal.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.gbxInvoiceWithdrawal.ResumeLayout(false);
            this.gbxInvoiceWithdrawal.PerformLayout();
            this.gbxRentalAgreement.ResumeLayout(false);
            this.gbxRentalAgreement.PerformLayout();
            this.gbxCustomer.ResumeLayout(false);
            this.gbxCustomer.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetailTotal.ResumeLayout(false);
            this.pnlDetailTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoiceWithdrawalDetail;
        private System.Windows.Forms.DateTimePicker dtpAgreementCreatedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAgreementDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgreementReference;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAgreementReference;
        private System.Windows.Forms.Label lblAgreementCutOffDate;
        private System.Windows.Forms.TextBox txtAgreementCutOffDate;
        private Controls.ButtonStripItem btnPrint;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpInvoiceWithdrawalSelection;
        private System.Windows.Forms.Button btnViewInvoiceWithdrawal;
        private System.Windows.Forms.TextBox txtAgreementSales;
        private System.Windows.Forms.Label lblAgreementSales;
        private System.Windows.Forms.Label lblAgreement;
        private System.Windows.Forms.TextBox txtAgreementId;
        private System.Windows.Forms.ToolStripStatusLabel tssHelp;
        private System.Windows.Forms.Label lblAgreementSalesName;
        private System.Windows.Forms.TextBox txtAgreementSalesName;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.StatusStrip stpInvoiceWithdrawal;
        private System.Windows.Forms.Label lblInvoiceWithdrawal;
        private System.Windows.Forms.TextBox txtWithdrawalId;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerTitle;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblRentalAgreementCustomer;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox gbxInvoiceWithdrawal;
        private System.Windows.Forms.GroupBox gbxRentalAgreement;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Panel pnlDetailTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubcategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Price;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Subtotal;
    }
}