﻿namespace Warehouse.Presentation
{
    partial class HomeInvoice
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rentalAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceWithdrawalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceMonthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.vIewToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentalAgreementToolStripMenuItem,
            this.invoiceWithdrawalToolStripMenuItem,
            this.invoiceMonthlyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rentalAgreementToolStripMenuItem
            // 
            this.rentalAgreementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.rentalAgreementToolStripMenuItem.Name = "rentalAgreementToolStripMenuItem";
            this.rentalAgreementToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.rentalAgreementToolStripMenuItem.Text = "Rental Agreement";
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createNewToolStripMenuItem.Text = "Create New";
            this.createNewToolStripMenuItem.Click += new System.EventHandler(this.createNewToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // invoiceWithdrawalToolStripMenuItem
            // 
            this.invoiceWithdrawalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.viewToolStripMenuItem3});
            this.invoiceWithdrawalToolStripMenuItem.Name = "invoiceWithdrawalToolStripMenuItem";
            this.invoiceWithdrawalToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.invoiceWithdrawalToolStripMenuItem.Text = "Invoice Withdrawal";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem3
            // 
            this.viewToolStripMenuItem3.Name = "viewToolStripMenuItem3";
            this.viewToolStripMenuItem3.Size = new System.Drawing.Size(99, 22);
            this.viewToolStripMenuItem3.Text = "View";
            this.viewToolStripMenuItem3.Click += new System.EventHandler(this.viewToolStripMenuItem3_Click);
            // 
            // invoiceMonthlyToolStripMenuItem
            // 
            this.invoiceMonthlyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem3,
            this.vIewToolStripMenuItem4});
            this.invoiceMonthlyToolStripMenuItem.Name = "invoiceMonthlyToolStripMenuItem";
            this.invoiceMonthlyToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.invoiceMonthlyToolStripMenuItem.Text = "Invoice Monthly";
            // 
            // createNewToolStripMenuItem3
            // 
            this.createNewToolStripMenuItem3.Name = "createNewToolStripMenuItem3";
            this.createNewToolStripMenuItem3.Size = new System.Drawing.Size(135, 22);
            this.createNewToolStripMenuItem3.Text = "Create New";
            this.createNewToolStripMenuItem3.Click += new System.EventHandler(this.createNewToolStripMenuItem3_Click);
            // 
            // vIewToolStripMenuItem4
            // 
            this.vIewToolStripMenuItem4.Name = "vIewToolStripMenuItem4";
            this.vIewToolStripMenuItem4.Size = new System.Drawing.Size(135, 22);
            this.vIewToolStripMenuItem4.Text = "View";
            this.vIewToolStripMenuItem4.Click += new System.EventHandler(this.vIewToolStripMenuItem4_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 736);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rentalAgreementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceWithdrawalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem invoiceMonthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem vIewToolStripMenuItem4;


    }
}