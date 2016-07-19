namespace DeviationManager.GUI
{
    partial class ApprovementGroupGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApprovementGroupGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.approvementGroupsDataGridview = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.groupEmail = new System.Windows.Forms.TextBox();
            this.idGroupeApprovement = new System.Windows.Forms.TextBox();
            this.lId = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.TextBox();
            this.lRole = new System.Windows.Forms.Label();
            this.liblle = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.approvementGroupsDataGridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.approvementGroupsDataGridview);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 499);
            this.panel1.TabIndex = 0;
            // 
            // approvementGroupsDataGridview
            // 
            this.approvementGroupsDataGridview.AllowUserToAddRows = false;
            this.approvementGroupsDataGridview.AllowUserToDeleteRows = false;
            this.approvementGroupsDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.approvementGroupsDataGridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.approvementGroupsDataGridview.Location = new System.Drawing.Point(0, 236);
            this.approvementGroupsDataGridview.MultiSelect = false;
            this.approvementGroupsDataGridview.Name = "approvementGroupsDataGridview";
            this.approvementGroupsDataGridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.approvementGroupsDataGridview.Size = new System.Drawing.Size(684, 263);
            this.approvementGroupsDataGridview.TabIndex = 7;
            this.approvementGroupsDataGridview.SelectionChanged += new System.EventHandler(this.approvementGroupsDataGridview_SelectionChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(490, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Register Approvement Group";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.registerApprovementGroupe_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(490, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete Approvement Group";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteApprovementGroup_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(490, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "New Approvement Group";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addNewApprovementGroup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lEmail);
            this.groupBox1.Controls.Add(this.groupEmail);
            this.groupBox1.Controls.Add(this.idGroupeApprovement);
            this.groupBox1.Controls.Add(this.lId);
            this.groupBox1.Controls.Add(this.role);
            this.groupBox1.Controls.Add(this.lRole);
            this.groupBox1.Controls.Add(this.liblle);
            this.groupBox1.Controls.Add(this.lName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new approvement Group";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(6, 147);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(60, 15);
            this.lEmail.TabIndex = 12;
            this.lEmail.Text = "Email  : ";
            // 
            // groupEmail
            // 
            this.groupEmail.BackColor = System.Drawing.Color.White;
            this.groupEmail.Location = new System.Drawing.Point(73, 146);
            this.groupEmail.Multiline = true;
            this.groupEmail.Name = "groupEmail";
            this.groupEmail.Size = new System.Drawing.Size(308, 66);
            this.groupEmail.TabIndex = 11;
            // 
            // idGroupeApprovement
            // 
            this.idGroupeApprovement.BackColor = System.Drawing.Color.White;
            this.idGroupeApprovement.Enabled = false;
            this.idGroupeApprovement.Location = new System.Drawing.Point(73, 19);
            this.idGroupeApprovement.Name = "idGroupeApprovement";
            this.idGroupeApprovement.Size = new System.Drawing.Size(308, 20);
            this.idGroupeApprovement.TabIndex = 10;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lId.Location = new System.Drawing.Point(6, 20);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(61, 15);
            this.lId.TabIndex = 9;
            this.lId.Text = "ID        : ";
            // 
            // role
            // 
            this.role.BackColor = System.Drawing.Color.White;
            this.role.Location = new System.Drawing.Point(73, 105);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(308, 20);
            this.role.TabIndex = 8;
            // 
            // lRole
            // 
            this.lRole.AutoSize = true;
            this.lRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRole.Location = new System.Drawing.Point(6, 106);
            this.lRole.Name = "lRole";
            this.lRole.Size = new System.Drawing.Size(61, 15);
            this.lRole.TabIndex = 7;
            this.lRole.Text = "Role    : ";
            // 
            // liblle
            // 
            this.liblle.BackColor = System.Drawing.Color.White;
            this.liblle.Location = new System.Drawing.Point(73, 60);
            this.liblle.Name = "liblle";
            this.liblle.Size = new System.Drawing.Size(308, 20);
            this.liblle.TabIndex = 6;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(6, 61);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(61, 15);
            this.lName.TabIndex = 5;
            this.lName.Text = "Name  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Many Roles should be separated using semicolon  (;)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Many Emails should be separated using semicolon  (;)";
            // 
            // ApprovementGroupGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 499);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "ApprovementGroupGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freigabegruppe";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.approvementGroupsDataGridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox liblle;
        private System.Windows.Forms.TextBox role;
        private System.Windows.Forms.Label lRole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView approvementGroupsDataGridview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox idGroupeApprovement;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.TextBox groupEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}