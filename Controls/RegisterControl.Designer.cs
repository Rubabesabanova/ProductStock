
namespace ProductStock.Controls
{
    partial class RegisterControl
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
            this.gbxRegister = new System.Windows.Forms.GroupBox();
            this.txbRegisterSurname = new System.Windows.Forms.TextBox();
            this.llblRegisterLogin = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txbRegisterPassword = new System.Windows.Forms.TextBox();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.txbRegisterName = new System.Windows.Forms.TextBox();
            this.lblRegisterName = new System.Windows.Forms.Label();
            this.txbRegisterEmail = new System.Windows.Forms.TextBox();
            this.lblRegisterEmail = new System.Windows.Forms.Label();
            this.lblRegisterSurname = new System.Windows.Forms.Label();
            this.gbxRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRegister
            // 
            this.gbxRegister.Controls.Add(this.txbRegisterSurname);
            this.gbxRegister.Controls.Add(this.lblRegisterSurname);
            this.gbxRegister.Controls.Add(this.llblRegisterLogin);
            this.gbxRegister.Controls.Add(this.btnRegister);
            this.gbxRegister.Controls.Add(this.txbRegisterPassword);
            this.gbxRegister.Controls.Add(this.lblRegisterPassword);
            this.gbxRegister.Controls.Add(this.txbRegisterName);
            this.gbxRegister.Controls.Add(this.lblRegisterName);
            this.gbxRegister.Controls.Add(this.txbRegisterEmail);
            this.gbxRegister.Controls.Add(this.lblRegisterEmail);
            this.gbxRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRegister.Location = new System.Drawing.Point(25, 28);
            this.gbxRegister.Name = "gbxRegister";
            this.gbxRegister.Size = new System.Drawing.Size(291, 406);
            this.gbxRegister.TabIndex = 0;
            this.gbxRegister.TabStop = false;
            this.gbxRegister.Text = "Register";
            // 
            // txbRegisterSurname
            // 
            this.txbRegisterSurname.Location = new System.Drawing.Point(25, 208);
            this.txbRegisterSurname.Name = "txbRegisterSurname";
            this.txbRegisterSurname.Size = new System.Drawing.Size(229, 29);
            this.txbRegisterSurname.TabIndex = 11;
            // 
            // llblRegisterLogin
            // 
            this.llblRegisterLogin.AutoSize = true;
            this.llblRegisterLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblRegisterLogin.Location = new System.Drawing.Point(25, 369);
            this.llblRegisterLogin.Name = "llblRegisterLogin";
            this.llblRegisterLogin.Size = new System.Drawing.Size(234, 18);
            this.llblRegisterLogin.TabIndex = 9;
            this.llblRegisterLogin.TabStop = true;
            this.llblRegisterLogin.Text = "If you have an account, Login Now";
            this.llblRegisterLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegisterLogin_LinkClicked);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRegister.Location = new System.Drawing.Point(28, 314);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(226, 41);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txbRegisterPassword
            // 
            this.txbRegisterPassword.Location = new System.Drawing.Point(25, 273);
            this.txbRegisterPassword.Name = "txbRegisterPassword";
            this.txbRegisterPassword.Size = new System.Drawing.Size(229, 29);
            this.txbRegisterPassword.TabIndex = 7;
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterPassword.Location = new System.Drawing.Point(21, 250);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(78, 20);
            this.lblRegisterPassword.TabIndex = 6;
            this.lblRegisterPassword.Text = "Password\n";
            // 
            // txbRegisterName
            // 
            this.txbRegisterName.Location = new System.Drawing.Point(25, 137);
            this.txbRegisterName.Name = "txbRegisterName";
            this.txbRegisterName.Size = new System.Drawing.Size(229, 29);
            this.txbRegisterName.TabIndex = 5;
            // 
            // lblRegisterName
            // 
            this.lblRegisterName.AutoSize = true;
            this.lblRegisterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterName.Location = new System.Drawing.Point(24, 114);
            this.lblRegisterName.Name = "lblRegisterName";
            this.lblRegisterName.Size = new System.Drawing.Size(51, 20);
            this.lblRegisterName.TabIndex = 4;
            this.lblRegisterName.Text = "Name";
            // 
            // txbRegisterEmail
            // 
            this.txbRegisterEmail.Location = new System.Drawing.Point(25, 70);
            this.txbRegisterEmail.Name = "txbRegisterEmail";
            this.txbRegisterEmail.Size = new System.Drawing.Size(229, 29);
            this.txbRegisterEmail.TabIndex = 1;
            // 
            // lblRegisterEmail
            // 
            this.lblRegisterEmail.AutoSize = true;
            this.lblRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterEmail.Location = new System.Drawing.Point(24, 47);
            this.lblRegisterEmail.Name = "lblRegisterEmail";
            this.lblRegisterEmail.Size = new System.Drawing.Size(48, 20);
            this.lblRegisterEmail.TabIndex = 0;
            this.lblRegisterEmail.Text = "Email\r\n";
            // 
            // lblRegisterSurname
            // 
            this.lblRegisterSurname.AutoSize = true;
            this.lblRegisterSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterSurname.Location = new System.Drawing.Point(25, 180);
            this.lblRegisterSurname.Name = "lblRegisterSurname";
            this.lblRegisterSurname.Size = new System.Drawing.Size(74, 20);
            this.lblRegisterSurname.TabIndex = 10;
            this.lblRegisterSurname.Text = "Surname";
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 457);
            this.Controls.Add(this.gbxRegister);
            this.Name = "RegisterControl";
            this.Text = "Register now!";
            this.gbxRegister.ResumeLayout(false);
            this.gbxRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRegister;
        private System.Windows.Forms.Label lblRegisterEmail;
        public System.Windows.Forms.TextBox txbRegisterEmail;
        public System.Windows.Forms.TextBox txbRegisterName;
        private System.Windows.Forms.Label lblRegisterName;
        public System.Windows.Forms.TextBox txbRegisterPassword;
        private System.Windows.Forms.Label lblRegisterPassword;
        public System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel llblRegisterLogin;
        public System.Windows.Forms.TextBox txbRegisterSurname;
        private System.Windows.Forms.Label lblRegisterSurname;
    }
}