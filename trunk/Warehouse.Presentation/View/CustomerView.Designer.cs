namespace Warehouse.Presentation.View
{
    partial class CustomerView
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNPWP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblActiveRentalValue = new System.Windows.Forms.Label();
            this.lblActiveRentalTitle = new System.Windows.Forms.Label();
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
            this.stpCustomerList = new System.Windows.Forms.StatusStrip();
            this.tssHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHelpEnter = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.stpCustomerList.SuspendLayout();
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
            this.pnlTop.TabIndex = 0;
            // 
            // cboCriteria
            // 
            this.cboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriteria.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboCriteria.FormattingEnabled = true;
            this.cboCriteria.Items.AddRange(new object[] {
            "Name",
            "Title",
            "Phone",
            "Email",
            "NPWP"});
            this.cboCriteria.Location = new System.Drawing.Point(263, 8);
            this.cboCriteria.Name = "cboCriteria";
            this.cboCriteria.Size = new System.Drawing.Size(121, 21);
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
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.ColumnHeadersHeight = 25;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomerName,
            this.CustomerTitle,
            this.CustomerPhone,
            this.CustomerEmail,
            this.CustomerNPWP});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 38);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(959, 288);
            this.dgvCustomers.TabIndex = 4;
            this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.dgvCustomers_SelectionChanged);
            this.dgvCustomers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCustomers_KeyDown);
            this.dgvCustomers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCustomers_KeyPress);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 39;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 60;
            // 
            // CustomerTitle
            // 
            this.CustomerTitle.HeaderText = "Title";
            this.CustomerTitle.Name = "CustomerTitle";
            this.CustomerTitle.ReadOnly = true;
            this.CustomerTitle.Width = 52;
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.HeaderText = "Phone";
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.ReadOnly = true;
            this.CustomerPhone.Width = 63;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.HeaderText = "Email";
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.ReadOnly = true;
            this.CustomerEmail.Width = 57;
            // 
            // CustomerNPWP
            // 
            this.CustomerNPWP.HeaderText = "NPWP";
            this.CustomerNPWP.Name = "CustomerNPWP";
            this.CustomerNPWP.ReadOnly = true;
            this.CustomerNPWP.Width = 65;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBottom.Controls.Add(this.lblActiveRentalValue);
            this.pnlBottom.Controls.Add(this.lblActiveRentalTitle);
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
            this.pnlBottom.Location = new System.Drawing.Point(0, 326);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(959, 170);
            this.pnlBottom.TabIndex = 8;
            // 
            // lblActiveRentalValue
            // 
            this.lblActiveRentalValue.AutoSize = true;
            this.lblActiveRentalValue.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblActiveRentalValue.Location = new System.Drawing.Point(458, 147);
            this.lblActiveRentalValue.Name = "lblActiveRentalValue";
            this.lblActiveRentalValue.Size = new System.Drawing.Size(100, 13);
            this.lblActiveRentalValue.TabIndex = 20;
            this.lblActiveRentalValue.Text = "Active Rental Value";
            // 
            // lblActiveRentalTitle
            // 
            this.lblActiveRentalTitle.AutoSize = true;
            this.lblActiveRentalTitle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblActiveRentalTitle.Location = new System.Drawing.Point(321, 147);
            this.lblActiveRentalTitle.Name = "lblActiveRentalTitle";
            this.lblActiveRentalTitle.Size = new System.Drawing.Size(131, 13);
            this.lblActiveRentalTitle.TabIndex = 19;
            this.lblActiveRentalTitle.Text = "Active Rental Agreement:";
            // 
            // lblAddress3Value
            // 
            this.lblAddress3Value.AutoSize = true;
            this.lblAddress3Value.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAddress3Value.Location = new System.Drawing.Point(458, 120);
            this.lblAddress3Value.Name = "lblAddress3Value";
            this.lblAddress3Value.Size = new System.Drawing.Size(81, 13);
            this.lblAddress3Value.TabIndex = 18;
            this.lblAddress3Value.Text = "Address3 Value";
            // 
            // lblAddress2Value
            // 
            this.lblAddress2Value.AutoSize = true;
            this.lblAddress2Value.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblAddress2Value.Location = new System.Drawing.Point(458, 93);
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
            this.lblAddress1Value.Location = new System.Drawing.Point(458, 66);
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
            this.lblJoinDateValue.Location = new System.Drawing.Point(458, 39);
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
            // stpCustomerList
            // 
            this.stpCustomerList.AutoSize = false;
            this.stpCustomerList.BackColor = System.Drawing.Color.White;
            this.stpCustomerList.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stpCustomerList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHelp,
            this.tssHelpEnter});
            this.stpCustomerList.Location = new System.Drawing.Point(0, 496);
            this.stpCustomerList.Name = "stpCustomerList";
            this.stpCustomerList.Size = new System.Drawing.Size(959, 31);
            this.stpCustomerList.TabIndex = 9;
            // 
            // tssHelp
            // 
            this.tssHelp.BackColor = System.Drawing.Color.Transparent;
            this.tssHelp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssHelp.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelp.Name = "tssHelp";
            this.tssHelp.Size = new System.Drawing.Size(132, 26);
            this.tssHelp.Text = "View and select customer";
            // 
            // tssHelpEnter
            // 
            this.tssHelpEnter.Name = "tssHelpEnter";
            this.tssHelpEnter.Size = new System.Drawing.Size(171, 26);
            this.tssHelpEnter.Text = "Press <Enter> to select Customer";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 527);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.stpCustomerList);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 504);
            this.Name = "CustomerView";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.stpCustomerList.ResumeLayout(false);
            this.stpCustomerList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.StatusStrip stpCustomerList;
        private System.Windows.Forms.ToolStripStatusLabel tssHelp;
        private System.Windows.Forms.Label lblTitleTitle;
        private System.Windows.Forms.Label lblCustomer;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNPWP;
        private System.Windows.Forms.Label lblAddress3Value;
        private System.Windows.Forms.Label lblAddress2Value;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpEnter;
        private System.Windows.Forms.Label lblActiveRentalValue;
        private System.Windows.Forms.Label lblActiveRentalTitle;
    }
}