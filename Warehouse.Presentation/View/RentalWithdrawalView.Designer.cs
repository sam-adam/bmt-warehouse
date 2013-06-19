namespace Warehouse.Presentation.View
{
    partial class RentalWithdrawalView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalWithdrawalView));
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tssHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.dgvRentalAgreementDetail = new System.Windows.Forms.DataGridView();
            this.stpRentalAgreementList = new System.Windows.Forms.StatusStrip();
            this.tssHelpEnter = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvRentalWithdrawal = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WithdrawalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalAgreementDetail)).BeginInit();
            this.stpRentalAgreementList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalWithdrawal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Category";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 74;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cboCriteria);
            this.pnlTop.Controls.Add(this.txtKeyword);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(793, 38);
            this.pnlTop.TabIndex = 12;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Subcategory Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 104;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Category Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 86;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Subcategory";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 92;
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
            // pnlSeparator
            // 
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 266);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(793, 10);
            this.pnlSeparator.TabIndex = 14;
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
            this.dgvRentalAgreementDetail.Location = new System.Drawing.Point(0, 276);
            this.dgvRentalAgreementDetail.MultiSelect = false;
            this.dgvRentalAgreementDetail.Name = "dgvRentalAgreementDetail";
            this.dgvRentalAgreementDetail.ReadOnly = true;
            this.dgvRentalAgreementDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRentalAgreementDetail.RowHeadersVisible = false;
            this.dgvRentalAgreementDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentalAgreementDetail.Size = new System.Drawing.Size(793, 222);
            this.dgvRentalAgreementDetail.TabIndex = 15;
            // 
            // stpRentalAgreementList
            // 
            this.stpRentalAgreementList.AutoSize = false;
            this.stpRentalAgreementList.BackColor = System.Drawing.Color.White;
            this.stpRentalAgreementList.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stpRentalAgreementList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHelp,
            this.tssHelpEnter});
            this.stpRentalAgreementList.Location = new System.Drawing.Point(0, 498);
            this.stpRentalAgreementList.Name = "stpRentalAgreementList";
            this.stpRentalAgreementList.Size = new System.Drawing.Size(793, 31);
            this.stpRentalAgreementList.TabIndex = 16;
            // 
            // tssHelpEnter
            // 
            this.tssHelpEnter.Name = "tssHelpEnter";
            this.tssHelpEnter.Size = new System.Drawing.Size(212, 26);
            this.tssHelpEnter.Text = "Press <Enter> to select Rental Agreement";
            // 
            // dgvRentalWithdrawal
            // 
            this.dgvRentalWithdrawal.AllowUserToAddRows = false;
            this.dgvRentalWithdrawal.AllowUserToDeleteRows = false;
            this.dgvRentalWithdrawal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRentalWithdrawal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalWithdrawal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRentalWithdrawal.ColumnHeadersHeight = 25;
            this.dgvRentalWithdrawal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Customer,
            this.WithdrawalDate,
            this.Reference,
            this.Admin});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentalWithdrawal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRentalWithdrawal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentalWithdrawal.EnableHeadersVisualStyles = false;
            this.dgvRentalWithdrawal.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRentalWithdrawal.Location = new System.Drawing.Point(0, 63);
            this.dgvRentalWithdrawal.MultiSelect = false;
            this.dgvRentalWithdrawal.Name = "dgvRentalWithdrawal";
            this.dgvRentalWithdrawal.ReadOnly = true;
            this.dgvRentalWithdrawal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalWithdrawal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRentalWithdrawal.RowHeadersVisible = false;
            this.dgvRentalWithdrawal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentalWithdrawal.Size = new System.Drawing.Size(793, 203);
            this.dgvRentalWithdrawal.TabIndex = 13;
            // 
            // Id
            // 
            this.Id.HeaderText = "RentalWithdrawal Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 128;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 76;
            // 
            // WithdrawalDate
            // 
            this.WithdrawalDate.HeaderText = "Withdrawal Date";
            this.WithdrawalDate.Name = "WithdrawalDate";
            this.WithdrawalDate.ReadOnly = true;
            this.WithdrawalDate.Width = 111;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            this.Reference.Width = 82;
            // 
            // Admin
            // 
            this.Admin.HeaderText = "Admin";
            this.Admin.Name = "Admin";
            this.Admin.ReadOnly = true;
            this.Admin.Width = 61;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 38);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(793, 25);
            this.bindingNavigator1.TabIndex = 17;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 22);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // RentalWithdrawalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 529);
            this.Controls.Add(this.dgvRentalWithdrawal);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.dgvRentalAgreementDetail);
            this.Controls.Add(this.stpRentalAgreementList);
            this.Name = "RentalWithdrawalView";
            this.Text = "Rental Withdrawal View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalAgreementDetail)).EndInit();
            this.stpRentalAgreementList.ResumeLayout(false);
            this.stpRentalAgreementList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalWithdrawal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripStatusLabel tssHelp;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.DataGridView dgvRentalAgreementDetail;
        private System.Windows.Forms.StatusStrip stpRentalAgreementList;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpEnter;
        private System.Windows.Forms.DataGridView dgvRentalWithdrawal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn WithdrawalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}