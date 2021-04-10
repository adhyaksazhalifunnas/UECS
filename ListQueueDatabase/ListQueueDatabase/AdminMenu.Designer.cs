
namespace ListQueueDatabase
{
    partial class AdminMenu
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
            this.LabelGuestName = new System.Windows.Forms.Label();
            this.btn_QueueCall = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.AdminNameTxt = new System.Windows.Forms.TextBox();
            this.LabelAntrian = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelGuestName
            // 
            this.LabelGuestName.AutoSize = true;
            this.LabelGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGuestName.Location = new System.Drawing.Point(12, 139);
            this.LabelGuestName.Name = "LabelGuestName";
            this.LabelGuestName.Size = new System.Drawing.Size(0, 42);
            this.LabelGuestName.TabIndex = 10;
            // 
            // btn_QueueCall
            // 
            this.btn_QueueCall.Location = new System.Drawing.Point(75, 10);
            this.btn_QueueCall.Name = "btn_QueueCall";
            this.btn_QueueCall.Size = new System.Drawing.Size(187, 70);
            this.btn_QueueCall.TabIndex = 9;
            this.btn_QueueCall.Text = "NEXT CUSTOMER";
            this.btn_QueueCall.UseVisualStyleBackColor = true;
            this.btn_QueueCall.Click += new System.EventHandler(this.btn_QueueCall_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(187, 227);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // AdminNameTxt
            // 
            this.AdminNameTxt.Location = new System.Drawing.Point(12, 36);
            this.AdminNameTxt.Name = "AdminNameTxt";
            this.AdminNameTxt.Size = new System.Drawing.Size(57, 20);
            this.AdminNameTxt.TabIndex = 7;
            this.AdminNameTxt.Text = "ADMIN";
            this.AdminNameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelAntrian
            // 
            this.LabelAntrian.AutoSize = true;
            this.LabelAntrian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAntrian.Location = new System.Drawing.Point(15, 115);
            this.LabelAntrian.Name = "LabelAntrian";
            this.LabelAntrian.Size = new System.Drawing.Size(109, 24);
            this.LabelAntrian.TabIndex = 11;
            this.LabelAntrian.Text = "Antrian No: ";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 262);
            this.Controls.Add(this.LabelAntrian);
            this.Controls.Add(this.LabelGuestName);
            this.Controls.Add(this.btn_QueueCall);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.AdminNameTxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelGuestName;
        private System.Windows.Forms.Button btn_QueueCall;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox AdminNameTxt;
        private System.Windows.Forms.Label LabelAntrian;
    }
}