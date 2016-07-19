namespace DeviationManager.GUI
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_year = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selctedMonthListBox = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "The Number of Deviations for a selected year :";
            // 
            // cbx_year
            // 
            this.cbx_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_year.FormattingEnabled = true;
            this.cbx_year.Location = new System.Drawing.Point(105, 12);
            this.cbx_year.Name = "cbx_year";
            this.cbx_year.Size = new System.Drawing.Size(294, 21);
            this.cbx_year.TabIndex = 6;
            this.cbx_year.SelectedIndexChanged += new System.EventHandler(this.cbx_year_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose a year :";
            // 
            // chart1
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Angle = -45;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(5, 74);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Green;
            series3.Legend = "Legend1";
            series3.Name = "Freigegebene Abweichungen";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Abgelehnte & abgelaufene Abweichungen";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(992, 354);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_year.ForeColor = System.Drawing.Color.Red;
            this.label_year.Location = new System.Drawing.Point(272, 47);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(0, 13);
            this.label_year.TabIndex = 8;
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 15;
            this.listBoxUsers.Location = new System.Drawing.Point(782, 149);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.ScrollAlwaysVisible = true;
            this.listBoxUsers.Size = new System.Drawing.Size(195, 214);
            this.listBoxUsers.TabIndex = 9;
            this.listBoxUsers.DoubleClick += new System.EventHandler(this.listBoxUsers_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(779, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "List der Benuzern: ";
            // 
            // selctedMonthListBox
            // 
            this.selctedMonthListBox.AutoSize = true;
            this.selctedMonthListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selctedMonthListBox.Location = new System.Drawing.Point(899, 133);
            this.selctedMonthListBox.Name = "selctedMonthListBox";
            this.selctedMonthListBox.Size = new System.Drawing.Size(0, 13);
            this.selctedMonthListBox.TabIndex = 11;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(12, 468);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(124, 31);
            this.printButton.TabIndex = 12;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 503);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.selctedMonthListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selctedMonthListBox;
        private System.Windows.Forms.Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}