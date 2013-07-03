namespace Warehouse.Presentation.View
{
    partial class MutationViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.dgvRentalProduct = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerTitle = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.pnlSeparatorTop = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.stpMutationView = new System.Windows.Forms.StatusStrip();
            this.tssHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.dgvMutation = new System.Windows.Forms.DataGridView();
            this.MutationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MutationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tssHelpCustomerSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClose = new Warehouse.Presentation.Controls.ButtonStripItem();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalProduct)).BeginInit();
            this.gbxCustomer.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.stpMutationView.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMutation)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.dgvRentalProduct);
            this.pnlHeader.Controls.Add(this.gbxCustomer);
            this.pnlHeader.Controls.Add(this.pnlSeparatorTop);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 39);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(835, 306);
            this.pnlHeader.TabIndex = 67;
            // 
            // dgvRentalProduct
            // 
            this.dgvRentalProduct.AllowUserToAddRows = false;
            this.dgvRentalProduct.AllowUserToDeleteRows = false;
            this.dgvRentalProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRentalProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvRentalProduct.ColumnHeadersHeight = 25;
            this.dgvRentalProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Brand,
            this.Description,
            this.Stock});
            this.dgvRentalProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentalProduct.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRentalProduct.Location = new System.Drawing.Point(0, 129);
            this.dgvRentalProduct.Name = "dgvRentalProduct";
            this.dgvRentalProduct.ReadOnly = true;
            this.dgvRentalProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRentalProduct.RowHeadersVisible = false;
            this.dgvRentalProduct.Size = new System.Drawing.Size(835, 167);
            this.dgvRentalProduct.TabIndex = 61;
            this.dgvRentalProduct.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentalProduct_RowEnter);
            // 
            // ProductId
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProductId.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            this.ProductId.Width = 76;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Category Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 84;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Category";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 72;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.HeaderText = "Subcategory Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 102;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "Subcategory";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // Brand
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Brand.DefaultCellStyle = dataGridViewCellStyle6;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 58;
            // 
            // Description
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Description.DefaultCellStyle = dataGridViewCellStyle7;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 83;
            // 
            // Stock
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Stock.DefaultCellStyle = dataGridViewCellStyle8;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 58;
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
            // pnlSeparatorTop
            // 
            this.pnlSeparatorTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparatorTop.Location = new System.Drawing.Point(0, 296);
            this.pnlSeparatorTop.Name = "pnlSeparatorTop";
            this.pnlSeparatorTop.Size = new System.Drawing.Size(835, 10);
            this.pnlSeparatorTop.TabIndex = 62;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTransactionDate);
            this.pnlTop.Controls.Add(this.dtpTransactionDate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(835, 39);
            this.pnlTop.TabIndex = 68;
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
            // stpMutationView
            // 
            this.stpMutationView.AutoSize = false;
            this.stpMutationView.BackColor = System.Drawing.Color.White;
            this.stpMutationView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stpMutationView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHelp,
            this.tssHelpCustomerSelection,
            this.btnClose});
            this.stpMutationView.Location = new System.Drawing.Point(0, 537);
            this.stpMutationView.Name = "stpMutationView";
            this.stpMutationView.Size = new System.Drawing.Size(835, 31);
            this.stpMutationView.TabIndex = 69;
            // 
            // tssHelp
            // 
            this.tssHelp.BackColor = System.Drawing.Color.Transparent;
            this.tssHelp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssHelp.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelp.Name = "tssHelp";
            this.tssHelp.Padding = new System.Windows.Forms.Padding(10);
            this.tssHelp.Size = new System.Drawing.Size(172, 26);
            this.tssHelp.Text = "View Rental Product Mutation";
            this.tssHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.dgvMutation);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 345);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(835, 192);
            this.pnlDetail.TabIndex = 70;
            // 
            // dgvMutation
            // 
            this.dgvMutation.AllowUserToAddRows = false;
            this.dgvMutation.AllowUserToDeleteRows = false;
            this.dgvMutation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMutation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvMutation.ColumnHeadersHeight = 25;
            this.dgvMutation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MutationType,
            this.Reference,
            this.MutationDate,
            this.Quantity});
            this.dgvMutation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMutation.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMutation.Location = new System.Drawing.Point(0, 0);
            this.dgvMutation.Name = "dgvMutation";
            this.dgvMutation.ReadOnly = true;
            this.dgvMutation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMutation.RowHeadersVisible = false;
            this.dgvMutation.Size = new System.Drawing.Size(835, 192);
            this.dgvMutation.TabIndex = 7;
            // 
            // MutationType
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.MutationType.DefaultCellStyle = dataGridViewCellStyle9;
            this.MutationType.HeaderText = "Mutation Type";
            this.MutationType.Name = "MutationType";
            this.MutationType.ReadOnly = true;
            this.MutationType.Width = 98;
            // 
            // Reference
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Reference.DefaultCellStyle = dataGridViewCellStyle10;
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            this.Reference.Width = 80;
            // 
            // MutationDate
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MutationDate.DefaultCellStyle = dataGridViewCellStyle11;
            this.MutationDate.HeaderText = "Mutation Date";
            this.MutationDate.Name = "MutationDate";
            this.MutationDate.ReadOnly = true;
            this.MutationDate.Width = 97;
            // 
            // Quantity
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle12;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 69;
            // 
            // tssHelpCustomerSelection
            // 
            this.tssHelpCustomerSelection.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssHelpCustomerSelection.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelpCustomerSelection.Name = "tssHelpCustomerSelection";
            this.tssHelpCustomerSelection.Padding = new System.Windows.Forms.Padding(10);
            this.tssHelpCustomerSelection.Size = new System.Drawing.Size(518, 26);
            this.tssHelpCustomerSelection.Spring = true;
            this.tssHelpCustomerSelection.Text = "F1 :  Open Customer Selection";
            this.tssHelpCustomerSelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 29);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MutationViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(835, 568);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.stpMutationView);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlTop);
            this.Name = "MutationViewForm";
            this.Text = "Mutation View";
            this.Load += new System.EventHandler(this.MutationViewForm_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalProduct)).EndInit();
            this.gbxCustomer.ResumeLayout(false);
            this.gbxCustomer.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.stpMutationView.ResumeLayout(false);
            this.stpMutationView.PerformLayout();
            this.pnlDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMutation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerTitle;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.StatusStrip stpMutationView;
        private System.Windows.Forms.ToolStripStatusLabel tssHelp;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.DataGridView dgvMutation;
        private System.Windows.Forms.DataGridView dgvRentalProduct;
        private System.Windows.Forms.Panel pnlSeparatorTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn MutationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn MutationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpCustomerSelection;
        private Controls.ButtonStripItem btnClose;

    }
}
