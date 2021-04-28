
namespace ListQueueDatabase
{
    partial class AdminLogin
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
            this.labelAdminLogin = new System.Windows.Forms.Label();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.labelAdminUsername = new System.Windows.Forms.Label();
            this.labelAdminPassword = new System.Windows.Forms.Label();
            this.tbAdminUsername = new System.Windows.Forms.TextBox();
            this.tbAdminPassword = new System.Windows.Forms.TextBox();
            this.labelGoToRegister = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdminLogin
            // 
            this.labelAdminLogin.AutoSize = true;
            this.labelAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminLogin.Location = new System.Drawing.Point(12, 9);
            this.labelAdminLogin.Name = "labelAdminLogin";
            this.labelAdminLogin.Size = new System.Drawing.Size(240, 37);
            this.labelAdminLogin.TabIndex = 0;
            this.labelAdminLogin.Text = "ADMIN LOGIN";
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.Location = new System.Drawing.Point(70, 164);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(309, 43);
            this.btnAdminLogin.TabIndex = 1;
            this.btnAdminLogin.Text = "LOGIN";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // labelAdminUsername
            // 
            this.labelAdminUsername.AutoSize = true;
            this.labelAdminUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminUsername.Location = new System.Drawing.Point(67, 90);
            this.labelAdminUsername.Name = "labelAdminUsername";
            this.labelAdminUsername.Size = new System.Drawing.Size(77, 18);
            this.labelAdminUsername.TabIndex = 2;
            this.labelAdminUsername.Text = "Username";
            // 
            // labelAdminPassword
            // 
            this.labelAdminPassword.AutoSize = true;
            this.labelAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminPassword.Location = new System.Drawing.Point(67, 123);
            this.labelAdminPassword.Name = "labelAdminPassword";
            this.labelAdminPassword.Size = new System.Drawing.Size(75, 18);
            this.labelAdminPassword.TabIndex = 3;
            this.labelAdminPassword.Text = "Password";
            // 
            // tbAdminUsername
            // 
            this.tbAdminUsername.Location = new System.Drawing.Point(172, 90);
            this.tbAdminUsername.Name = "tbAdminUsername";
            this.tbAdminUsername.Size = new System.Drawing.Size(208, 20);
            this.tbAdminUsername.TabIndex = 4;
            // 
            // tbAdminPassword
            // 
            this.tbAdminPassword.Location = new System.Drawing.Point(171, 124);
            this.tbAdminPassword.Name = "tbAdminPassword";
            this.tbAdminPassword.Size = new System.Drawing.Size(208, 20);
            this.tbAdminPassword.TabIndex = 5;
            this.tbAdminPassword.UseSystemPasswordChar = true;
            // 
            // labelGoToRegister
            // 
            this.labelGoToRegister.AutoSize = true;
            this.labelGoToRegister.ForeColor = System.Drawing.Color.Black;
            this.labelGoToRegister.Location = new System.Drawing.Point(131, 240);
            this.labelGoToRegister.Name = "labelGoToRegister";
            this.labelGoToRegister.Size = new System.Drawing.Size(189, 13);
            this.labelGoToRegister.TabIndex = 6;
            this.labelGoToRegister.Text = "Don\'t have an Account? Register here";
            this.labelGoToRegister.Click += new System.EventHandler(this.labelGoToRegister_Click);
            this.labelGoToRegister.Enter += new System.EventHandler(this.labelGoToRegister_Enter);
            this.labelGoToRegister.Leave += new System.EventHandler(this.labelGoToRegister_Leave);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(388, 277);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 312);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.labelGoToRegister);
            this.Controls.Add(this.tbAdminPassword);
            this.Controls.Add(this.tbAdminUsername);
            this.Controls.Add(this.labelAdminPassword);
            this.Controls.Add(this.labelAdminUsername);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.labelAdminLogin);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdminLogin;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Label labelAdminUsername;
        private System.Windows.Forms.Label labelAdminPassword;
        private System.Windows.Forms.TextBox tbAdminUsername;
        private System.Windows.Forms.TextBox tbAdminPassword;
        private System.Windows.Forms.Label labelGoToRegister;
        private System.Windows.Forms.Button btn_Back;
    }
}