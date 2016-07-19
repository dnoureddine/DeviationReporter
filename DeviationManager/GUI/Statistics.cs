using DeviationManager.Entity;
using DeviationManager.Model;
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

namespace DeviationManager.GUI
{
    public partial class Statistics : Form
    {
        private StatisticsModel statisticsModel;
        Dictionary<int, string> month;
        Bitmap bitmap;
        LanguageModel languageModel;

        public Statistics()
        {
            InitializeComponent();
            statisticsModel = new StatisticsModel();

            languageModel = new LanguageModel();
            month  = new Dictionary<int, string>();

            month.Add(1, "Januar");
            month.Add(2, "Februar");
            month.Add(3, "März");
            month.Add(4, "April");
            month.Add(5, "Mai");
            month.Add(6, "Juni");
            month.Add(7, "Juli");
            month.Add(8, "August");
            month.Add(9, "September");
            month.Add(10, "Oktober");
            month.Add(11, "November");
            month.Add(12, "Dezember");

            //****************************
            this.printButton.Text = this.languageModel.getString("lsticPrint");


        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            //adding years to combobox
            DateTime actualDate = DateTime.Now;
            int actualYear = actualDate.Year;
            for (int i = 2015; i <= actualYear; i++)
            {
                this.cbx_year.Items.Add(i+"");
            }

            this.label_year.Text = "/" + DateTime.Now.Year.ToString();
            this.cbx_year.SelectedIndex = this.cbx_year.Items.IndexOf(DateTime.Now.Year.ToString());

        }

        //init
        private void showData(int year)
        {
            this.chart1.Series["Freigegebene Abweichungen"].Points.AddXY(month[1], this.statisticsModel.getApprovedDeviationNumber(year,1).Count);
            this.chart1.Series["Abgelehnte & abgelaufene Abweichungen"].Points.AddXY(month[1], this.statisticsModel.getRejectedDeviationNumber(year,1).Count);

            this.chart1.Series["Freigegebene Abweichungen"].Points.AddXY(month[2], this.statisticsModel.getApprovedDeviationNumber(year, 2).Count);
            this.chart1.Series["Abgelehnte & abgelaufene Abweichungen"].Points.AddXY(month[2], this.statisticsModel.getRejectedDeviationNumber(year, 2).Count);


            this.chart1.Series["Freigegebene Abweichungen"].Points.AddXY(month[3], this.statisticsModel.getApprovedDeviationNumber(year, 3).Count);
            this.chart1.Series["Abgelehnte & abgelaufene Abweichungen"].Points.AddXY(month[3], this.statisticsModel.getRejectedDeviationNumber(year, 3).Count);


            this.chart1.Series["Freigegebene Abweichungen"].Points.AddXY(month[4], this.statisticsModel.getApprovedDeviationNumber(year, 4).Count);
            this.chart1.Series["Abgelehnte & abgelaufene Abweichungen"].Points.AddXY(month[4], this.statisticsModel.getRejectedDeviationNumber(year, 4).Count);


            this.chart1.Series["Freigegebene Abweichungen"].Points.AddXY(month[5], this.statisticsModel.getApprovedDeviationNumber(year, 5).Count);
            this.chart1.Series["Abgelehnte & abgelaufene Abweichungen"].Points.AddXY(month[5], this.statisticsModel.getRejectedDeviationNumber(year, 5).Count);


            this.chart1.Series["Freigegebene Abweichungen"].Points.AddXY(month[6], this.statisticsModel.getApprovedDeviationNumber(year, 6).Count);
            this.chart1.Series["Abgelehnte & abgelaufene Abweichungen"].Points.AddXY(month[6], this.statisticsModel.getRejectedDeviationNumber(year, 6).Count);


            this.chart1.Series["Freigegebene Abweichungen"].Points.AddXY(month[7], this.statisticsModel.getApprovedDeviationNumber(year, 7).Count);
            this.chart1.Series["Abgelehnte & abgelaufene Abweichungen"].Points.AddXY(month[7], this.statisticsModel.getRejectedDeviationNumber(year, 7).Count);


            this.chart1.Series["Freigegebene Abweichungen"].Points.AddXY(month[8], this.statisticsModel.getApprovedDeviationNumber(year, 8).Count);
            this.chart1.Series["Abgelehnte & abgelaufene Abweichungen"].Points.AddXY(month[8], this.statisticsModel.getRejectedDeviationNumber(year, 8).Count);


            this.chart1.Series["Freigegebene Abweichungen"].Points.AddXY(month[9], this.statisticsModel.getApprovedDeviationNumber(year, 9).Count);
            this.chart1.Series["Abgelehnte & abgelaufene Abweichungen"].Points.AddXY(month[9], this.statisticsModel.getRejectedDeviationNumber(year, 9).Count);


            this.chart1.Series["Freigegebene Abweichungen"].Points.AddXY(month[10], this.statisticsModel.getApprovedDeviationNumber(year, 10).Count);
            this.chart1.Series["Abgelehnte & abgelaufene Abweichungen"].Points.AddXY(month[10], this.statisticsModel.getRejectedDeviationNumber(year, 10).Count);


            this.chart1.Series["Freigegebene Abweichungen"].Points.AddXY(month[11], this.statisticsModel.getApprovedDeviationNumber(year, 11).Count);
            this.chart1.Series["Abgelehnte & abgelaufene Abweichungen"].Points.AddXY(month[11], this.statisticsModel.getRejectedDeviationNumber(year, 11).Count);


            this.chart1.Series["Freigegebene Abweichungen"].Points.AddXY(month[12], this.statisticsModel.getApprovedDeviationNumber(year, 12).Count);
            this.chart1.Series["Abgelehnte & abgelaufene Abweichungen"].Points.AddXY(month[12], this.statisticsModel.getRejectedDeviationNumber(year, 12).Count);

        }
        

