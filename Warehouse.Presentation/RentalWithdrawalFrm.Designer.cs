namespace Warehouse.Presentation
{
    partial class RentalWithdrawalFrm
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
            this.stpRentalWithdrawal = new System.Windows.Forms.StatusStrip();
            this.tssHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHelpCustomerSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSave = new Warehouse.Presentation.Controls.ButtonStripItem();
            this.dtpRentalDate = new System.Windows.Forms.DateTimePicker();
            this.lblWithdrawalDate = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.lblExtReference = new System.Windows.Forms.Label();
            this.dgvItemDetail = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.gbxOther = new System.Windows.Forms.GroupBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tabWithdrawalDetail = new System.Windows.Forms.TabControl();
            this.tpgItemDetail = new System.Windows.Forms.TabPage();
            this.tpgUnloadingDetail = new System.Windows.Forms.TabPage();
            this.dgvUnloadingDetail = new System.Windows.Forms.DataGridView();
            this.UnloadingDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnloadingPrice = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.pnlUnloadingDetailTop = new System.Windows.Forms.Panel();
            this.btnAddUnloading = new System.Windows.Forms.Button();
            this.btnRemoveUnloading = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSubcategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSubcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.stpRentalWithdrawal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetail)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.gbxCustomer.SuspendLayout();
            this.gbxOther.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tabWithdrawalDetail.SuspendLayout();
            this.tpgItemDetail.SuspendLayout();
            this.tpgUnloadingDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnloadingDetail)).BeginInit();
            this.pnlUnloadingDetailTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Enabled = false;
            this.dtpTransactionDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpTransactionDate.Location = new System.Drawing.Point(112, 10);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(250, 21);
            this.dtpTransactionDate.TabIndex = 8;
            this.dtpTransactionDate.TabStop = false;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTransactionDate.Location = new System.Drawing.Point(13, 13);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(93, 13);
            this.lblTransactionDate.TabIndex = 7;
            this.lblTransactionDate.Text = "Transaction Date:";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerEmail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerEmail.Location = new System.Drawing.Point(494, 98);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.ReadOnly = true;
            this.txtCustomerEmail.Size = new System.Drawing.Size(250, 21);
            this.txtCustomerEmail.TabIndex = 66;
            this.txtCustomerEmail.TabStop = false;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerAddress.Location = new System.Drawing.Point(494, 17);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(294, 75);
            this.txtCustomerAddress.TabIndex = 65;
            this.txtCustomerAddress.TabStop = false;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerEmail.Location = new System.Drawing.Point(404, 101);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerEmail.TabIndex = 64;
            this.lblCustomerEmail.Text = "Email:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerAddress.Location = new System.Drawing.Point(404, 20);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(50, 13);
            this.lblCustomerAddress.TabIndex = 63;
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
            this.txtCustomerTitle.TabIndex = 62;
            this.txtCustomerTitle.TabStop = false;
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerTitle.Location = new System.Drawing.Point(25, 47);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(31, 13);
            this.lblCustomerTitle.TabIndex = 61;
            this.lblCustomerTitle.Text = "Title:";
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnViewCustomer.Location = new System.Drawing.Point(230, 16);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(35, 23);
            this.btnViewCustomer.TabIndex = 54;
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
            this.txtCustomerId.Location = new System.Drawing.Point(124, 17);
            this.txtCustomerId.MaxLength = 6;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 21);
            this.txtCustomerId.TabIndex = 53;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
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
            this.txtCustomerPhone.TabIndex = 59;
            this.txtCustomerPhone.TabStop = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerName.Location = new System.Drawing.Point(25, 74);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 13);
            this.lblCustomerName.TabIndex = 55;
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
            this.txtCustomerName.TabIndex = 56;
            this.txtCustomerName.TabStop = false;
            // 
            // lblRentalAgreementCustomer
            // 
            this.lblRentalAgreementCustomer.AutoSize = true;
            this.lblRentalAgreementCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblRentalAgreementCustomer.Location = new System.Drawing.Point(25, 20);
            this.lblRentalAgreementCustomer.Name = "lblRentalAgreementCustomer";
            this.lblRentalAgreementCustomer.Size = new System.Drawing.Size(57, 13);
            this.lblRentalAgreementCustomer.TabIndex = 57;
            this.lblRentalAgreementCustomer.Text = "Customer:";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerPhone.Location = new System.Drawing.Point(25, 101);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(41, 13);
            this.lblCustomerPhone.TabIndex = 58;
            this.lblCustomerPhone.Text = "Phone:";
            // 
            // stpRentalWithdrawal
            // 
            this.stpRentalWithdrawal.AutoSize = false;
            this.stpRentalWithdrawal.BackColor = System.Drawing.Color.White;
            this.stpRentalWithdrawal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stpRentalWithdrawal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHelp,
            this.tssHelpCustomerSelection,
            this.btnSave});
            this.stpRentalWithdrawal.Location = new System.Drawing.Point(0, 541);
            this.stpRentalWithdrawal.Name = "stpRentalWithdrawal";
            this.stpRentalWithdrawal.Size = new System.Drawing.Size(898, 31);
            this.stpRentalWithdrawal.TabIndex = 68;
            // 
            // tssHelp
            // 
            this.tssHelp.BackColor = System.Drawing.Color.Transparent;
            this.tssHelp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssHelp.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelp.Name = "tssHelp";
            this.tssHelp.Padding = new System.Windows.Forms.Padding(10);
            this.tssHelp.Size = new System.Drawing.Size(173, 26);
            this.tssHelp.Text = "Create new rental withdrawal";
            // 
            // tssHelpCustomerSelection
            // 
            this.tssHelpCustomerSelection.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelpCustomerSelection.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.tssHelpCustomerSelection.Name = "tssHelpCustomerSelection";
            this.tssHelpCustomerSelection.Padding = new System.Windows.Forms.Padding(10);
            this.tssHelpCustomerSelection.Size = new System.Drawing.Size(630, 26);
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
            // dtpRentalDate
            // 
            this.dtpRentalDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpRentalDate.Location = new System.Drawing.Point(124, 20);
            this.dtpRentalDate.Name = "dtpRentalDate";
            this.dtpRentalDate.Size = new System.Drawing.Size(250, 21);
            this.dtpRentalDate.TabIndex = 69;
            // 
            // lblWithdrawalDate
            // 
            this.lblWithdrawalDate.AutoSize = true;
            this.lblWithdrawalDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblWithdrawalDate.Location = new System.Drawing.Point(25, 23);
            this.lblWithdrawalDate.Name = "lblWithdrawalDate";
            this.lblWithdrawalDate.Size = new System.Drawing.Size(91, 13);
            this.lblWithdrawalDate.TabIndex = 72;
            this.lblWithdrawalDate.Text = "Withdrawal Date:";
            // 
            // txtReference
            // 
            this.txtReference.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtReference.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtReference.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReference.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtReference.Location = new System.Drawing.Point(494, 20);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(141, 21);
            this.txtReference.TabIndex = 70;
            // 
            // lblExtReference
            // 
            this.lblExtReference.AutoSize = true;
            this.lblExtReference.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblExtReference.Location = new System.Drawing.Point(404, 23);
            this.lblExtReference.Name = "lblExtReference";
            this.lblExtReference.Size = new System.Drawing.Size(84, 13);
            this.lblExtReference.TabIndex = 71;
            this.lblExtReference.Text = "Ext. Reference:";
            // 
            // dgvItemDetail
            // 
            this.dgvItemDetail.AllowUserToAddRows = false;
            this.dgvItemDetail.AllowUserToDeleteRows = false;
            this.dgvItemDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvItemDetail.ColumnHeadersHeight = 25;
            this.dgvItemDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductCategoryId,
            this.ProductCategory,
            this.ProductSubcategoryId,
            this.ProductSubcategory,
            this.Brand,
            this.Description,
            this.Stock,
            this.Quantity});
            this.dgvItemDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemDetail.EnableHeadersVisualStyles = false;
            this.dgvItemDetail.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvItemDetail.Location = new System.Drawing.Point(3, 3);
            this.dgvItemDetail.Name = "dgvItemDetail";
            this.dgvItemDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItemDetail.RowHeadersVisible = false;
            this.dgvItemDetail.Size = new System.Drawing.Size(884, 266);
            this.dgvItemDetail.TabIndex = 75;
            this.dgvItemDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentalWithdrawalDetail_CellValueChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTransactionDate);
            this.pnlTop.Controls.Add(this.dtpTransactionDate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(898, 39);
            this.pnlTop.TabIndex = 76;
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.lblRentalAgreementCustomer);
            this.gbxCustomer.Controls.Add(this.lblCustomerPhone);
            this.gbxCustomer.Controls.Add(this.txtCustomerName);
            this.gbxCustomer.Controls.Add(this.lblCustomerName);
            this.gbxCustomer.Controls.Add(this.txtCustomerPhone);
            this.gbxCustomer.Controls.Add(this.txtCustomerId);
            this.gbxCustomer.Controls.Add(this.btnViewCustomer);
            this.gbxCustomer.Controls.Add(this.lblCustomerTitle);
            this.gbxCustomer.Controls.Add(this.txtCustomerTitle);
            this.gbxCustomer.Controls.Add(this.lblCustomerAddress);
            this.gbxCustomer.Controls.Add(this.lblCustomerEmail);
            this.gbxCustomer.Controls.Add(this.txtCustomerEmail);
            this.gbxCustomer.Controls.Add(this.txtCustomerAddress);
            this.gbxCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbxCustomer.Location = new System.Drawing.Point(0, 0);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Size = new System.Drawing.Size(898, 127);
            this.gbxCustomer.TabIndex = 77;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "Customer";
            // 
            // gbxOther
            // 
            this.gbxOther.Controls.Add(this.lblWithdrawalDate);
            this.gbxOther.Controls.Add(this.lblExtReference);
            this.gbxOther.Controls.Add(this.txtReference);
            this.gbxOther.Controls.Add(this.dtpRentalDate);
            this.gbxOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxOther.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbxOther.Location = new System.Drawing.Point(0, 127);
            this.gbxOther.Name = "gbxOther";
            this.gbxOther.Size = new System.Drawing.Size(898, 66);
            this.gbxOther.TabIndex = 78;
            this.gbxOther.TabStop = false;
            this.gbxOther.Text = "Other";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.gbxOther);
            this.pnlHeader.Controls.Add(this.gbxCustomer);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 39);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(898, 204);
            this.pnlHeader.TabIndex = 79;
            // 
            // tabWithdrawalDetail
            // 
            this.tabWithdrawalDetail.Controls.Add(this.tpgItemDetail);
            this.tabWithdrawalDetail.Controls.Add(this.tpgUnloadingDetail);
            this.tabWithdrawalDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWithdrawalDetail.Location = new System.Drawing.Point(0, 0);
            this.tabWithdrawalDetail.Name = "tabWithdrawalDetail";
            this.tabWithdrawalDetail.SelectedIndex = 0;
            this.tabWithdrawalDetail.Size = new System.Drawing.Size(898, 298);
            this.tabWithdrawalDetail.TabIndex = 80;
            // 
            // tpgItemDetail
            // 
            this.tpgItemDetail.Controls.Add(this.dgvItemDetail);
            this.tpgItemDetail.Location = new System.Drawing.Point(4, 22);
            this.tpgItemDetail.Name = "tpgItemDetail";
            this.tpgItemDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tpgItemDetail.Size = new System.Drawing.Size(890, 272);
            this.tpgItemDetail.TabIndex = 0;
            this.tpgItemDetail.Text = "Item";
            this.tpgItemDetail.UseVisualStyleBackColor = true;
            // 
            // tpgUnloadingDetail
            // 
            this.tpgUnloadingDetail.Controls.Add(this.dgvUnloadingDetail);
            this.tpgUnloadingDetail.Controls.Add(this.pnlUnloadingDetailTop);
            this.tpgUnloadingDetail.Location = new System.Drawing.Point(4, 22);
            this.tpgUnloadingDetail.Name = "tpgUnloadingDetail";
            this.tpgUnloadingDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tpgUnloadingDetail.Size = new System.Drawing.Size(890, 272);
            this.tpgUnloadingDetail.TabIndex = 1;
            this.tpgUnloadingDetail.Text = "Unloading";
            this.tpgUnloadingDetail.UseVisualStyleBackColor = true;
            // 
            // dgvUnloadingDetail
            // 
            this.dgvUnloadingDetail.AllowUserToAddRows = false;
            this.dgvUnloadingDetail.AllowUserToDeleteRows = false;
            this.dgvUnloadingDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUnloadingDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvUnloadingDetail.ColumnHeadersHeight = 25;
            this.dgvUnloadingDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnloadingDescription,
            this.UnloadingPrice});
            this.dgvUnloadingDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnloadingDetail.EnableHeadersVisualStyles = false;
            this.dgvUnloadingDetail.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUnloadingDetail.Location = new System.Drawing.Point(3, 36);
            this.dgvUnloadingDetail.Name = "dgvUnloadingDetail";
            this.dgvUnloadingDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUnloadingDetail.RowHeadersVisible = false;
            this.dgvUnloadingDetail.Size = new System.Drawing.Size(884, 233);
            this.dgvUnloadingDetail.TabIndex = 76;
            this.dgvUnloadingDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnloadingDetail_CellValueChanged);
            this.dgvUnloadingDetail.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvUnloadingDetail_RowsAdded);
            this.dgvUnloadingDetail.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvUnloadingDetail_RowsRemoved);
            // 
            // UnloadingDescription
            // 
            this.UnloadingDescription.HeaderText = "Description";
            this.UnloadingDescription.Name = "UnloadingDescription";
            this.UnloadingDescription.Width = 85;
            // 
            // UnloadingPrice
            // 
            // 
            // 
            // 
            this.UnloadingPrice.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.UnloadingPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.UnloadingPrice.HeaderText = "Price";
            this.UnloadingPrice.Increment = 1D;
            this.UnloadingPrice.Name = "UnloadingPrice";
            this.UnloadingPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnloadingPrice.Width = 56;
            // 
            // pnlUnloadingDetailTop
            // 
            this.pnlUnloadingDetailTop.Controls.Add(this.btnAddUnloading);
            this.pnlUnloadingDetailTop.Controls.Add(this.btnRemoveUnloading);
            this.pnlUnloadingDetailTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUnloadingDetailTop.Location = new System.Drawing.Point(3, 3);
            this.pnlUnloadingDetailTop.Name = "pnlUnloadingDetailTop";
            this.pnlUnloadingDetailTop.Size = new System.Drawing.Size(884, 33);
            this.pnlUnloadingDetailTop.TabIndex = 77;
            // 
            // btnAddUnloading
            // 
            this.btnAddUnloading.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnAddUnloading.Location = new System.Drawing.Point(3, 3);
            this.btnAddUnloading.Name = "btnAddUnloading";
            this.btnAddUnloading.Size = new System.Drawing.Size(70, 25);
            this.btnAddUnloading.TabIndex = 54;
            this.btnAddUnloading.Text = "Add";
            this.btnAddUnloading.UseVisualStyleBackColor = true;
            this.btnAddUnloading.Click += new System.EventHandler(this.btnAddUnloading_Click);
            // 
            // btnRemoveUnloading
            // 
            this.btnRemoveUnloading.Enabled = false;
            this.btnRemoveUnloading.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnRemoveUnloading.Location = new System.Drawing.Point(79, 3);
            this.btnRemoveUnloading.Name = "btnRemoveUnloading";
            this.btnRemoveUnloading.Size = new System.Drawing.Size(70, 25);
            this.btnRemoveUnloading.TabIndex = 56;
            this.btnRemoveUnloading.Text = "Remove";
            this.btnRemoveUnloading.UseVisualStyleBackColor = true;
            this.btnRemoveUnloading.Click += new System.EventHandler(this.btnRemoveUnloading_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.tabWithdrawalDetail);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 243);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(898, 298);
            this.pnlBottom.TabIndex = 81;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            this.ProductId.Width = 81;
            // 
            // ProductCategoryId
            // 
            this.ProductCategoryId.HeaderText = "Category Id";
            this.ProductCategoryId.Name = "ProductCategoryId";
            this.ProductCategoryId.ReadOnly = true;
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
            this.ProductSubcategoryId.ReadOnly = true;
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
            // Stock
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Stock.DefaultCellStyle = dataGridViewCellStyle5;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 60;
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
            this.Quantity.Width = 71;
            // 
            // RentalWithdrawalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 572);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.stpRentalWithdrawal);
            this.Name = "RentalWithdrawalFrm";
            this.Text = "Rental Withdrawal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.stpRentalWithdrawal.ResumeLayout(false);
            this.stpRentalWithdrawal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetail)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.gbxCustomer.ResumeLayout(false);
            this.gbxCustomer.PerformLayout();
            this.gbxOther.ResumeLayout(false);
            this.gbxOther.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.tabWithdrawalDetail.ResumeLayout(false);
            this.tpgItemDetail.ResumeLayout(false);
            this.tpgUnloadingDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnloadingDetail)).EndInit();
            this.pnlUnloadingDetailTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.StatusStrip stpRentalWithdrawal;
        private System.Windows.Forms.ToolStripStatusLabel tssHelp;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpCustomerSelection;
        private Controls.ButtonStripItem btnSave;
        private System.Windows.Forms.DateTimePicker dtpRentalDate;
        private System.Windows.Forms.Label lblWithdrawalDate;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label lblExtReference;
        private System.Windows.Forms.DataGridView dgvItemDetail;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.GroupBox gbxOther;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TabControl tabWithdrawalDetail;
        private System.Windows.Forms.TabPage tpgItemDetail;
        private System.Windows.Forms.TabPage tpgUnloadingDetail;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.DataGridView dgvUnloadingDetail;
        private System.Windows.Forms.Panel pnlUnloadingDetailTop;
        private System.Windows.Forms.Button btnAddUnloading;
        private System.Windows.Forms.Button btnRemoveUnloading;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnloadingDescription;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn UnloadingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubcategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn Quantity;
    }
}