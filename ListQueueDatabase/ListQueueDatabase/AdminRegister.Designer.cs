
namespace ListQueueDatabase
{
    partial class AdminRegister
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
            this.labelAdminRegister = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnAdminRegister = new System.Windows.Forms.Button();
            this.labelGoToLogin = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdminRegister
            // 
            this.labelAdminRegister.AutoSize = true;
            this.labelAdminRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminRegister.Location = new System.Drawing.Point(12, 9);
            this.labelAdminRegister.Name = "labelAdminRegister";
            this.labelAdminRegister.Size = new System.Drawing.Size(303, 37);
            this.labelAdminRegister.TabIndex = 1;
            this.labelAdminRegister.Text = "ADMIN REGISTER";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.ForeColor = System.Drawing.Color.Gray;
            this.tbLastName.Location = new System.Drawing.Point(289, 53);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(216, 44);
            this.tbLastName.TabIndex = 4;
            this.tbLastName.Text = "last name";
            this.tbLastName.Enter += new System.EventHandler(this.tbLastName_Enter);
            this.tbLastName.Leave += new System.EventHandler(this.tbLastName_Leave);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.Color.Gray;
            this.tbFirstName.Location = new System.Drawing.Point(67, 53);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(216, 44);
            this.tbFirstName.TabIndex = 200;
            this.tbFirstName.Text = "first name";
            this.tbFirstName.Enter += new System.EventHandler(this.tbFirstName_Enter);
            this.tbFirstName.Leave += new System.EventHandler(this.tbFirstName_Leave);
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailAddress.ForeColor = System.Drawing.Color.Gray;
            this.tbEmailAddress.Location = new System.Drawing.Point(67, 103);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(438, 44);
            this.tbEmailAddress.TabIndex = 4;
            this.tbEmailAddress.Text = "email address";
            this.tbEmailAddress.Enter += new System.EventHandler(this.tbEmailAddress_Enter);
            this.tbEmailAddress.Leave += new System.EventHandler(this.tbEmailAddress_Leave);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.Gray;
            this.tbUsername.Location = new System.Drawing.Point(67, 153);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(438, 44);
            this.tbUsername.TabIndex = 5;
            this.tbUsername.Text = "username";
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Gray;
            this.tbPassword.Location = new System.Drawing.Point(67, 203);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(438, 44);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.Text = "password";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.tbConfirmPassword.Location = new System.Drawing.Point(67, 253);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(438, 44);
            this.tbConfirmPassword.TabIndex = 7;
            this.tbConfirmPassword.Text = "confirm password";
            this.tbConfirmPassword.Enter += new System.EventHandler(this.tbConfirmPassword_Enter);
            this.tbConfirmPassword.Leave += new System.EventHandler(this.tbConfirmPassword_Leave);
            // 
            // btnAdminRegister
            // 
            this.btnAdminRegister.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminRegister.Location = new System.Drawing.Point(67, 303);
            this.btnAdminRegister.Name = "btnAdminRegister";
            this.btnAdminRegister.Size = new System.Drawing.Size(438, 43);
            this.btnAdminRegister.TabIndex = 8;
            this.btnAdminRegister.Text = "REGISTER";
            this.btnAdminRegister.UseVisualStyleBackColor = true;
            this.btnAdminRegister.Click += new System.EventHandler(this.btnAdminRegister_Click);
            // 
            // labelGoToLogin
            // 
            this.labelGoToLogin.AutoSize = true;
            this.labelGoToLogin.ForeColor = System.Drawing.Color.Black;
            this.labelGoToLogin.Location = new System.Drawing.Point(191, 382);
            this.labelGoToLogin.Name = "labelGoToLogin";
            this.labelGoToLogin.Size = new System.Drawing.Size(186, 13);
            this.labelGoToLogin.TabIndex = 201;
            this.labelGoToLogin.Text = "Already have an Account? Login here";
            this.labelGoToLogin.Click += new System.EventHandler(this.labelGoToLogin_Click);
            this.labelGoToLogin.Enter += new System.EventHandler(this.labelGoToLogin_Enter);
            this.labelGoToLogin.Leave += new System.EventHandler(this.labelGoToLogin_Leave);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(517, 412);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 202;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // AdminRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 447);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.labelGoToLogin);
            this.Controls.Add(this.btnAdminRegister);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbEmailAddress);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.labelAdminRegister);
            this.Name = "AdminRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminRegister";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminRegister_FormClosed);
            this.Load += new System.EventHandler(this.AdminRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdminRegister;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Button btnAdminRegister;
        private System.Windows.Forms.Label labelGoToLogin;
        private System.Windows.Forms.Button btn_Back;
    }
}