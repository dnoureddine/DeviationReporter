using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace graphique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1.Series["Deviation"].Points.AddXY("January", 6);
            this.chart1.Series["Deviation"].Points.AddXY("February", 12);
            this.chart1.Series["Deviation"].Points.AddXY("March", 6);
            this.chart1.Series["Deviation"].Points.AddXY("April", 6);
            this.chart1.Series["Deviation"].Points.AddXY("May", 12);
            this.chart1.Series["Deviation"].Points.AddXY("June", 6);
            this.chart1.Series["Deviation"].Points.AddXY("July", 6);
            this.chart1.Series["Deviation"].Points.AddXY("August", 6);
            this.chart1.Series["Deviation"].Points.AddXY("September", 6);
            this.chart1.Series["Deviation"].Points.AddXY("October", 1);
            this.chart1.Series["Deviation"].Points.AddXY("November", 6);
            this.chart1.Series["Deviation"].Points.AddXY("December", 0);
        }
    }
}
