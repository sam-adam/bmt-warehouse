namespace Warehouse.Presentation
{
    partial class LoginFrm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabLogin = new System.Windows.Forms.TabControl();
            this.tpgLogin = new System.Windows.Forms.TabPage();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.tabLogin.SuspendLayout();
            this.tpgLogin.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(6, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(66, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(6, 74);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(9, 40);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(9, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(250, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(189, 132);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(70, 25);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.tpgLogin);
            this.tabLogin.Controls.Add(this.tabConnection);
            this.tabLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLogin.Location = new System.Drawing.Point(0, 0);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.SelectedIndex = 0;
            this.tabLogin.Size = new System.Drawing.Size(287, 199);
            this.tabLogin.TabIndex = 4;
            // 
            // tpgLogin
            // 
            this.tpgLogin.Controls.Add(this.lblUsername);
            this.tpgLogin.Controls.Add(this.btnLogin);
            this.tpgLogin.Controls.Add(this.lblPassword);
            this.tpgLogin.Controls.Add(this.txtPassword);
            this.tpgLogin.Controls.Add(this.txtUsername);
            this.tpgLogin.Location = new System.Drawing.Point(4, 22);
            this.tpgLogin.Name = "tpgLogin";
            this.tpgLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpgLogin.Size = new System.Drawing.Size(279, 173);
            this.tpgLogin.TabIndex = 0;
            this.tpgLogin.Text = "Login";
            this.tpgLogin.UseVisualStyleBackColor = true;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.btnSave);
            this.tabConnection.Controls.Add(this.btnTest);
            this.tabConnection.Controls.Add(this.label1);
            this.tabConnection.Controls.Add(this.textBox1);
            this.tabConnection.Controls.Add(this.lblUserId);
            this.tabConnection.Controls.Add(this.txtUserId);
            this.tabConnection.Controls.Add(this.lblDatabase);
            this.tabConnection.Controls.Add(this.txtDatabase);
            this.tabConnection.Controls.Add(this.lblServer);
            this.tabConnection.Controls.Add(this.txtServer);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Size = new System.Drawing.Size(279, 173);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Connection Setting";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(201, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 25);
            this.btnSave.TabIndex = 96;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(125, 140);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(70, 25);
            this.btnTest.TabIndex = 95;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(8, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(73, 104);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 21);
            this.textBox1.TabIndex = 93;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblUserId.Location = new System.Drawing.Point(8, 80);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(46, 13);
            this.lblUserId.TabIndex = 92;
            this.lblUserId.Text = "User Id:";
            // 
            // txtUserId
            // 
            this.txtUserId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUserId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUserId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserId.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtUserId.Location = new System.Drawing.Point(73, 77);
            this.txtUserId.MaxLength = 6;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(198, 21);
            this.txtUserId.TabIndex = 91;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblDatabase.Location = new System.Drawing.Point(8, 53);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(57, 13);
            this.lblDatabase.TabIndex = 90;
            this.lblDatabase.Text = "Database:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDatabase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDatabase.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDatabase.Location = new System.Drawing.Point(73, 50);
            this.txtDatabase.MaxLength = 6;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(198, 21);
            this.txtDatabase.TabIndex = 89;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblServer.Location = new System.Drawing.Point(8, 26);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(43, 13);
            this.lblServer.TabIndex = 88;
            this.lblServer.Text = "Server:";
            // 
            // txtServer
            // 
            this.txtServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtServer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServer.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtServer.Location = new System.Drawing.Point(73, 18);
            this.txtServer.MaxLength = 6;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(198, 21);
            this.txtServer.TabIndex = 87;
            // 
            // LoginFrm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 199);
            this.Controls.Add(this.tabLogin);
            this.Name = "LoginFrm";
            this.Text = "Login";
            this.tabLogin.ResumeLayout(false);
            this.tpgLogin.ResumeLayout(false);
            this.tpgLogin.PerformLayout();
            this.tabConnection.ResumeLayout(false);
            this.tabConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabControl tabLogin;
        private System.Windows.Forms.TabPage tpgLogin;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
    }
}