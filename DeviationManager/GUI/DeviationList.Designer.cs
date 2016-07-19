namespace DeviationManager.GUI
{
    partial class DeviationList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviationList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listdeviationNumber = new System.Windows.Forms.Label();
            this.leftArrow = new System.Windows.Forms.Button();
            this.rightArrow = new System.Windows.Forms.Button();
            this.sendMessage = new System.Windows.Forms.Button();
            this.showDeviation = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DeviationDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deviationAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviationÜberarbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviationSchliessenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruppeErinnernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ldeviationFilterBox = new System.Windows.Forms.GroupBox();
            this.lartabweichung = new System.Windows.Forms.Label();
            this.lDate2 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.lDate1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.lProduct = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.TextBox();
            this.lAnlage = new System.Windows.Forms.Label();
            this.anlage = new System.Windows.Forms.TextBox();
            this.deviationListUpdate = new System.Windows.Forms.Button();
            this.lUseAllInputs = new System.Windows.Forms.Label();
            this.likeSearch = new System.Windows.Forms.CheckBox();
            this.Filter = new System.Windows.Forms.Button();
            this.requestedBy = new System.Windows.Forms.TextBox();
            this.lRequestedBy = new System.Windows.Forms.Label();
            this.deviationType = new System.Windows.Forms.ComboBox();
            this.lDeviationType = new System.Windows.Forms.Label();
            this.riskCategory = new System.Windows.Forms.ComboBox();
            this.lRiskCategory = new System.Windows.Forms.Label();
            this.deviationNO = new System.Windows.Forms.TextBox();
            this.lDeviationNO = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeviationDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ldeviationFilterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listdeviationNumber);
            this.panel1.Controls.Add(this.leftArrow);
            this.panel1.Controls.Add(this.rightArrow);
            this.panel1.Controls.Add(this.sendMessage);
            this.panel1.Controls.Add(this.showDeviation);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.DeviationDataGridView);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ldeviationFilterBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 672);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Darstellung auf 200 Zeilen begrenzt";
            // 
            // listdeviationNumber
            // 
            this.listdeviationNumber.AutoSize = true;
            this.listdeviationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listdeviationNumber.ForeColor = System.Drawing.Color.Red;
            this.listdeviationNumber.Location = new System.Drawing.Point(1014, 639);
            this.listdeviationNumber.Name = "listdeviationNumber";
            this.listdeviationNumber.Size = new System.Drawing.Size(103, 13);
            this.listdeviationNumber.TabIndex = 14;
            this.listdeviationNumber.Text = "1-200 von 48743";
            // 
            // leftArrow
            // 
            this.leftArrow.Image = ((System.Drawing.Image)(resources.GetObject("leftArrow.Image")));
            this.leftArrow.Location = new System.Drawing.Point(1132, 632);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(44, 28);
            this.leftArrow.TabIndex = 13;
            this.leftArrow.UseVisualStyleBackColor = true;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // rightArrow
            // 
            this.rightArrow.Image = ((System.Drawing.Image)(resources.GetObject("rightArrow.Image")));
            this.rightArrow.Location = new System.Drawing.Point(1182, 632);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(45, 28);
            this.rightArrow.TabIndex = 12;
            this.rightArrow.UseVisualStyleBackColor = true;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            // 
            // sendMessage
            // 
            this.sendMessage.Image = ((System.Drawing.Image)(resources.GetObject("sendMessage.Image")));
            this.sendMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendMessage.Location = new System.Drawing.Point(1078, 196);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(148, 38);
            this.sendMessage.TabIndex = 6;
            this.sendMessage.Text = " Remind Group";
            this.sendMessage.UseVisualStyleBackColor = true;
            this.sendMessage.Click += new System.EventHandler(this.sendMessage_Click);
            // 
            // showDeviation
            // 
            this.showDeviation.Image = ((System.Drawing.Image)(resources.GetObject("showDeviation.Image")));
            this.showDeviation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showDeviation.Location = new System.Drawing.Point(1078, 152);
            this.showDeviation.Name = "showDeviation";
            this.showDeviation.Size = new System.Drawing.Size(148, 38);
            this.showDeviation.TabIndex = 5;
            this.showDeviation.Text = " Show Deviation";
            this.showDeviation.UseVisualStyleBackColor = true;
            this.showDeviation.Click += new System.EventHandler(this.showDeviation_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1078, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Expire Deviation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.closeDeviation_Click);
            // 
            // DeviationDataGridView
            // 
            this.DeviationDataGridView.AllowUserToAddRows = false;
            this.DeviationDataGridView.AllowUserToDeleteRows = false;
            this.DeviationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeviationDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.DeviationDataGridView.Location = new System.Drawing.Point(12, 240);
            this.DeviationDataGridView.MultiSelect = false;
            this.DeviationDataGridView.Name = "DeviationDataGridView";
            this.DeviationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeviationDataGridView.Size = new System.Drawing.Size(1214, 384);
            this.DeviationDataGridView.TabIndex = 3;
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
            this.deviationAnzeigenToolStripMenuItem.Text = "Deviation  anzeigen";
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
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1078, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit Deviation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.editDeviation_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1078, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = " Add Deviation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addNewDeviation_Click);
            // 
            // ldeviationFilterBox
            // 
            this.ldeviationFilterBox.Controls.Add(this.lartabweichung);
            this.ldeviationFilterBox.Controls.Add(this.lDate2);
            this.ldeviationFilterBox.Controls.Add(this.date2);
            this.ldeviationFilterBox.Controls.Add(this.lDate1);
            this.ldeviationFilterBox.Controls.Add(this.date1);
            this.ldeviationFilterBox.Controls.Add(this.lProduct);
            this.ldeviationFilterBox.Controls.Add(this.product);
            this.ldeviationFilterBox.Controls.Add(this.lAnlage);
            this.ldeviationFilterBox.Controls.Add(this.anlage);
            this.ldeviationFilterBox.Controls.Add(this.deviationListUpdate);
            this.ldeviationFilterBox.Controls.Add(this.lUseAllInputs);
            this.ldeviationFilterBox.Controls.Add(this.likeSearch);
            this.ldeviationFilterBox.Controls.Add(this.Filter);
            this.ldeviationFilterBox.Controls.Add(this.requestedBy);
            this.ldeviationFilterBox.Controls.Add(this.lRequestedBy);
            this.ldeviationFilterBox.Controls.Add(this.deviationType);
            this.ldeviationFilterBox.Controls.Add(this.lDeviationType);
            this.ldeviationFilterBox.Controls.Add(this.riskCategory);
            this.ldeviationFilterBox.Controls.Add(this.lRiskCategory);
            this.ldeviationFilterBox.Controls.Add(this.deviationNO);
            this.ldeviationFilterBox.Controls.Add(this.lDeviationNO);
            this.ldeviationFilterBox.Location = new System.Drawing.Point(12, 12);
            this.ldeviationFilterBox.Name = "ldeviationFilterBox";
            this.ldeviationFilterBox.Size = new System.Drawing.Size(1060, 222);
            this.ldeviationFilterBox.TabIndex = 0;
            this.ldeviationFilterBox.TabStop = false;
            this.ldeviationFilterBox.Text = "Deviations Filter";
            // 
            // lartabweichung
            // 
            this.lartabweichung.AutoSize = true;
            this.lartabweichung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lartabweichung.Location = new System.Drawing.Point(368, 86);
            this.lartabweichung.Name = "lartabweichung";
            this.lartabweichung.Size = new System.Drawing.Size(0, 15);
            this.lartabweichung.TabIndex = 21;
            // 
            // lDate2
            // 
            this.lDate2.AutoSize = true;
            this.lDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate2.Location = new System.Drawing.Point(707, 76);
            this.lDate2.Name = "lDate2";
            this.lDate2.Size = new System.Drawing.Size(109, 15);
            this.lDate2.TabIndex = 20;
            this.lDate2.Text = "Date to             :";
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(820, 76);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(219, 20);
            this.date2.TabIndex = 19;
            // 
            // lDate1
            // 
            this.lDate1.AutoSize = true;
            this.lDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate1.Location = new System.Drawing.Point(707, 35);
            this.lDate1.Name = "lDate1";
            this.lDate1.Size = new System.Drawing.Size(110, 15);
            this.lDate1.TabIndex = 18;
            this.lDate1.Text = "Date from         :";
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(820, 35);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(219, 20);
            this.date1.TabIndex = 17;
            // 
            // lProduct
            // 
            this.lProduct.AutoSize = true;
            this.lProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProduct.Location = new System.Drawing.Point(368, 124);
            this.lProduct.Name = "lProduct";
            this.lProduct.Size = new System.Drawing.Size(112, 15);
            this.lProduct.TabIndex = 16;
            this.lProduct.Text = "Product             :";
            this.lProduct.Click += new System.EventHandler(this.label7_Click);
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(481, 120);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(210, 20);
            this.product.TabIndex = 15;
            this.product.TextChanged += new System.EventHandler(this.product_TextChanged);
            // 
            // lAnlage
            // 
            this.lAnlage.AutoSize = true;
            this.lAnlage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAnlage.Location = new System.Drawing.Point(6, 119);
            this.lAnlage.Name = "lAnlage";
            this.lAnlage.Size = new System.Drawing.Size(110, 15);
            this.lAnlage.TabIndex = 14;
            this.lAnlage.Text = "Machine           :";
            // 
            // anlage
            // 
            this.anlage.Location = new System.Drawing.Point(120, 118);
            this.anlage.Name = "anlage";
            this.anlage.Size = new System.Drawing.Size(228, 20);
            this.anlage.TabIndex = 13;
            this.anlage.TextChanged += new System.EventHandler(this.anlage_TextChanged);
            // 
            // deviationListUpdate
            // 
            this.deviationListUpdate.Image = ((System.Drawing.Image)(resources.GetObject("deviationListUpdate.Image")));
            this.deviationListUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deviationListUpdate.Location = new System.Drawing.Point(820, 175);
            this.deviationListUpdate.Name = "deviationListUpdate";
            this.deviationListUpdate.Size = new System.Drawing.Size(102, 41);
            this.deviationListUpdate.TabIndex = 12;
            this.deviationListUpdate.Text = "Update";
            this.deviationListUpdate.UseVisualStyleBackColor = true;
            this.deviationListUpdate.Click += new System.EventHandler(this.deviationListUpdate_Click);
            // 
            // lUseAllInputs
            // 
            this.lUseAllInputs.AutoSize = true;
            this.lUseAllInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUseAllInputs.Location = new System.Drawing.Point(707, 124);
            this.lUseAllInputs.Name = "lUseAllInputs";
            this.lUseAllInputs.Size = new System.Drawing.Size(111, 15);
            this.lUseAllInputs.TabIndex = 11;
            this.lUseAllInputs.Text = "Use All Inputs   :";
            // 
            // likeSearch
            // 
            this.likeSearch.AutoSize = true;
            this.likeSearch.Location = new System.Drawing.Point(823, 126);
            this.likeSearch.Name = "likeSearch";
            this.likeSearch.Size = new System.Drawing.Size(15, 14);
            this.likeSearch.TabIndex = 10;
            this.likeSearch.UseVisualStyleBackColor = true;
            // 
            // Filter
            // 
            this.Filter.Image = ((System.Drawing.Image)(resources.GetObject("Filter.Image")));
            this.Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Filter.Location = new System.Drawing.Point(928, 175);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(122, 41);
            this.Filter.TabIndex = 9;
            this.Filter.Text = "Filter Deviations";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // requestedBy
            // 
            this.requestedBy.Location = new System.Drawing.Point(122, 66);
            this.requestedBy.Name = "requestedBy";
            this.requestedBy.Size = new System.Drawing.Size(226, 20);
            this.requestedBy.TabIndex = 8;
            this.requestedBy.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lRequestedBy
            // 
            this.lRequestedBy.AutoSize = true;
            this.lRequestedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRequestedBy.Location = new System.Drawing.Point(6, 67);
            this.lRequestedBy.Name = "lRequestedBy";
            this.lRequestedBy.Size = new System.Drawing.Size(111, 15);
            this.lRequestedBy.TabIndex = 7;
            this.lRequestedBy.Text = "Requested By   :";
            // 
            // deviationType
            // 
            this.deviationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviationType.FormattingEnabled = true;
            this.deviationType.Items.AddRange(new object[] {
            "",
            "Spezifikation",
            "Prozess",
            "Dokumentation"});
            this.deviationType.Location = new System.Drawing.Point(481, 71);
            this.deviationType.Name = "deviationType";
            this.deviationType.Size = new System.Drawing.Size(210, 21);
            this.deviationType.TabIndex = 6;
            this.deviationType.SelectedIndexChanged += new System.EventHandler(this.deviationType_SelectedIndexChanged);
            // 
            // lDeviationType
            // 
            this.lDeviationType.AutoSize = true;
            this.lDeviationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDeviationType.Location = new System.Drawing.Point(368, 71);
            this.lDeviationType.Name = "lDeviationType";
            this.lDeviationType.Size = new System.Drawing.Size(113, 15);
            this.lDeviationType.TabIndex = 5;
            this.lDeviationType.Text = "Deviation Type  :";
            // 
            // riskCategory
            // 
            this.riskCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.riskCategory.FormattingEnabled = true;
            this.riskCategory.Items.AddRange(new object[] {
            "",
            "ROT",
            "GELB",
            "GRÜN"});
            this.riskCategory.Location = new System.Drawing.Point(481, 30);
            this.riskCategory.Name = "riskCategory";
            this.riskCategory.Size = new System.Drawing.Size(210, 21);
            this.riskCategory.TabIndex = 4;
            this.riskCategory.SelectedIndexChanged += new System.EventHandler(this.riskCategory_SelectedIndexChanged);
            // 
            // lRiskCategory
            // 
            this.lRiskCategory.AutoSize = true;
            this.lRiskCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRiskCategory.Location = new System.Drawing.Point(368, 31);
            this.lRiskCategory.Name = "lRiskCategory";
            this.lRiskCategory.Size = new System.Drawing.Size(111, 15);
            this.lRiskCategory.TabIndex = 3;
            this.lRiskCategory.Text = "Risk Category   :";
            // 
            // deviationNO
            // 
            this.deviationNO.Location = new System.Drawing.Point(122, 26);
            this.deviationNO.Name = "deviationNO";
            this.deviationNO.Size = new System.Drawing.Size(226, 20);
            this.deviationNO.TabIndex = 2;
            this.deviationNO.TextChanged += new System.EventHandler(this.deviationNO_TextChanged);
            // 
            // lDeviationNO
            // 
            this.lDeviationNO.AutoSize = true;
            this.lDeviationNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDeviationNO.Location = new System.Drawing.Point(6, 26);
            this.lDeviationNO.Name = "lDeviationNO";
            this.lDeviationNO.Size = new System.Drawing.Size(110, 15);
            this.lDeviationNO.TabIndex = 0;
            this.lDeviationNO.Text = "DEVIATION NO :";
            // 
            // DeviationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 672);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abweichungsliste";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeviationDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ldeviationFilterBox.ResumeLayout(false);
            this.ldeviationFilterBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox ldeviationFilterBox;
        private System.Windows.Forms.Label lDeviationNO;
        private System.Windows.Forms.ComboBox riskCategory;
        private System.Windows.Forms.Label lRiskCategory;
        private System.Windows.Forms.TextBox deviationNO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox requestedBy;
        private System.Windows.Forms.Label lRequestedBy;
        private System.Windows.Forms.ComboBox deviationType;
        private System.Windows.Forms.Label lDeviationType;
        private System.Windows.Forms.DataGridView DeviationDataGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button showDeviation;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Label lUseAllInputs;
        private System.Windows.Forms.CheckBox likeSearch;
        private System.Windows.Forms.Button deviationListUpdate;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label lProduct;
        private System.Windows.Forms.TextBox product;
        private System.Windows.Forms.Label lAnlage;
        private System.Windows.Forms.TextBox anlage;
        private System.Windows.Forms.Label lDate1;
        private System.Windows.Forms.Label lDate2;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Button sendMessage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deviationAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviationÜberarbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviationSchliessenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruppeErinnernToolStripMenuItem;
        private System.Windows.Forms.Label lartabweichung;
        private System.Windows.Forms.Label listdeviationNumber;
        private System.Windows.Forms.Button leftArrow;
        private System.Windows.Forms.Button rightArrow;
        private System.Windows.Forms.Label label1;
    }
}