        private void cbx_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbx_year.SelectedItem != null)
            {
                this.label_year.Text = "/" + this.cbx_year.SelectedItem.ToString();
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();

                this.showData(Int32.Parse(this.cbx_year.SelectedItem.ToString()));

                this.listBoxUsers.Items.Clear();
                this.selctedMonthListBox.Text = "";

            }
        }


        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart1.HitTest(e.X, e.Y);

            //detecting the clicked Bar and showing the users that created the devitions in listBox
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                // index of the clicked point in its series
                int index = result.PointIndex;

                // actual values
                String selectedMonth = result.Series.Points[result.PointIndex].AxisLabel;

                this.selctedMonthListBox.Text = "/"+selectedMonth;
                //Deviation approved or rejected
                String deviationApprovementType = result.Series.Name;

                //Get the Users that create the selected Deviations
                int monthNumber = this.month.Where(kvp => kvp.Value == selectedMonth).Select(kvp => kvp.Key).FirstOrDefault();

                //clean listBoxUsers
                this.listBoxUsers.Items.Clear();
                IList<Deviation> deviations = new List<Deviation>();

                if (deviationApprovementType == "Freigegebene Abweichungen")
                {
                    deviations = this.statisticsModel.getApprovedDeviationNumber(Int32.Parse(this.cbx_year.SelectedItem.ToString()), monthNumber);
                    this.selctedMonthListBox.ForeColor = Color.Green;
                }
                else if(deviationApprovementType == "Abgelehnte & abgelaufene Abweichungen")
                {
                    deviations = this.statisticsModel.getRejectedDeviationNumber(Int32.Parse(this.cbx_year.SelectedItem.ToString()), monthNumber);
                    this.selctedMonthListBox.ForeColor = Color.Red;
                }

                //remove duplicated users name
                String[] users = new String[deviations.Count]; int i = 0;
                foreach (var deviation in deviations)
                {
                    users[i] = deviation.requestedBy;
                    i++;
                }

                String[] removedDuplicatedUsers = users.Distinct().ToArray();

                //add users name to listboxUsers
                foreach (var username in removedDuplicatedUsers)
                {
                    this.listBoxUsers.Items.Add(username);
                }

               


            }


        }

        private void listBoxUsers_DoubleClick(object sender, EventArgs e)
        {
            if(this.listBoxUsers.SelectedItem != null)
            {
                String userName = this.listBoxUsers.SelectedItem.ToString();
                DeviationList deviationList = new DeviationList();
                deviationList.showDeviationForOneUser(userName);
            }
            
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //Add a Panel control.
            Panel panel = new Panel();
            this.Controls.Add(panel);

            //Create a Bitmap of size same as that of the Form.
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);

            //Copy screen area that that the Panel covers.
            //new Size to avoid printing the button
            Size newSize = new Size(formSize.Width, formSize.Height - 60);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, newSize);

            //Show the Print Preview Dialog.
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4", formSize.Width,1000);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;

            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
