﻿namespace Warehouse.Presentation
{
    partial class RentalAgreementFrm
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
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.tssHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHelpCustomerSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHelpCategorySelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSave = new Warehouse.Presentation.Controls.ButtonStripItem();
            this.btnClose = new Warehouse.Presentation.Controls.ButtonStripItem();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.txtCustomerTitle = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.lblExtReference = new System.Windows.Forms.Label();
            this.dtpAgreementDate = new System.Windows.Forms.DateTimePicker();
            this.lblAgreementDate = new System.Windows.Forms.Label();
            this.dgvProductCategoryPrice = new System.Windows.Forms.DataGridView();
            this.ProductCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSubcategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSubcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.IsRemovable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCutOffDate = new System.Windows.Forms.Label();
            this.numCutOffDate = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveLine = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.pnlAgreementDetailAction = new System.Windows.Forms.Panel();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.gbxOther = new System.Windows.Forms.GroupBox();
            this.stpRentalAgreement = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonStripItem3 = new Warehouse.Presentation.Controls.ButtonStripItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonStripItem1 = new Warehouse.Presentation.Controls.ButtonStripItem();
            this.buttonStripItem2 = new Warehouse.Presentation.Controls.ButtonStripItem();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCategoryPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCutOffDate)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlAgreementDetailAction.SuspendLayout();
            this.gbxCustomer.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.gbxOther.SuspendLayout();
            this.stpRentalAgreement.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerId.Location = new System.Drawing.Point(25, 20);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(21, 13);
            this.lblCustomerId.TabIndex = 1;
            this.lblCustomerId.Text = "Id:";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerEmail.Location = new System.Drawing.Point(428, 101);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerEmail.TabIndex = 13;
            this.lblCustomerEmail.Text = "Email:";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerPhone.Location = new System.Drawing.Point(25, 101);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(41, 13);
            this.lblCustomerPhone.TabIndex = 11;
            this.lblCustomerPhone.Text = "Phone:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerAddress.Location = new System.Drawing.Point(428, 20);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(50, 13);
            this.lblCustomerAddress.TabIndex = 7;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerTitle.Location = new System.Drawing.Point(25, 47);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerTitle.TabIndex = 5;
            this.lblCustomerTitle.Text = "Type:";
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
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.TabStop = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCustomerName.Location = new System.Drawing.Point(25, 74);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 13);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Name:";
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
            // tssHelp
            // 
            this.tssHelp.BackColor = System.Drawing.Color.Transparent;
            this.tssHelp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssHelp.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelp.Name = "tssHelp";
            this.tssHelp.Padding = new System.Windows.Forms.Padding(10);
            this.tssHelp.Size = new System.Drawing.Size(173, 26);
            this.tssHelp.Text = "Create new rental agreement";
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
            // tssHelpCategorySelection
            // 
            this.tssHelpCategorySelection.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.tssHelpCategorySelection.Name = "tssHelpCategorySelection";
            this.tssHelpCategorySelection.Size = new System.Drawing.Size(361, 26);
            this.tssHelpCategorySelection.Spring = true;
            this.tssHelpCategorySelection.Text = "F2 : Open Product Category Selection";
            this.tssHelpCategorySelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 29);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 29);
            this.btnClose.Text = "Close";
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.txtCustomerTitle.TabIndex = 16;
            this.txtCustomerTitle.TabStop = false;
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
            this.txtCustomerPhone.TabIndex = 17;
            this.txtCustomerPhone.TabStop = false;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerAddress.Location = new System.Drawing.Point(515, 17);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(308, 75);
            this.txtCustomerAddress.TabIndex = 18;
            this.txtCustomerAddress.TabStop = false;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerEmail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtCustomerEmail.Location = new System.Drawing.Point(515, 98);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.ReadOnly = true;
            this.txtCustomerEmail.Size = new System.Drawing.Size(250, 21);
            this.txtCustomerEmail.TabIndex = 19;
            this.txtCustomerEmail.TabStop = false;
            // 
            // txtReference
            // 
            this.txtReference.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtReference.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtReference.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReference.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtReference.Location = new System.Drawing.Point(124, 47);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(141, 21);
            this.txtReference.TabIndex = 6;
            // 
            // lblExtReference
            // 
            this.lblExtReference.AutoSize = true;
            this.lblExtReference.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblExtReference.Location = new System.Drawing.Point(25, 50);
            this.lblExtReference.Name = "lblExtReference";
            this.lblExtReference.Size = new System.Drawing.Size(84, 13);
            this.lblExtReference.TabIndex = 22;
            this.lblExtReference.Text = "Ext. Reference:";
            // 
            // dtpAgreementDate
            // 
            this.dtpAgreementDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpAgreementDate.Location = new System.Drawing.Point(124, 20);
            this.dtpAgreementDate.Name = "dtpAgreementDate";
            this.dtpAgreementDate.Size = new System.Drawing.Size(250, 21);
            this.dtpAgreementDate.TabIndex = 3;
            // 
            // lblAgreementDate
            // 
            this.lblAgreementDate.AutoSize = true;
            this.lblAgreementDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAgreementDate.Location = new System.Drawing.Point(25, 22);
            this.lblAgreementDate.Name = "lblAgreementDate";
            this.lblAgreementDate.Size = new System.Drawing.Size(90, 13);
            this.lblAgreementDate.TabIndex = 24;
            this.lblAgreementDate.Text = "Agreement Date:";
            // 
            // dgvProductCategoryPrice
            // 
            this.dgvProductCategoryPrice.AllowUserToAddRows = false;
            this.dgvProductCategoryPrice.AllowUserToDeleteRows = false;
            this.dgvProductCategoryPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductCategoryPrice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvProductCategoryPrice.ColumnHeadersHeight = 25;
            this.dgvProductCategoryPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCategoryId,
            this.ProductCategory,
            this.ProductSubcategoryId,
            this.ProductSubcategory,
            this.Price,
            this.IsRemovable});
            this.dgvProductCategoryPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductCategoryPrice.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductCategoryPrice.Location = new System.Drawing.Point(0, 37);
            this.dgvProductCategoryPrice.Name = "dgvProductCategoryPrice";
            this.dgvProductCategoryPrice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductCategoryPrice.RowHeadersVisible = false;
            this.dgvProductCategoryPrice.Size = new System.Drawing.Size(835, 229);
            this.dgvProductCategoryPrice.TabIndex = 7;
            this.dgvProductCategoryPrice.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvProductCategoryPrice_CellBeginEdit);
            this.dgvProductCategoryPrice.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductCategoryPrice_CellEnter);
            this.dgvProductCategoryPrice.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvProductCategoryPrice_UserDeletingRow);
            // 
            // ProductCategoryId
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProductCategoryId.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProductCategoryId.HeaderText = "Category Id";
            this.ProductCategoryId.Name = "ProductCategoryId";
            this.ProductCategoryId.ReadOnly = true;
            this.ProductCategoryId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductCategoryId.Width = 86;
            // 
            // ProductCategory
            // 
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
            this.ProductSubcategoryId.Width = 104;
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
            // Price
            // 
            // 
            // 
            // 
            this.Price.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Price.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "0";
            this.Price.DefaultCellStyle = dataGridViewCellStyle6;
            this.Price.HeaderText = "Price";
            this.Price.Increment = 1D;
            this.Price.Name = "Price";
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Price.Width = 56;
            // 
            // IsRemovable
            // 
            this.IsRemovable.HeaderText = "IsRemovable";
            this.IsRemovable.Name = "IsRemovable";
            this.IsRemovable.ReadOnly = true;
            this.IsRemovable.Visible = false;
            this.IsRemovable.Width = 94;
            // 
            // lblCutOffDate
            // 
            this.lblCutOffDate.AutoSize = true;
            this.lblCutOffDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCutOffDate.Location = new System.Drawing.Point(428, 22);
            this.lblCutOffDate.Name = "lblCutOffDate";
            this.lblCutOffDate.Size = new System.Drawing.Size(73, 13);
            this.lblCutOffDate.TabIndex = 29;
            this.lblCutOffDate.Text = "Cut Off Date:";
            // 
            // numCutOffDate
            // 
            this.numCutOffDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.numCutOffDate.Location = new System.Drawing.Point(515, 20);
            this.numCutOffDate.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numCutOffDate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCutOffDate.Name = "numCutOffDate";
            this.numCutOffDate.Size = new System.Drawing.Size(53, 21);
            this.numCutOffDate.TabIndex = 30;
            this.numCutOffDate.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // btnRemoveLine
            // 
            this.btnRemoveLine.Enabled = false;
            this.btnRemoveLine.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnRemoveLine.Location = new System.Drawing.Point(79, 3);
            this.btnRemoveLine.Name = "btnRemoveLine";
            this.btnRemoveLine.Size = new System.Drawing.Size(70, 25);
            this.btnRemoveLine.TabIndex = 58;
            this.btnRemoveLine.Text = "Remove";
            this.btnRemoveLine.UseVisualStyleBackColor = true;
            this.btnRemoveLine.Click += new System.EventHandler(this.btnRemoveLine_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 25);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.dgvProductCategoryPrice);
            this.pnlDetail.Controls.Add(this.pnlAgreementDetailAction);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 273);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(835, 266);
            this.pnlDetail.TabIndex = 59;
            // 
            // pnlAgreementDetailAction
            // 
            this.pnlAgreementDetailAction.Controls.Add(this.btnAdd);
            this.pnlAgreementDetailAction.Controls.Add(this.btnRemoveLine);
            this.pnlAgreementDetailAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAgreementDetailAction.Location = new System.Drawing.Point(0, 0);
            this.pnlAgreementDetailAction.Name = "pnlAgreementDetailAction";
            this.pnlAgreementDetailAction.Size = new System.Drawing.Size(835, 37);
            this.pnlAgreementDetailAction.TabIndex = 59;
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.lblCustomerId);
            this.gbxCustomer.Controls.Add(this.lblCustomerPhone);
            this.gbxCustomer.Controls.Add(this.lblCustomerTitle);
            this.gbxCustomer.Controls.Add(this.btnViewCustomer);
            this.gbxCustomer.Controls.Add(this.txtCustomerName);
            this.gbxCustomer.Controls.Add(this.txtCustomerTitle);
            this.gbxCustomer.Controls.Add(this.lblCustomerName);
            this.gbxCustomer.Controls.Add(this.txtCustomerPhone);
            this.gbxCustomer.Controls.Add(this.txtCustomerId);
            this.gbxCustomer.Controls.Add(this.lblCustomerAddress);
            this.gbxCustomer.Controls.Add(this.txtCustomerEmail);
            this.gbxCustomer.Controls.Add(this.lblCustomerEmail);
            this.gbxCustomer.Controls.Add(this.txtCustomerAddress);
            this.gbxCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbxCustomer.Location = new System.Drawing.Point(0, 0);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Size = new System.Drawing.Size(835, 129);
            this.gbxCustomer.TabIndex = 60;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "Customer";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.gbxOther);
            this.pnlHeader.Controls.Add(this.gbxCustomer);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 39);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(835, 234);
            this.pnlHeader.TabIndex = 62;
            // 
            // gbxOther
            // 
            this.gbxOther.Controls.Add(this.lblAgreementDate);
            this.gbxOther.Controls.Add(this.lblExtReference);
            this.gbxOther.Controls.Add(this.txtReference);
            this.gbxOther.Controls.Add(this.numCutOffDate);
            this.gbxOther.Controls.Add(this.dtpAgreementDate);
            this.gbxOther.Controls.Add(this.lblCutOffDate);
            this.gbxOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxOther.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbxOther.Location = new System.Drawing.Point(0, 129);
            this.gbxOther.Name = "gbxOther";
            this.gbxOther.Size = new System.Drawing.Size(835, 100);
            this.gbxOther.TabIndex = 63;
            this.gbxOther.TabStop = false;
            this.gbxOther.Text = "Other";
            // 
            // stpRentalAgreement
            // 
            this.stpRentalAgreement.AutoSize = false;
            this.stpRentalAgreement.BackColor = System.Drawing.Color.White;
            this.stpRentalAgreement.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stpRentalAgreement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.buttonStripItem3});
            this.stpRentalAgreement.Location = new System.Drawing.Point(0, 539);
            this.stpRentalAgreement.Name = "stpRentalAgreement";
            this.stpRentalAgreement.Size = new System.Drawing.Size(835, 31);
            this.stpRentalAgreement.TabIndex = 64;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(173, 26);
            this.toolStripStatusLabel4.Text = "Create new rental agreement";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel5.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(177, 26);
            this.toolStripStatusLabel5.Text = "F1 :  Open Customer Selection";
            this.toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(380, 26);
            this.toolStripStatusLabel6.Spring = true;
            this.toolStripStatusLabel6.Text = "F2 : Open Category Selection";
            this.toolStripStatusLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonStripItem3
            // 
            this.buttonStripItem3.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonStripItem3.Name = "buttonStripItem3";
            this.buttonStripItem3.Size = new System.Drawing.Size(70, 27);
            this.buttonStripItem3.Text = "Save";
            this.buttonStripItem3.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(173, 26);
            this.toolStripStatusLabel1.Text = "Create new rental agreement";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(177, 26);
            this.toolStripStatusLabel2.Text = "F1 :  Open Customer Selection";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(361, 26);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "F2 : Open Product Category Selection";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonStripItem1
            // 
            this.buttonStripItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonStripItem1.Name = "buttonStripItem1";
            this.buttonStripItem1.Size = new System.Drawing.Size(99, 29);
            this.buttonStripItem1.Text = "Save";
            this.buttonStripItem1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // buttonStripItem2
            // 
            this.buttonStripItem2.Name = "buttonStripItem2";
            this.buttonStripItem2.Size = new System.Drawing.Size(99, 29);
            this.buttonStripItem2.Text = "Close";
            this.buttonStripItem2.Visible = false;
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Enabled = false;
            this.dtpTransactionDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpTransactionDate.Location = new System.Drawing.Point(112, 10);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(250, 21);
            this.dtpTransactionDate.TabIndex = 4;
            this.dtpTransactionDate.TabStop = false;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTransactionDate.Location = new System.Drawing.Point(13, 13);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(93, 13);
            this.lblTransactionDate.TabIndex = 0;
            this.lblTransactionDate.Text = "Transaction Date:";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTransactionDate);
            this.pnlTop.Controls.Add(this.dtpTransactionDate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(835, 39);
            this.pnlTop.TabIndex = 61;
            // 
            // RentalAgreementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 570);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.stpRentalAgreement);
            this.MinimumSize = new System.Drawing.Size(845, 600);
            this.Name = "RentalAgreementFrm";
            this.Text = "Rental Agreement";
            this.Load += new System.EventHandler(this.RentalAgreementFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCategoryPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCutOffDate)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlAgreementDetailAction.ResumeLayout(false);
            this.gbxCustomer.ResumeLayout(false);
            this.gbxCustomer.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.gbxOther.ResumeLayout(false);
            this.gbxOther.PerformLayout();
            this.stpRentalAgreement.ResumeLayout(false);
            this.stpRentalAgreement.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerTitle;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label lblExtReference;
        private System.Windows.Forms.DateTimePicker dtpAgreementDate;
        private System.Windows.Forms.Label lblAgreementDate;
        private System.Windows.Forms.DataGridView dgvProductCategoryPrice;
        private System.Windows.Forms.ToolStripStatusLabel tssHelp;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpCustomerSelection;
        private System.Windows.Forms.Label lblCutOffDate;
        private System.Windows.Forms.NumericUpDown numCutOffDate;
        private System.Windows.Forms.Button btnRemoveLine;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpCategorySelection;
        private Controls.ButtonStripItem btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubcategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSubcategory;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRemovable;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Panel pnlAgreementDetailAction;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox gbxOther;
        private Controls.ButtonStripItem btnClose;
        private System.Windows.Forms.StatusStrip stpRentalAgreement;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private Controls.ButtonStripItem buttonStripItem1;
        private Controls.ButtonStripItem buttonStripItem2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private Controls.ButtonStripItem buttonStripItem3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.Panel pnlTop;
    }
}