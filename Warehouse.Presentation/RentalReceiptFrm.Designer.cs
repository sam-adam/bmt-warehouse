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
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.stpRentalReceipt = new System.Windows.Forms.StatusStrip();
            this.tssHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHelpCustomerSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHelpDetailSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSave = new Warehouse.Presentation.Controls.ButtonStripItem();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.txtCustomerTitle = new System.Windows.Forms.TextBox();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.dtpRentalDate = new System.Windows.Forms.DateTimePicker();
            this.lblRentalDate = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.lblExtReference = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.dgvRentalReceiptDetail = new System.Windows.Forms.DataGridView();
            this.ProductCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSubcategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSubcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveLine = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.lblSender = new System.Windows.Forms.Label();
            this.tabReceiptDetails = new System.Windows.Forms.TabControl();
            this.tpgItemDetail = new System.Windows.Forms.TabPage();
            this.pnlItemDetailTop = new System.Windows.Forms.Panel();
            this.tpgLoadingDetail = new System.Windows.Forms.TabPage();
            this.dgvRentalReceiptLoadingDetail = new System.Windows.Forms.DataGridView();
            this.LoadingDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadingPrice = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.pnlLoadingDetailTop = new System.Windows.Forms.Panel();
            this.btnAddLoading = new System.Windows.Forms.Button();
            this.btnRemoveLoading = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.gbxOther = new System.Windows.Forms.GroupBox();
            this.lblRentalAgreement = new System.Windows.Forms.Label();
            this.txtRentalAgreement = new System.Windows.Forms.TextBox();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.stpRentalReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalReceiptDetail)).BeginInit();
            this.tabReceiptDetails.SuspendLayout();
            this.tpgItemDetail.SuspendLayout();
            this.pnlItemDetailTop.SuspendLayout();
            this.tpgLoadingDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalReceiptLoadingDetail)).BeginInit();
            this.pnlLoadingDetailTop.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.gbxOther.SuspendLayout();
            this.gbxCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Enabled = false;
            this.dtpTransactionDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpTransactionDate.Location = new System.Drawing.Point(112, 10);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(250, 21);
            this.dtpTransactionDate.TabIndex = 6;
            this.dtpTransactionDate.TabStop = false;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTransactionDate.Location = new System.Drawing.Point(13, 13);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(93, 13);
            this.lblTransactionDate.TabIndex = 5;
            this.lblTransactionDate.Text = "Transaction Date:";
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
            this.txtCustomerPhone.TabIndex = 31;
            this.txtCustomerPhone.TabStop = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerName.Location = new System.Drawing.Point(25, 74);
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
            this.txtCustomerName.Location = new System.Drawing.Point(124, 71);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(250, 21);
            this.txtCustomerName.TabIndex = 24;
            this.txtCustomerName.TabStop = false;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerId.Location = new System.Drawing.Point(25, 20);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(21, 13);
            this.lblCustomerId.TabIndex = 25;
            this.lblCustomerId.Text = "Id:";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerPhone.Location = new System.Drawing.Point(25, 101);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(41, 13);
            this.lblCustomerPhone.TabIndex = 28;
            this.lblCustomerPhone.Text = "Phone:";
            // 
            // stpRentalReceipt
            // 
            this.stpRentalReceipt.AutoSize = false;
            this.stpRentalReceipt.BackColor = System.Drawing.Color.White;
            this.stpRentalReceipt.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stpRentalReceipt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHelp,
            this.tssHelpCustomerSelection,
            this.tssHelpDetailSelection,
            this.btnSave});
            this.stpRentalReceipt.Location = new System.Drawing.Point(0, 703);
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
            // tssHelpDetailSelection
            // 
            this.tssHelpDetailSelection.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelpDetailSelection.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.tssHelpDetailSelection.Name = "tssHelpDetailSelection";
            this.tssHelpDetailSelection.Padding = new System.Windows.Forms.Padding(10);
            this.tssHelpDetailSelection.Size = new System.Drawing.Size(414, 26);
            this.tssHelpDetailSelection.Spring = true;
            this.tssHelpDetailSelection.Text = "F2 :  Open Item Detail Selection";
            this.tssHelpDetailSelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 27);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnViewCustomer.Location = new System.Drawing.Point(230, 16);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(35, 23);
            this.btnViewCustomer.TabIndex = 2;
            this.btnViewCustomer.Text = "...";
            this.btnViewCustomer.UseVisualStyleBackColor = true;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
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
            this.txtCustomerTitle.TabIndex = 42;
            this.txtCustomerTitle.TabStop = false;
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerTitle.Location = new System.Drawing.Point(25, 47);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerTitle.TabIndex = 41;
            this.lblCustomerTitle.Text = "Type:";
            // 
            // dtpRentalDate
            // 
            this.dtpRentalDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpRentalDate.Location = new System.Drawing.Point(124, 16);
            this.dtpRentalDate.Name = "dtpRentalDate";
            this.dtpRentalDate.Size = new System.Drawing.Size(250, 21);
            this.dtpRentalDate.TabIndex = 45;
            // 
            // lblRentalDate
            // 
            this.lblRentalDate.AutoSize = true;
            this.lblRentalDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblRentalDate.Location = new System.Drawing.Point(25, 22);
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
            this.txtReference.Location = new System.Drawing.Point(516, 43);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(141, 21);
            this.txtReference.TabIndex = 4;
            // 
            // lblExtReference
            // 
            this.lblExtReference.AutoSize = true;
            this.lblExtReference.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblExtReference.Location = new System.Drawing.Point(417, 46);
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
            this.txtCustomerEmail.Location = new System.Drawing.Point(516, 98);
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
            this.txtCustomerAddress.Location = new System.Drawing.Point(516, 17);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(294, 75);
            this.txtCustomerAddress.TabIndex = 51;
            this.txtCustomerAddress.TabStop = false;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerEmail.Location = new System.Drawing.Point(417, 101);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerEmail.TabIndex = 50;
            this.lblCustomerEmail.Text = "Email:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerAddress.Location = new System.Drawing.Point(417, 20);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(50, 13);
            this.lblCustomerAddress.TabIndex = 49;
            this.lblCustomerAddress.Text = "Address:";
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
            this.Brand,
            this.Description,
            this.Quantity,
            this.Remark});
            this.dgvRentalReceiptDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentalReceiptDetail.EnableHeadersVisualStyles = false;
            this.dgvRentalReceiptDetail.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRentalReceiptDetail.Location = new System.Drawing.Point(3, 36);
            this.dgvRentalReceiptDetail.Name = "dgvRentalReceiptDetail";
            this.dgvRentalReceiptDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRentalReceiptDetail.RowHeadersVisible = false;
            this.dgvRentalReceiptDetail.Size = new System.Drawing.Size(826, 360);
            this.dgvRentalReceiptDetail.TabIndex = 53;
            this.dgvRentalReceiptDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentalReceiptDetail_CellValueChanged);
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
            this.ProductCategory.Width = 77;
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
            this.ProductSubcategory.Width = 93;
            // 
            // Brand
            // 
            dataGridViewCellStyle3.Format = "C2";
            this.Brand.DefaultCellStyle = dataGridViewCellStyle3;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.Width = 60;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 85;
            // 
            // Quantity
            // 
            // 
            // 
            // 
            this.Quantity.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Quantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 74;
            // 
            // Remark
            // 
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.Width = 68;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 25);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveLine
            // 
            this.btnRemoveLine.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnRemoveLine.Location = new System.Drawing.Point(79, 3);
            this.btnRemoveLine.Name = "btnRemoveLine";
            this.btnRemoveLine.Size = new System.Drawing.Size(70, 25);
            this.btnRemoveLine.TabIndex = 56;
            this.btnRemoveLine.Text = "Remove";
            this.btnRemoveLine.UseVisualStyleBackColor = true;
            this.btnRemoveLine.Click += new System.EventHandler(this.btnRemoveLine_Click);
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
            this.txtCustomerId.Size = new System.Drawing.Size(100, 21);
            this.txtCustomerId.TabIndex = 1;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // txtSender
            // 
            this.txtSender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSender.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSender.Location = new System.Drawing.Point(516, 16);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(141, 21);
            this.txtSender.TabIndex = 3;
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblSender.Location = new System.Drawing.Point(417, 22);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(45, 13);
            this.lblSender.TabIndex = 58;
            this.lblSender.Text = "Sender:";
            // 
            // tabReceiptDetails
            // 
            this.tabReceiptDetails.Controls.Add(this.tpgItemDetail);
            this.tabReceiptDetails.Controls.Add(this.tpgLoadingDetail);
            this.tabReceiptDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReceiptDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tabReceiptDetails.Location = new System.Drawing.Point(0, 278);
            this.tabReceiptDetails.Name = "tabReceiptDetails";
            this.tabReceiptDetails.SelectedIndex = 0;
            this.tabReceiptDetails.Size = new System.Drawing.Size(840, 425);
            this.tabReceiptDetails.TabIndex = 59;
            // 
            // tpgItemDetail
            // 
            this.tpgItemDetail.Controls.Add(this.dgvRentalReceiptDetail);
            this.tpgItemDetail.Controls.Add(this.pnlItemDetailTop);
            this.tpgItemDetail.Location = new System.Drawing.Point(4, 22);
            this.tpgItemDetail.Name = "tpgItemDetail";
            this.tpgItemDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tpgItemDetail.Size = new System.Drawing.Size(832, 399);
            this.tpgItemDetail.TabIndex = 0;
            this.tpgItemDetail.Text = "Item";
            this.tpgItemDetail.UseVisualStyleBackColor = true;
            // 
            // pnlItemDetailTop
            // 
            this.pnlItemDetailTop.Controls.Add(this.btnAdd);
            this.pnlItemDetailTop.Controls.Add(this.btnRemoveLine);
            this.pnlItemDetailTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlItemDetailTop.Location = new System.Drawing.Point(3, 3);
            this.pnlItemDetailTop.Name = "pnlItemDetailTop";
            this.pnlItemDetailTop.Size = new System.Drawing.Size(826, 33);
            this.pnlItemDetailTop.TabIndex = 57;
            // 
            // tpgLoadingDetail
            // 
            this.tpgLoadingDetail.Controls.Add(this.dgvRentalReceiptLoadingDetail);
            this.tpgLoadingDetail.Controls.Add(this.pnlLoadingDetailTop);
            this.tpgLoadingDetail.Location = new System.Drawing.Point(4, 22);
            this.tpgLoadingDetail.Name = "tpgLoadingDetail";
            this.tpgLoadingDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tpgLoadingDetail.Size = new System.Drawing.Size(832, 399);
            this.tpgLoadingDetail.TabIndex = 1;
            this.tpgLoadingDetail.Text = "Loading";
            this.tpgLoadingDetail.UseVisualStyleBackColor = true;
            // 
            // dgvRentalReceiptLoadingDetail
            // 
            this.dgvRentalReceiptLoadingDetail.AllowUserToAddRows = false;
            this.dgvRentalReceiptLoadingDetail.AllowUserToDeleteRows = false;
            this.dgvRentalReceiptLoadingDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRentalReceiptLoadingDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvRentalReceiptLoadingDetail.ColumnHeadersHeight = 25;
            this.dgvRentalReceiptLoadingDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoadingDescription,
            this.LoadingPrice});
            this.dgvRentalReceiptLoadingDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentalReceiptLoadingDetail.EnableHeadersVisualStyles = false;
            this.dgvRentalReceiptLoadingDetail.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRentalReceiptLoadingDetail.Location = new System.Drawing.Point(3, 36);
            this.dgvRentalReceiptLoadingDetail.Name = "dgvRentalReceiptLoadingDetail";
            this.dgvRentalReceiptLoadingDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRentalReceiptLoadingDetail.RowHeadersVisible = false;
            this.dgvRentalReceiptLoadingDetail.Size = new System.Drawing.Size(826, 360);
            this.dgvRentalReceiptLoadingDetail.TabIndex = 59;
            this.dgvRentalReceiptLoadingDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentalReceiptLoadingDetail_CellValueChanged);
            // 
            // LoadingDescription
            // 
            this.LoadingDescription.HeaderText = "Description";
            this.LoadingDescription.Name = "LoadingDescription";
            this.LoadingDescription.Width = 85;
            // 
            // LoadingPrice
            // 
            // 
            // 
            // 
            this.LoadingPrice.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.LoadingPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LoadingPrice.HeaderText = "Price";
            this.LoadingPrice.Increment = 1D;
            this.LoadingPrice.Name = "LoadingPrice";
            this.LoadingPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoadingPrice.Width = 55;
            // 
            // pnlLoadingDetailTop
            // 
            this.pnlLoadingDetailTop.Controls.Add(this.btnAddLoading);
            this.pnlLoadingDetailTop.Controls.Add(this.btnRemoveLoading);
            this.pnlLoadingDetailTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoadingDetailTop.Location = new System.Drawing.Point(3, 3);
            this.pnlLoadingDetailTop.Name = "pnlLoadingDetailTop";
            this.pnlLoadingDetailTop.Size = new System.Drawing.Size(826, 33);
            this.pnlLoadingDetailTop.TabIndex = 58;
            // 
            // btnAddLoading
            // 
            this.btnAddLoading.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnAddLoading.Location = new System.Drawing.Point(3, 3);
            this.btnAddLoading.Name = "btnAddLoading";
            this.btnAddLoading.Size = new System.Drawing.Size(70, 25);
            this.btnAddLoading.TabIndex = 54;
            this.btnAddLoading.Text = "Add";
            this.btnAddLoading.UseVisualStyleBackColor = true;
            this.btnAddLoading.Click += new System.EventHandler(this.btnAddLoading_Click);
            // 
            // btnRemoveLoading
            // 
            this.btnRemoveLoading.Enabled = false;
            this.btnRemoveLoading.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnRemoveLoading.Location = new System.Drawing.Point(79, 3);
            this.btnRemoveLoading.Name = "btnRemoveLoading";
            this.btnRemoveLoading.Size = new System.Drawing.Size(70, 25);
            this.btnRemoveLoading.TabIndex = 56;
            this.btnRemoveLoading.Text = "Remove";
            this.btnRemoveLoading.UseVisualStyleBackColor = true;
            this.btnRemoveLoading.Click += new System.EventHandler(this.btnRemoveLoading_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTransactionDate);
            this.pnlTop.Controls.Add(this.dtpTransactionDate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(840, 39);
            this.pnlTop.TabIndex = 60;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.gbxOther);
            this.pnlHeader.Controls.Add(this.gbxCustomer);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 39);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(840, 239);
            this.pnlHeader.TabIndex = 61;
            // 
            // gbxOther
            // 
            this.gbxOther.Controls.Add(this.lblRentalAgreement);
            this.gbxOther.Controls.Add(this.txtRentalAgreement);
            this.gbxOther.Controls.Add(this.lblRentalDate);
            this.gbxOther.Controls.Add(this.lblExtReference);
            this.gbxOther.Controls.Add(this.txtReference);
            this.gbxOther.Controls.Add(this.dtpRentalDate);
            this.gbxOther.Controls.Add(this.lblSender);
            this.gbxOther.Controls.Add(this.txtSender);
            this.gbxOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxOther.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbxOther.Location = new System.Drawing.Point(0, 129);
            this.gbxOther.Name = "gbxOther";
            this.gbxOther.Size = new System.Drawing.Size(840, 104);
            this.gbxOther.TabIndex = 63;
            this.gbxOther.TabStop = false;
            this.gbxOther.Text = "Other";
            // 
            // lblRentalAgreement
            // 
            this.lblRentalAgreement.AutoSize = true;
            this.lblRentalAgreement.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblRentalAgreement.Location = new System.Drawing.Point(25, 49);
            this.lblRentalAgreement.Name = "lblRentalAgreement";
            this.lblRentalAgreement.Size = new System.Drawing.Size(98, 13);
            this.lblRentalAgreement.TabIndex = 60;
            this.lblRentalAgreement.Text = "Rental Agreement:";
            // 
            // txtRentalAgreement
            // 
            this.txtRentalAgreement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRentalAgreement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRentalAgreement.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRentalAgreement.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtRentalAgreement.Location = new System.Drawing.Point(124, 46);
            this.txtRentalAgreement.Name = "txtRentalAgreement";
            this.txtRentalAgreement.ReadOnly = true;
            this.txtRentalAgreement.Size = new System.Drawing.Size(141, 21);
            this.txtRentalAgreement.TabIndex = 59;
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.lblCustomerId);
            this.gbxCustomer.Controls.Add(this.lblCustomerPhone);
            this.gbxCustomer.Controls.Add(this.txtCustomerName);
            this.gbxCustomer.Controls.Add(this.lblCustomerName);
            this.gbxCustomer.Controls.Add(this.txtCustomerPhone);
            this.gbxCustomer.Controls.Add(this.txtCustomerId);
            this.gbxCustomer.Controls.Add(this.txtCustomerEmail);
            this.gbxCustomer.Controls.Add(this.btnViewCustomer);
            this.gbxCustomer.Controls.Add(this.txtCustomerAddress);
            this.gbxCustomer.Controls.Add(this.lblCustomerTitle);
            this.gbxCustomer.Controls.Add(this.lblCustomerEmail);
            this.gbxCustomer.Controls.Add(this.txtCustomerTitle);
            this.gbxCustomer.Controls.Add(this.lblCustomerAddress);
            this.gbxCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbxCustomer.Location = new System.Drawing.Point(0, 0);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Size = new System.Drawing.Size(840, 129);
            this.gbxCustomer.TabIndex = 62;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "Customer";
            // 
            // RentalReceiptFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 734);
            this.Controls.Add(this.tabReceiptDetails);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.stpRentalReceipt);
            this.MinimumSize = new System.Drawing.Size(850, 740);
            this.Name = "RentalReceiptFrm";
            this.Text = "Rental Receipt";
            this.stpRentalReceipt.ResumeLayout(false);
            this.stpRentalReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalReceiptDetail)).EndInit();
            this.tabReceiptDetails.ResumeLayout(false);
            this.tpgItemDetail.ResumeLayout(false);
            this.pnlItemDetailTop.ResumeLayout(false);
            this.tpgLoadingDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalReceiptLoadingDetail)).EndInit();
            this.pnlLoadingDetailTop.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.gbxOther.ResumeLayout(false);
            this.gbxOther.PerformLayout();
            this.gbxCustomer.ResumeLayout(false);
            this.gbxCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.StatusStrip stpRentalReceipt;
        private System.Windows.Forms.ToolStripStatusLabel tssHelp;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpCustomerSelection;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.TextBox txtCustomerTitle;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.DateTimePicker dtpRentalDate;
        private System.Windows.Forms.Label lblRentalDate;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label lblExtReference;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.DataGridView dgvRentalReceiptDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveLine;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpDetailSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubcategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private Controls.ButtonStripItem btnSave;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.TabControl tabReceiptDetails;
        private System.Windows.Forms.TabPage tpgItemDetail;
        private System.Windows.Forms.TabPage tpgLoadingDetail;
        private System.Windows.Forms.Panel pnlItemDetailTop;
        private System.Windows.Forms.DataGridView dgvRentalReceiptLoadingDetail;
        private System.Windows.Forms.Panel pnlLoadingDetailTop;
        private System.Windows.Forms.Button btnAddLoading;
        private System.Windows.Forms.Button btnRemoveLoading;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.GroupBox gbxOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoadingDescription;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn LoadingPrice;
        private System.Windows.Forms.Label lblRentalAgreement;
        private System.Windows.Forms.TextBox txtRentalAgreement;
    }
}