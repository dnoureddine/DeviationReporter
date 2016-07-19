namespace DeviationManager.GUI
{
    partial class ChangePassword
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
            this.Changepwd = new System.Windows.Forms.Button();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.lpassword = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Changepwd
            // 
            this.Changepwd.Location = new System.Drawing.Point(371, 154);
            this.Changepwd.Name = "Changepwd";
            this.Changepwd.Size = new System.Drawing.Size(111, 34);
            this.Changepwd.TabIndex = 6;
            this.Changepwd.Text = "Change";
            this.Changepwd.UseVisualStyleBackColor = true;
            this.Changepwd.Click += new System.EventHandler(this.Changepwd_Click);
            // 
            // oldPassword
            // 
            this.oldPassword.Location = new System.Drawing.Point(135, 47);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(347, 20);
            this.oldPassword.TabIndex = 5;
            // 
            // lpassword
            // 
            this.lpassword.AutoSize = true;
            this.lpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpassword.Location = new System.Drawing.Point(14, 48);
            this.lpassword.Name = "lpassword";
            this.lpassword.Size = new System.Drawing.Size(111, 15);
            this.lpassword.TabIndex = 4;
            this.lpassword.Text = "Old Password   :";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(135, 99);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(347, 20);
            this.newPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "New Password   :";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.Changepwd);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.lpassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Changepwd;
        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.Label lpassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label1;
    }
}