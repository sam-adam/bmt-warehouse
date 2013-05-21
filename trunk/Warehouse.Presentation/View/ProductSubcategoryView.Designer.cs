namespace Warehouse.Presentation.View
{
    partial class ProductSubcategoryView
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
            this.stpProductSubcategoryList = new System.Windows.Forms.StatusStrip();
            this.tssHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHelpEnter = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvProductSubcategory = new System.Windows.Forms.DataGridView();
            this.SubcategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.stpProductSubcategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSubcategory)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // stpProductSubcategoryList
            // 
            this.stpProductSubcategoryList.AutoSize = false;
            this.stpProductSubcategoryList.BackColor = System.Drawing.Color.White;
            this.stpProductSubcategoryList.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stpProductSubcategoryList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHelp,
            this.tssHelpEnter});
            this.stpProductSubcategoryList.Location = new System.Drawing.Point(0, 237);
            this.stpProductSubcategoryList.Name = "stpProductSubcategoryList";
            this.stpProductSubcategoryList.Size = new System.Drawing.Size(603, 31);
            this.stpProductSubcategoryList.TabIndex = 10;
            // 
            // tssHelp
            // 
            this.tssHelp.BackColor = System.Drawing.Color.Transparent;
            this.tssHelp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssHelp.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tssHelp.Name = "tssHelp";
            this.tssHelp.Size = new System.Drawing.Size(188, 26);
            this.tssHelp.Text = "View and select product subcategory";
            // 
            // tssHelpEnter
            // 
            this.tssHelpEnter.Name = "tssHelpEnter";
            this.tssHelpEnter.Size = new System.Drawing.Size(186, 26);
            this.tssHelpEnter.Text = "Press <Enter> to select Subcategory";
            // 
            // dgvProductSubcategory
            // 
            this.dgvProductSubcategory.AllowUserToAddRows = false;
            this.dgvProductSubcategory.AllowUserToDeleteRows = false;
            this.dgvProductSubcategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductSubcategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductSubcategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductSubcategory.ColumnHeadersHeight = 25;
            this.dgvProductSubcategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubcategoryId,
            this.Subcategory,
            this.CategoryId,
            this.Category});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductSubcategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductSubcategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductSubcategory.EnableHeadersVisualStyles = false;
            this.dgvProductSubcategory.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductSubcategory.Location = new System.Drawing.Point(0, 38);
            this.dgvProductSubcategory.MultiSelect = false;
            this.dgvProductSubcategory.Name = "dgvProductSubcategory";
            this.dgvProductSubcategory.ReadOnly = true;
            this.dgvProductSubcategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductSubcategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductSubcategory.RowHeadersVisible = false;
            this.dgvProductSubcategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductSubcategory.Size = new System.Drawing.Size(603, 199);
            this.dgvProductSubcategory.TabIndex = 11;
            this.dgvProductSubcategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductSubcategory_CellDoubleClick);
            this.dgvProductSubcategory.SelectionChanged += new System.EventHandler(this.dgvProductSubcategory_SelectionChanged);
            // 
            // SubcategoryId
            // 
            this.SubcategoryId.HeaderText = "Subcategory Id";
            this.SubcategoryId.Name = "SubcategoryId";
            this.SubcategoryId.ReadOnly = true;
            this.SubcategoryId.Width = 104;
            // 
            // Subcategory
            // 
            this.Subcategory.HeaderText = "Subcategory";
            this.Subcategory.Name = "Subcategory";
            this.Subcategory.ReadOnly = true;
            this.Subcategory.Width = 92;
            // 
            // CategoryId
            // 
            this.CategoryId.HeaderText = "Category Id";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Width = 86;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 74;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cboCriteria);
            this.pnlTop.Controls.Add(this.txtKeyword);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(603, 38);
            this.pnlTop.TabIndex = 12;
            // 
            // cboCriteria
            // 
            this.cboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriteria.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cboCriteria.FormattingEnabled = true;
            this.cboCriteria.Items.AddRange(new object[] {
            "Subcategory Id",
            "Subcategory",
            "Category Id",
            "Category"});
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
            // ProductSubcategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 268);
            this.Controls.Add(this.dgvProductSubcategory);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.stpProductSubcategoryList);
            this.Name = "ProductSubcategoryView";
            this.Text = "Product Subcategory";
            this.Load += new System.EventHandler(this.ProductSubcategoryView_Load);
            this.stpProductSubcategoryList.ResumeLayout(false);
            this.stpProductSubcategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSubcategory)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip stpProductSubcategoryList;
        private System.Windows.Forms.ToolStripStatusLabel tssHelp;
        private System.Windows.Forms.ToolStripStatusLabel tssHelpEnter;
        private System.Windows.Forms.DataGridView dgvProductSubcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubcategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.TextBox txtKeyword;
    }
}