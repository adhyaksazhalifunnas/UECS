
namespace ListQueueDatabase
{
    partial class GuestMenu
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.GuestNameTxt = new System.Windows.Forms.TextBox();
            this.btn_Queue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(159, 186);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // GuestNameTxt
            // 
            this.GuestNameTxt.AcceptsTab = true;
            this.GuestNameTxt.Location = new System.Drawing.Point(134, 6);
            this.GuestNameTxt.Name = "GuestNameTxt";
            this.GuestNameTxt.Size = new System.Drawing.Size(100, 20);
            this.GuestNameTxt.TabIndex = 4;
            this.GuestNameTxt.Text = "Guest";
            this.GuestNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Queue
            // 
            this.btn_Queue.Location = new System.Drawing.Point(134, 32);
            this.btn_Queue.Name = "btn_Queue";
            this.btn_Queue.Size = new System.Drawing.Size(100, 73);
            this.btn_Queue.TabIndex = 3;
            this.btn_Queue.Text = "QUEUE";
            this.btn_Queue.UseVisualStyleBackColor = true;
            this.btn_Queue.Click += new System.EventHandler(this.btn_Queue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Masukkan Nama Anda";
            // 
            // GuestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.GuestNameTxt);
            this.Controls.Add(this.btn_Queue);
            this.Name = "GuestMenu";
            this.Text = "GuestMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuestMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox GuestNameTxt;
        private System.Windows.Forms.Button btn_Queue;
        private System.Windows.Forms.Label label1;
    }
}