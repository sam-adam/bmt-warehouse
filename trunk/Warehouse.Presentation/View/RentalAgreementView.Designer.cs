namespace Warehouse.Presentation.View
{
    partial class RentalAgreementView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.dgvRentalAgreement = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgreementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRentalAgreementDetail = new System.Windows.Forms.DataGridView();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblAddress3Value = new System.Windows.Forms.Label();
            this.lblAddress2Value = new System.Windows.Forms.Label();
            this.lblContactPersonValue = new System.Windows.Forms.Label();
            this.lblContactPersonTitle = new System.Windows.Forms.Label();
            this.lblAddress1Value = new System.Windows.Forms.Label();
            this.lblAddressTitle = new System.Windows.Forms.Label();
            this.lblJoinDateValue = new System.Windows.Forms.Label();
            this.lblJoinDateTitle = new System.Windows.Forms.Label();
            this.lblCreditLimitValue = new System.Windows.Forms.Label();
            this.lblCreditLimitTitle = new System.Windows.Forms.Label();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblTitleValue = new System.Windows.Forms.Label();
            this.lblTitleTitle = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.stpRentalAgreementList = new System.Windows.Forms.StatusStrip();
            this.tssHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHelpEnter = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalAgreement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalAgreementDetail)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.stpRentalAgreementList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cboCriteria);
            this.pnlTop.Controls.Add(this.txtKeyword);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(959, 38);
            this.pnlTop.TabIndex = 1;
            // 
            // cboCriteria
            // 
            this.cboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriteria.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboCriteria.FormattingEnabled = true;
            this.cboCriteria.Items.AddRange(new object[] {
            "RentalAgreement Id",
            "Customer",
            "Agreement Date",
            "Reference",
            "Sales"});
            this.cboCriteria.Location = new System.Drawing.Point(263, 8);
            this.cboCriteria.Name = "cboCriteria";
            this.cboCriteria.Size = new System.Drawing.Size(193, 21);
            this.cboCriteria.TabIndex = 2;
            // 
            // txtKeyword
            // 
            this.txtKeyword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKeyword.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtKeyword.Location = new System.Drawing.Point(7, 8);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(250, 21);
            this.txtKeyword.TabIndex = 1;
            // 
            // dgvRentalAgreement
            // 
            this.dgvRentalAgreement.AllowUserToAddRows = false;
            this.dgvRentalAgreement.AllowUserToDeleteRows = false;
            this.dgvRentalAgreement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRentalAgreement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalAgreement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvRentalAgreement.ColumnHeadersHeight = 25;
            this.dgvRentalAgreement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Customer,
            this.AgreementDate,
            this.Reference,
            this.Sales});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentalAgreement.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRentalAgreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentalAgreement.EnableHeadersVisualStyles = false;
            this.dgvRentalAgreement.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRentalAgreement.Location = new System.Drawing.Point(0, 38);
            this.dgvRentalAgreement.MultiSelect = false;
            this.dgvRentalAgreement.Name = "dgvRentalAgreement";
            this.dgvRentalAgreement.ReadOnly = true;
            this.dgvRentalAgreement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalAgreement.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvRentalAgreement.RowHeadersVisible = false;
            this.dgvRentalAgreement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentalAgreement.Size = new System.Drawing.Size(959, 348);
            this.dgvRentalAgreement.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.HeaderText = "RentalAgreement Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 126;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 76;
            // 
            // AgreementDate
            // 
            this.AgreementDate.HeaderText = "Agreement Date";
            this.AgreementDate.Name = "AgreementDate";
            this.AgreementDate.ReadOnly = true;
            this.AgreementDate.Width = 109;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            this.Reference.Width = 82;
            // 
            // Sales
            // 
            this.Sales.HeaderText = "Sales";
            this.Sales.Name = "Sales";
            this.Sales.ReadOnly = true;
            this.Sales.Width = 58;
            // 
            // dgvRentalAgreementDetail
            // 
            this.dgvRentalAgreementDetail.AllowUserToAddRows = false;
            this.dgvRentalAgreementDetail.AllowUserToDeleteRows = false;
            this.dgvRentalAgreementDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRentalAgreementDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRentalAgreementDetail.ColumnHeadersHeight = 25;
            this.dgvRentalAgreementDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvRentalAgreementDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRentalAgreementDetail.EnableHeadersVisualStyles = false;
            this.dgvRentalAgreementDetail.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRentalAgreementDetail.Location = new System.Drawing.Point(0, 396);
            this.dgvRentalAgreementDetail.MultiSelect = false;
            this.dgvRentalAgreementDetail.Name = "dgvRentalAgreementDetail";
            this.dgvRentalAgreementDetail.ReadOnly = true;
            this.dgvRentalAgreementDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRentalAgreementDetail.RowHeadersVisible = false;
            this.dgvRentalAgreementDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentalAgreementDetail.Size = new System.Drawing.Size(959, 151);
            this.dgvRentalAgreementDetail.TabIndex = 10;
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 386);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(959, 10);
            this.pnlSeparator.TabIndex = 7;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBottom.Controls.Add(this.lblAddress3Value);
            this.pnlBottom.Controls.Add(this.lblAddress2Value);
            this.pnlBottom.Controls.Add(this.lblContactPersonValue);
            this.pnlBottom.Controls.Add(this.lblContactPersonTitle);
            this.pnlBottom.Controls.Add(this.lblAddress1Value);
            this.pnlBottom.Controls.Add(this.lblAddressTitle);
            this.pnlBottom.Controls.Add(this.lblJoinDateValue);
            this.pnlBottom.Controls.Add(this.lblJoinDateTitle);
            this.pnlBottom.Controls.Add(this.lblCreditLimitValue);
            this.pnlBottom.Controls.Add(this.lblCreditLimitTitle);
            this.pnlBottom.Controls.Add(this.lblPhoneValue);
            this.pnlBottom.Controls.Add(this.lblPhoneTitle);
            this.pnlBottom.Controls.Add(this.lblEmailValue);
            this.pnlBottom.Controls.Add(this.lblEmailTitle);
            this.pnlBottom.Controls.Add(this.lblTitleValue);
            this.pnlBottom.Controls.Add(this.lblTitleTitle);
            this.pnlBottom.Controls.Add(this.lblCustomer);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 547);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(959, 170);
            this.pnlBottom.TabIndex = 10;
            // 
            // lblAddress3Value
            // 
            this.lblAddress3Value.AutoSize = true;
            this.lblAddress3Value.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAddress3Value.Location = new System.Drawing.Point(413, 120);
            this.lblAddress3Value.Name = "lblAddress3Value";
            this.lblAddress3Value.Size = new System.Drawing.Size(81, 13);
            this.lblAddress3Value.TabIndex = 18;
            this.lblAddress3Value.Text = "Address3 Value";
            // 
            // lblAddress2Value
            // 
            this.lblAddress2Value.AutoSize = true;
            this.lblAddress2Value.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAddress2Value.Location = new System.Drawing.Point(413, 93);
            this.lblAddress2Value.Name = "lblAddress2Value";
            this.lblAddress2Value.Size = new System.Drawing.Size(81, 13);
            this.lblAddress2Value.TabIndex = 17;
            this.lblAddress2Value.Text = "Address2 Value";
            // 
            // lblContactPersonValue
            // 
            this.lblContactPersonValue.AutoSize = true;
            this.lblContactPersonValue.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblContactPersonValue.Location = new System.Drawing.Point(96, 147);
            this.lblContactPersonValue.Name = "lblContactPersonValue";
            this.lblContactPersonValue.Size = new System.Drawing.Size(110, 13);
            this.lblContactPersonValue.TabIndex = 16;
            this.lblContactPersonValue.Text = "Contact Person Value";
            // 
            // lblContactPersonTitle
            // 
            this.lblContactPersonTitle.AutoSize = true;
            this.lblContactPersonTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblContactPersonTitle.Location = new System.Drawing.Point(4, 147);
            this.lblContactPersonTitle.Name = "lblContactPersonTitle";
            this.lblContactPersonTitle.Size = new System.Drawing.Size(85, 13);
            this.lblContactPersonTitle.TabIndex = 15;
            this.lblContactPersonTitle.Text = "Contact Person:";
            // 
            // lblAddress1Value
            // 
            this.lblAddress1Value.AutoSize = true;
            this.lblAddress1Value.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAddress1Value.Location = new System.Drawing.Point(413, 66);
            this.lblAddress1Value.Name = "lblAddress1Value";
            this.lblAddress1Value.Size = new System.Drawing.Size(81, 13);
            this.lblAddress1Value.TabIndex = 14;
            this.lblAddress1Value.Text = "Address1 Value";
            // 
            // lblAddressTitle
            // 
            this.lblAddressTitle.AutoSize = true;
            this.lblAddressTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAddressTitle.Location = new System.Drawing.Point(321, 66);
            this.lblAddressTitle.Name = "lblAddressTitle";
            this.lblAddressTitle.Size = new System.Drawing.Size(50, 13);
            this.lblAddressTitle.TabIndex = 13;
            this.lblAddressTitle.Text = "Address:";
            // 
            // lblJoinDateValue
            // 
            this.lblJoinDateValue.AutoSize = true;
            this.lblJoinDateValue.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblJoinDateValue.Location = new System.Drawing.Point(413, 39);
            this.lblJoinDateValue.Name = "lblJoinDateValue";
            this.lblJoinDateValue.Size = new System.Drawing.Size(81, 13);
            this.lblJoinDateValue.TabIndex = 12;
            this.lblJoinDateValue.Text = "Join Date Value";
            // 
            // lblJoinDateTitle
            // 
            this.lblJoinDateTitle.AutoSize = true;
            this.lblJoinDateTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblJoinDateTitle.Location = new System.Drawing.Point(321, 39);
            this.lblJoinDateTitle.Name = "lblJoinDateTitle";
            this.lblJoinDateTitle.Size = new System.Drawing.Size(56, 13);
            this.lblJoinDateTitle.TabIndex = 11;
            this.lblJoinDateTitle.Text = "Join Date:";
            // 
            // lblCreditLimitValue
            // 
            this.lblCreditLimitValue.AutoSize = true;
            this.lblCreditLimitValue.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCreditLimitValue.Location = new System.Drawing.Point(96, 120);
            this.lblCreditLimitValue.Name = "lblCreditLimitValue";
            this.lblCreditLimitValue.Size = new System.Drawing.Size(89, 13);
            this.lblCreditLimitValue.TabIndex = 10;
            this.lblCreditLimitValue.Text = "Credit Limit Value";
            // 
            // lblCreditLimitTitle
            // 
            this.lblCreditLimitTitle.AutoSize = true;
            this.lblCreditLimitTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblCreditLimitTitle.Location = new System.Drawing.Point(4, 120);
            this.lblCreditLimitTitle.Name = "lblCreditLimitTitle";
            this.lblCreditLimitTitle.Size = new System.Drawing.Size(64, 13);
            this.lblCreditLimitTitle.TabIndex = 9;
            this.lblCreditLimitTitle.Text = "Credit Limit:";
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.AutoSize = true;
            this.lblPhoneValue.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblPhoneValue.Location = new System.Drawing.Point(96, 93);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(66, 13);
            this.lblPhoneValue.TabIndex = 8;
            this.lblPhoneValue.Text = "Phone Value";
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblPhoneTitle.Location = new System.Drawing.Point(4, 93);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(41, 13);
            this.lblPhoneTitle.TabIndex = 7;
            this.lblPhoneTitle.Text = "Phone:";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblEmailValue.Location = new System.Drawing.Point(96, 66);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(60, 13);
            this.lblEmailValue.TabIndex = 4;
            this.lblEmailValue.Text = "Email Value";
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblEmailTitle.Location = new System.Drawing.Point(4, 66);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(39, 13);
            this.lblEmailTitle.TabIndex = 3;
            this.lblEmailTitle.Text = "E-Mail:";
            // 
            // lblTitleValue
            // 
            this.lblTitleValue.AutoSize = true;
            this.lblTitleValue.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTitleValue.Location = new System.Drawing.Point(96, 39);
            this.lblTitleValue.Name = "lblTitleValue";
            this.lblTitleValue.Size = new System.Drawing.Size(105, 13);
            this.lblTitleValue.TabIndex = 2;
            this.lblTitleValue.Text = "Customer Title Value";
            // 
            // lblTitleTitle
            // 
            this.lblTitleTitle.AutoSize = true;
            this.lblTitleTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTitleTitle.Location = new System.Drawing.Point(4, 39);
            this.lblTitleTitle.Name = "lblTitleTitle";
            this.lblTitleTitle.Size = new System.Drawing.Size(80, 13);
            this.lblTitleTitle.TabIndex = 1;
            this.lblTitleTitle.Text = "Customer Title:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(3, 7);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(135, 19);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "CUS001 : ABANG";
            // 
            // stpRentalAgreementList
            // 
            this.stpRentalAgreementList.AutoSize = false;
            this.stpRentalAgreementList.BackColor = System.Drawing.Color.White;
            this.stpRentalAgreementList.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stpRentalAgreementList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHelp,
            this.tssHelpEnter});
            this.stpRentalAgreementList.Location = new System.Drawing.Point(0, 717);
            this.stpRentalAgreementList.Name = "stpRentalAgreementList";
            this.stpRentalAgreementList.Size = new System.Drawing.Size(959, 31);
            this.stpRentalAgreementList.TabIndex = 11;
            // 
            // tssHelp
            // 
            this.tssHelp.BackColor = System.Drawing.Color.Transparent;
            this.tssHelp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssHelp.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelp.Name = "tssHelp";
            this.tssHelp.Size = new System.Drawing.Size(171, 26);
            this.tssHelp.Text = "View and select rental agreement";
            // 
            // tssHelpEnter
            // 
            this.tssHelpEnter.Name = "tssHelpEnter";
            this.tssHelpEnter.Size = new System.Drawing.Size(212, 26);
            this.tssHelpEnter.Text = "Press <Enter> to select Rental Agreement";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Category Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 86;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Category";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Subcategory Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 104;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Subcategory";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 92;
            // 
            // RentalAgreementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 748);
            this.Controls.Add(this.dgvRentalAgreement);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.dgvRentalAgreementDetail);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.stpRentalAgreementList);
            this.Name = "RentalAgreementView";
            this.Text = "Rental Agreement";
            this.Load += new System.EventHandler(this.RentalAgreementView_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalAgreement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalAgreementDetail)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.stpRentalAgreementList.ResumeLayout(false);
            this.stpRentalAgreementList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.DataGridView dgvRentalAgreement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgreementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales;
        private System.Windows.Forms.DataGridView dgvRentalAgreementDetail;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblAddress3Value;
        private System.Windows.Forms.Label lblAddress2Value;
        private System.Windows.Forms.Label lblContactPersonValue;
        private System.Windows.Forms.Label lblContactPersonTitle;
        private System.Windows.Forms.Label lblAddress1Value;
        private System.Windows.Forms.Label lblAddressTitle;
        private System.Windows.Forms.Label lblJoinDateValue;
        private System.Windows.Forms.Label lblJoinDateTitle;
        private System.Windows.Forms.Label lblCreditLimitValue;
        private System.Windows.Forms.Label lblCreditLimitTitle;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblPhoneTitle;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblTitleValue;
        private System.Windows.Forms.Label lblTitleTitle;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.StatusStrip stpRentalAgreementList;
        private System.Windows.Forms.ToolStripStatusLabel tssHelp;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}