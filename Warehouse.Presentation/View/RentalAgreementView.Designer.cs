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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.stpRentalAgreementList = new System.Windows.Forms.StatusStrip();
            this.tssHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHelpEnter = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalAgreement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalAgreementDetail)).BeginInit();
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
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // dgvRentalAgreement
            // 
            this.dgvRentalAgreement.AllowUserToAddRows = false;
            this.dgvRentalAgreement.AllowUserToDeleteRows = false;
            this.dgvRentalAgreement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRentalAgreement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalAgreement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRentalAgreement.ColumnHeadersHeight = 25;
            this.dgvRentalAgreement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Customer,
            this.AgreementDate,
            this.Reference,
            this.Sales});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentalAgreement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRentalAgreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentalAgreement.EnableHeadersVisualStyles = false;
            this.dgvRentalAgreement.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRentalAgreement.Location = new System.Drawing.Point(0, 38);
            this.dgvRentalAgreement.MultiSelect = false;
            this.dgvRentalAgreement.Name = "dgvRentalAgreement";
            this.dgvRentalAgreement.ReadOnly = true;
            this.dgvRentalAgreement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalAgreement.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRentalAgreement.RowHeadersVisible = false;
            this.dgvRentalAgreement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentalAgreement.Size = new System.Drawing.Size(959, 269);
            this.dgvRentalAgreement.TabIndex = 5;
            this.dgvRentalAgreement.SelectionChanged += new System.EventHandler(this.dgvRentalAgreement_SelectionChanged);
            this.dgvRentalAgreement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRentalAgreement_KeyDown);
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
            this.dgvRentalAgreementDetail.Location = new System.Drawing.Point(0, 317);
            this.dgvRentalAgreementDetail.MultiSelect = false;
            this.dgvRentalAgreementDetail.Name = "dgvRentalAgreementDetail";
            this.dgvRentalAgreementDetail.ReadOnly = true;
            this.dgvRentalAgreementDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRentalAgreementDetail.RowHeadersVisible = false;
            this.dgvRentalAgreementDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentalAgreementDetail.Size = new System.Drawing.Size(959, 222);
            this.dgvRentalAgreementDetail.TabIndex = 10;
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
            // pnlSeparator
            // 
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 307);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(959, 10);
            this.pnlSeparator.TabIndex = 7;
            // 
            // stpRentalAgreementList
            // 
            this.stpRentalAgreementList.AutoSize = false;
            this.stpRentalAgreementList.BackColor = System.Drawing.Color.White;
            this.stpRentalAgreementList.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stpRentalAgreementList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHelp,
            this.tssHelpEnter});
            this.stpRentalAgreementList.Location = new System.Drawing.Point(0, 539);
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
            // RentalAgreementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 570);
            this.Controls.Add(this.dgvRentalAgreement);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.dgvRentalAgreementDetail);
            this.Controls.Add(this.stpRentalAgreementList);
            this.Name = "RentalAgreementView";
            this.Text = "Rental Agreement";
            this.Load += new System.EventHandler(this.RentalAgreementView_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalAgreement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalAgreementDetail)).EndInit();
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
        private System.Windows.Forms.StatusStrip stpRentalAgreementList;
        private System.Windows.Forms.ToolStripStatusLabel tssHelp;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}