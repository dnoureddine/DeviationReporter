namespace DeviationManager.GUI
{
    partial class PrincipalWin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalWin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDeviationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveApprovementGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDeviationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.language = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.approvedExpired = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pendingDev = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.approvedDev = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rejectedDev = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.deviationList = new System.Windows.Forms.Button();
            this.newDevaition = new System.Windows.Forms.Button();
            this.DeviationDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deviationAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviationÜberarbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviationSchliessenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruppeErinnernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sendMessage = new System.Windows.Forms.Button();
            this.listdeviationNumber = new System.Windows.Forms.Label();
            this.showDeviation = new System.Windows.Forms.Button();
            this.updateDeviation = new System.Windows.Forms.Button();
            this.closeDeviation = new System.Windows.Forms.Button();
            this.leftArrow = new System.Windows.Forms.Button();
            this.editDeviation = new System.Windows.Forms.Button();
            this.addDeviation = new System.Windows.Forms.Button();
            this.rightArrow = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeviationDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.lISTToolStripMenuItem,
            this.hELPToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1196, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDeviationToolStripMenuItem,
            this.saveApprovementGroupToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.saveToolStripMenuItem.Text = "Datei";
            // 
            // saveDeviationToolStripMenuItem
            // 
            this.saveDeviationToolStripMenuItem.Name = "saveDeviationToolStripMenuItem";
            this.saveDeviationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveDeviationToolStripMenuItem.Text = "Neue Abweichung";
            this.saveDeviationToolStripMenuItem.Click += new System.EventHandler(this.saveDeviationToolStripMenuItem_Click);
            // 
            // saveApprovementGroupToolStripMenuItem
            // 
            this.saveApprovementGroupToolStripMenuItem.Name = "saveApprovementGroupToolStripMenuItem";
            this.saveApprovementGroupToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveApprovementGroupToolStripMenuItem.Text = "Neue Freigabegruppe";
            this.saveApprovementGroupToolStripMenuItem.Click += new System.EventHandler(this.saveApprovementGroupToolStripMenuItem_Click);
            // 
            // lISTToolStripMenuItem
            // 
            this.lISTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listDeviationsToolStripMenuItem});
            this.lISTToolStripMenuItem.Name = "lISTToolStripMenuItem";
            this.lISTToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.lISTToolStripMenuItem.Text = "Liste";
            // 
            // listDeviationsToolStripMenuItem
            // 
            this.listDeviationsToolStripMenuItem.Name = "listDeviationsToolStripMenuItem";
            this.listDeviationsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listDeviationsToolStripMenuItem.Text = "Abweichungsliste";
            this.listDeviationsToolStripMenuItem.Click += new System.EventHandler(this.listDeviationsToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.hELPToolStripMenuItem.Text = "Statistics";
            this.hELPToolStripMenuItem.Click += new System.EventHandler(this.hELPToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.language);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 91);
            this.panel1.TabIndex = 1;
            // 
            // language
            // 
            this.language.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.language.FormattingEnabled = true;
            this.language.Items.AddRange(new object[] {
            "English",
            "Deutsch"});
            this.language.Location = new System.Drawing.Point(1010, 39);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(181, 21);
            this.language.TabIndex = 1;
            this.language.SelectedIndexChanged += new System.EventHandler(this.language_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(24, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(182, 71);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(140, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 134);
            this.panel3.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.approvedExpired);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(544, 22);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(181, 66);
            this.panel10.TabIndex = 4;
            this.toolTip.SetToolTip(this.panel10, "Die Liste der freigegebenen & abgelaufenen Abweichungen");
            this.panel10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel10_MouseClick);
            this.panel10.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            this.panel10.MouseLeave += new System.EventHandler(this.panel10_MouseLeave);
            // 
            // approvedExpired
            // 
            this.approvedExpired.AutoSize = true;
            this.approvedExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedExpired.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.approvedExpired.Location = new System.Drawing.Point(47, 21);
            this.approvedExpired.Name = "approvedExpired";
            this.approvedExpired.Size = new System.Drawing.Size(25, 25);
            this.approvedExpired.TabIndex = 3;
            this.approvedExpired.Text = "0";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DimGray;
            this.panel11.Controls.Add(this.pictureBox5);
            this.panel11.Location = new System.Drawing.Point(119, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(62, 66);
            this.panel11.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.ErrorImage")));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(10, 15);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 37);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gold;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.pendingDev);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(274, 21);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(195, 66);
            this.panel8.TabIndex = 2;
            this.toolTip.SetToolTip(this.panel8, "Die Liste der im Zeitfenster & unfollständigen Abweichungen");
            this.panel8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseClick);
            this.panel8.MouseEnter += new System.EventHandler(this.panel8_MouseEnter);
            this.panel8.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            // 
            // pendingDev
            // 
            this.pendingDev.AutoSize = true;
            this.pendingDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingDev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pendingDev.Location = new System.Drawing.Point(55, 21);
            this.pendingDev.Name = "pendingDev";
            this.pendingDev.Size = new System.Drawing.Size(25, 25);
            this.pendingDev.TabIndex = 3;
            this.pendingDev.Text = "0";
            this.pendingDev.Click += new System.EventHandler(this.blueDev_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Goldenrod;
            this.panel9.Controls.Add(this.pictureBox3);
            this.panel9.Location = new System.Drawing.Point(133, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(62, 66);
            this.panel9.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 37);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LimeGreen;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.approvedDev);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(33, 21);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(185, 66);
            this.panel6.TabIndex = 1;
            this.toolTip.SetToolTip(this.panel6, "Die Liste der im Zeitfenster & freigegebenen  Abweichungen");
            this.panel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseClick);
            this.panel6.MouseEnter += new System.EventHandler(this.panel6_MouseEnter);
            this.panel6.MouseLeave += new System.EventHandler(this.panel6_MouseLeave);
            // 
            // approvedDev
            // 
            this.approvedDev.AutoSize = true;
            this.approvedDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedDev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.approvedDev.Location = new System.Drawing.Point(50, 21);
            this.approvedDev.Name = "approvedDev";
            this.approvedDev.Size = new System.Drawing.Size(25, 25);
            this.approvedDev.TabIndex = 2;
            this.approvedDev.Text = "0";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.ForestGreen;
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(123, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(62, 66);
            this.panel7.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rejectedDev);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(784, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 66);
            this.panel4.TabIndex = 0;
            this.toolTip.SetToolTip(this.panel4, "Die Liste der abgelehnten oder abgelaufenen & unfollständigen Abweichungen");
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseClick);
            this.panel4.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            // 
            // rejectedDev
            // 
            this.rejectedDev.AutoSize = true;
            this.rejectedDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectedDev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rejectedDev.Location = new System.Drawing.Point(47, 21);
            this.rejectedDev.Name = "rejectedDev";
            this.rejectedDev.Size = new System.Drawing.Size(25, 25);
            this.rejectedDev.TabIndex = 3;
            this.rejectedDev.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Brown;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(119, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(62, 66);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 37);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // deviationList
            // 
            this.deviationList.ForeColor = System.Drawing.Color.Black;
            this.deviationList.Location = new System.Drawing.Point(0, 46);
            this.deviationList.Name = "deviationList";
            this.deviationList.Size = new System.Drawing.Size(134, 45);
            this.deviationList.TabIndex = 7;
            this.deviationList.Text = "Deviation List";
            this.deviationList.UseVisualStyleBackColor = true;
            this.deviationList.Click += new System.EventHandler(this.deviationList_Click);
            // 
            // newDevaition
            // 
            this.newDevaition.ForeColor = System.Drawing.Color.Black;
            this.newDevaition.Location = new System.Drawing.Point(0, 0);
            this.newDevaition.Name = "newDevaition";
            this.newDevaition.Size = new System.Drawing.Size(134, 42);
            this.newDevaition.TabIndex = 6;
            this.newDevaition.Text = "New Deviation";
            this.newDevaition.UseVisualStyleBackColor = true;
            this.newDevaition.Click += new System.EventHandler(this.newDevaition_Click);
            // 
            // DeviationDataGridView
            // 
            this.DeviationDataGridView.AllowUserToAddRows = false;
            this.DeviationDataGridView.AllowUserToDeleteRows = false;
            this.DeviationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeviationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeviationDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.DeviationDataGridView.Location = new System.Drawing.Point(0, 143);
            this.DeviationDataGridView.MultiSelect = false;
            this.DeviationDataGridView.Name = "DeviationDataGridView";
            this.DeviationDataGridView.ReadOnly = true;
            this.DeviationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeviationDataGridView.Size = new System.Drawing.Size(1142, 359);
            this.DeviationDataGridView.TabIndex = 2;
            this.DeviationDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeviationDataGridView_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviationAnzeigenToolStripMenuItem,
            this.deviationÜberarbeitenToolStripMenuItem,
            this.deviationSchliessenToolStripMenuItem,
            this.gruppeErinnernToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 92);
            // 
            // deviationAnzeigenToolStripMenuItem
            // 
            this.deviationAnzeigenToolStripMenuItem.Name = "deviationAnzeigenToolStripMenuItem";
            this.deviationAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deviationAnzeigenToolStripMenuItem.Text = "Deviation Anzeigen";
            this.deviationAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.deviationAnzeigenToolStripMenuItem_Click);
            // 
            // deviationÜberarbeitenToolStripMenuItem
            // 
            this.deviationÜberarbeitenToolStripMenuItem.Name = "deviationÜberarbeitenToolStripMenuItem";
            this.deviationÜberarbeitenToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deviationÜberarbeitenToolStripMenuItem.Text = "Deviation überarbeiten";
            this.deviationÜberarbeitenToolStripMenuItem.Click += new System.EventHandler(this.deviationÜberarbeitenToolStripMenuItem_Click);
            // 
            // deviationSchliessenToolStripMenuItem
            // 
            this.deviationSchliessenToolStripMenuItem.Name = "deviationSchliessenToolStripMenuItem";
            this.deviationSchliessenToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deviationSchliessenToolStripMenuItem.Text = "Deviation sperren";
            this.deviationSchliessenToolStripMenuItem.Click += new System.EventHandler(this.deviationSchliessenToolStripMenuItem_Click);
            // 
            // gruppeErinnernToolStripMenuItem
            // 
            this.gruppeErinnernToolStripMenuItem.Name = "gruppeErinnernToolStripMenuItem";
            this.gruppeErinnernToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.gruppeErinnernToolStripMenuItem.Text = "Gruppe erinnern";
            this.gruppeErinnernToolStripMenuItem.Click += new System.EventHandler(this.gruppeErinnernToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.sendMessage);
            this.panel2.Controls.Add(this.listdeviationNumber);
            this.panel2.Controls.Add(this.showDeviation);
            this.panel2.Controls.Add(this.updateDeviation);
            this.panel2.Controls.Add(this.closeDeviation);
            this.panel2.Controls.Add(this.leftArrow);
            this.panel2.Controls.Add(this.editDeviation);
            this.panel2.Controls.Add(this.DeviationDataGridView);
            this.panel2.Controls.Add(this.addDeviation);
            this.panel2.Controls.Add(this.rightArrow);
            this.panel2.Controls.Add(this.deviationList);
            this.panel2.Controls.Add(this.newDevaition);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(25, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 565);
            this.panel2.TabIndex = 8;
            // 
            // sendMessage
            // 
            this.sendMessage.Image = ((System.Drawing.Image)(resources.GetObject("sendMessage.Image")));
            this.sendMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendMessage.Location = new System.Drawing.Point(639, 509);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(128, 37);
            this.sendMessage.TabIndex = 13;
            this.sendMessage.Text = " Remind Group";
            this.sendMessage.UseVisualStyleBackColor = true;
            this.sendMessage.Click += new System.EventHandler(this.sendMessage_Click);
            // 
            // listdeviationNumber
            // 
            this.listdeviationNumber.AutoSize = true;
            this.listdeviationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listdeviationNumber.ForeColor = System.Drawing.Color.Red;
            this.listdeviationNumber.Location = new System.Drawing.Point(926, 515);
            this.listdeviationNumber.Name = "listdeviationNumber";
            this.listdeviationNumber.Size = new System.Drawing.Size(103, 13);
            this.listdeviationNumber.TabIndex = 11;
            this.listdeviationNumber.Text = "1-200 von 48743";
            // 
            // showDeviation
            // 
            this.showDeviation.Image = ((System.Drawing.Image)(resources.GetObject("showDeviation.Image")));
            this.showDeviation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showDeviation.Location = new System.Drawing.Point(485, 509);
            this.showDeviation.Name = "showDeviation";
            this.showDeviation.Size = new System.Drawing.Size(148, 37);
            this.showDeviation.TabIndex = 12;
            this.showDeviation.Text = " Show Deviation";
            this.showDeviation.UseVisualStyleBackColor = true;
            this.showDeviation.Click += new System.EventHandler(this.showDeviation_Click);
            // 
            // updateDeviation
            // 
            this.updateDeviation.ForeColor = System.Drawing.Color.Black;
            this.updateDeviation.Location = new System.Drawing.Point(0, 94);
            this.updateDeviation.Name = "updateDeviation";
            this.updateDeviation.Size = new System.Drawing.Size(134, 43);
            this.updateDeviation.TabIndex = 8;
            this.updateDeviation.Text = "Update";
            this.updateDeviation.UseVisualStyleBackColor = true;
            this.updateDeviation.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeDeviation
            // 
            this.closeDeviation.Image = ((System.Drawing.Image)(resources.GetObject("closeDeviation.Image")));
            this.closeDeviation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeDeviation.Location = new System.Drawing.Point(330, 509);
            this.closeDeviation.Name = "closeDeviation";
            this.closeDeviation.Size = new System.Drawing.Size(149, 37);
            this.closeDeviation.TabIndex = 11;
            this.closeDeviation.Text = " Close Deviation";
            this.closeDeviation.UseVisualStyleBackColor = true;
            this.closeDeviation.Click += new System.EventHandler(this.closeDeviation_Click);
            // 
            // leftArrow
            // 
            this.leftArrow.Image = ((System.Drawing.Image)(resources.GetObject("leftArrow.Image")));
            this.leftArrow.Location = new System.Drawing.Point(1044, 508);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(44, 28);
            this.leftArrow.TabIndex = 10;
            this.leftArrow.UseVisualStyleBackColor = true;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // editDeviation
            // 
            this.editDeviation.Image = ((System.Drawing.Image)(resources.GetObject("editDeviation.Image")));
            this.editDeviation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editDeviation.Location = new System.Drawing.Point(155, 509);
            this.editDeviation.Name = "editDeviation";
            this.editDeviation.Size = new System.Drawing.Size(169, 37);
            this.editDeviation.TabIndex = 10;
            this.editDeviation.Text = "Edit Deviation";
            this.editDeviation.UseVisualStyleBackColor = true;
            this.editDeviation.Click += new System.EventHandler(this.editDeviation_Click);
            // 
            // addDeviation
            // 
            this.addDeviation.Image = ((System.Drawing.Image)(resources.GetObject("addDeviation.Image")));
            this.addDeviation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDeviation.Location = new System.Drawing.Point(0, 508);
            this.addDeviation.Name = "addDeviation";
            this.addDeviation.Size = new System.Drawing.Size(149, 38);
            this.addDeviation.TabIndex = 9;
            this.addDeviation.Text = " Add Deviation";
            this.addDeviation.UseVisualStyleBackColor = true;
            this.addDeviation.Click += new System.EventHandler(this.addDeviation_Click);
            // 
            // rightArrow
            // 
            this.rightArrow.Image = ((System.Drawing.Image)(resources.GetObject("rightArrow.Image")));
            this.rightArrow.Location = new System.Drawing.Point(1097, 508);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(45, 28);
            this.rightArrow.TabIndex = 9;
            this.rightArrow.UseVisualStyleBackColor = true;
            this.rightArrow.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PrincipalWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 714);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalWin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Deviation Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeviationDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDeviationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveApprovementGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDeviationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label approvedDev;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label pendingDev;
        private System.Windows.Forms.Label rejectedDev;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button deviationList;
        private System.Windows.Forms.Button newDevaition;
        private System.Windows.Forms.DataGridView DeviationDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button updateDeviation;
        private System.Windows.Forms.ComboBox language;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deviationAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviationÜberarbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviationSchliessenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruppeErinnernToolStripMenuItem;
        private System.Windows.Forms.Button rightArrow;
        private System.Windows.Forms.Button leftArrow;
        private System.Windows.Forms.Label listdeviationNumber;
        private System.Windows.Forms.Button sendMessage;
        private System.Windows.Forms.Button showDeviation;
        private System.Windows.Forms.Button closeDeviation;
        private System.Windows.Forms.Button editDeviation;
        private System.Windows.Forms.Button addDeviation;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label approvedExpired;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}