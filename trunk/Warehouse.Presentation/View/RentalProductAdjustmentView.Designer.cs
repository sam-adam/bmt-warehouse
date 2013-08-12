namespace Warehouse.Presentation.View
{
    partial class RentalProductAdjustmentView
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
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.dgvRentalProductAdjustmentDetail = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdjustedStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.tssHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvRentalProductAdjustment = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdjustmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stpInvoiceMonthly = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalProductAdjustmentDetail)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalProductAdjustment)).BeginInit();
            this.stpInvoiceMonthly.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 285);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(862, 10);
            this.pnlSeparator.TabIndex = 34;
            // 
            // dgvRentalProductAdjustmentDetail
            // 
            this.dgvRentalProductAdjustmentDetail.AllowUserToAddRows = false;
            this.dgvRentalProductAdjustmentDetail.AllowUserToDeleteRows = false;
            this.dgvRentalProductAdjustmentDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRentalProductAdjustmentDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRentalProductAdjustmentDetail.ColumnHeadersHeight = 25;
            this.dgvRentalProductAdjustmentDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Brand,
            this.Description,
            this.PreviousStock,
            this.AdjustedStock});
            this.dgvRentalProductAdjustmentDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRentalProductAdjustmentDetail.EnableHeadersVisualStyles = false;
            this.dgvRentalProductAdjustmentDetail.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRentalProductAdjustmentDetail.Location = new System.Drawing.Point(0, 295);
            this.dgvRentalProductAdjustmentDetail.MultiSelect = false;
            this.dgvRentalProductAdjustmentDetail.Name = "dgvRentalProductAdjustmentDetail";
            this.dgvRentalProductAdjustmentDetail.ReadOnly = true;
            this.dgvRentalProductAdjustmentDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRentalProductAdjustmentDetail.RowHeadersVisible = false;
            this.dgvRentalProductAdjustmentDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentalProductAdjustmentDetail.Size = new System.Drawing.Size(862, 222);
            this.dgvRentalProductAdjustmentDetail.TabIndex = 35;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            this.ProductId.Width = 78;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Category Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
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
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 104;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Subcategory";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 92;
            // 
            // Brand
            // 
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
            // PreviousStock
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PreviousStock.DefaultCellStyle = dataGridViewCellStyle1;
            this.PreviousStock.HeaderText = "Previous Stock";
            this.PreviousStock.Name = "PreviousStock";
            this.PreviousStock.ReadOnly = true;
            this.PreviousStock.Width = 104;
            // 
            // AdjustedStock
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.AdjustedStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.AdjustedStock.HeaderText = "Adjusted Stock";
            this.AdjustedStock.Name = "AdjustedStock";
            this.AdjustedStock.ReadOnly = true;
            this.AdjustedStock.Width = 104;
            // 
            // cboCriteria
            // 
            this.cboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriteria.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboCriteria.FormattingEnabled = true;
            this.cboCriteria.Items.AddRange(new object[] {
            "Customer",
            "Adjustment Date",
            "Product Id",
            "Admin"});
            this.cboCriteria.Location = new System.Drawing.Point(263, 8);
            this.cboCriteria.Name = "cboCriteria";
            this.cboCriteria.Size = new System.Drawing.Size(193, 21);
            this.cboCriteria.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cboCriteria);
            this.pnlTop.Controls.Add(this.txtKeyword);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(862, 38);
            this.pnlTop.TabIndex = 32;
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
            // tssHelp
            // 
            this.tssHelp.BackColor = System.Drawing.Color.Transparent;
            this.tssHelp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssHelp.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelp.Name = "tssHelp";
            this.tssHelp.Size = new System.Drawing.Size(167, 26);
            this.tssHelp.Text = "View rental product adjusetment";
            // 
            // dgvRentalProductAdjustment
            // 
            this.dgvRentalProductAdjustment.AllowUserToAddRows = false;
            this.dgvRentalProductAdjustment.AllowUserToDeleteRows = false;
            this.dgvRentalProductAdjustment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRentalProductAdjustment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalProductAdjustment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRentalProductAdjustment.ColumnHeadersHeight = 25;
            this.dgvRentalProductAdjustment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomerId,
            this.Customer,
            this.AdjustmentDate,
            this.AdminId,
            this.Admin});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentalProductAdjustment.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRentalProductAdjustment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentalProductAdjustment.EnableHeadersVisualStyles = false;
            this.dgvRentalProductAdjustment.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRentalProductAdjustment.Location = new System.Drawing.Point(0, 38);
            this.dgvRentalProductAdjustment.MultiSelect = false;
            this.dgvRentalProductAdjustment.Name = "dgvRentalProductAdjustment";
            this.dgvRentalProductAdjustment.ReadOnly = true;
            this.dgvRentalProductAdjustment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalProductAdjustment.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRentalProductAdjustment.RowHeadersVisible = false;
            this.dgvRentalProductAdjustment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentalProductAdjustment.Size = new System.Drawing.Size(862, 479);
            this.dgvRentalProductAdjustment.TabIndex = 33;
            this.dgvRentalProductAdjustment.SelectionChanged += new System.EventHandler(this.dgvRentalProductAdjustment_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            this.CustomerId.Width = 85;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 76;
            // 
            // AdjustmentDate
            // 
            this.AdjustmentDate.HeaderText = "Adjustment Date";
            this.AdjustmentDate.Name = "AdjustmentDate";
            this.AdjustmentDate.ReadOnly = true;
            this.AdjustmentDate.Width = 110;
            // 
            // AdminId
            // 
            this.AdminId.HeaderText = "AdminId";
            this.AdminId.Name = "AdminId";
            this.AdminId.ReadOnly = true;
            this.AdminId.Visible = false;
            this.AdminId.Width = 70;
            // 
            // Admin
            // 
            this.Admin.HeaderText = "Admin";
            this.Admin.Name = "Admin";
            this.Admin.ReadOnly = true;
            this.Admin.Width = 61;
            // 
            // stpInvoiceMonthly
            // 
            this.stpInvoiceMonthly.AutoSize = false;
            this.stpInvoiceMonthly.BackColor = System.Drawing.Color.White;
            this.stpInvoiceMonthly.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stpInvoiceMonthly.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHelp});
            this.stpInvoiceMonthly.Location = new System.Drawing.Point(0, 517);
            this.stpInvoiceMonthly.Name = "stpInvoiceMonthly";
            this.stpInvoiceMonthly.Size = new System.Drawing.Size(862, 31);
            this.stpInvoiceMonthly.TabIndex = 36;
            // 
            // RentalProductAdjustmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(862, 548);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.dgvRentalProductAdjustmentDetail);
            this.Controls.Add(this.dgvRentalProductAdjustment);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.stpInvoiceMonthly);
            this.Name = "RentalProductAdjustmentView";
            this.Text = "View - Rental Product Adjustment";
            this.Load += new System.EventHandler(this.RentalProductAdjustmentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalProductAdjustmentDetail)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalProductAdjustment)).EndInit();
            this.stpInvoiceMonthly.ResumeLayout(false);
            this.stpInvoiceMonthly.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.DataGridView dgvRentalProductAdjustmentDetail;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ToolStripStatusLabel tssHelp;
        private System.Windows.Forms.DataGridView dgvRentalProductAdjustment;
        private System.Windows.Forms.StatusStrip stpInvoiceMonthly;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdjustmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdjustedStock;
    }
}
