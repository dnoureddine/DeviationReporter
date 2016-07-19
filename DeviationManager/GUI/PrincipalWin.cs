using DeviationManager.Entity;
using DeviationManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace DeviationManager.GUI
{
    public partial class PrincipalWin : Form
    {
        private DeviationModel deviationModel;
        private Autorisation autorisation;
        private EmailSender emailSender;

        private String choosenList = "yellow";
        private int n = 1;
        private int m = 200;
       
        public PrincipalWin()
        {
            InitializeComponent();
            this.autorisation = new Autorisation();
            this.emailSender = new EmailSender();

            deviationModel = new DeviationModel();
            this.init();

            //initilize deviation list
            this.setLabelDeviationNumber();

            this.DeviationDataGridView.Columns[9].DefaultCellStyle.ForeColor = Color.Goldenrod;
        }


        //update deviation List
        public void updateDeviationList()
        {
            this.n = 1;
            this.m = 200;

            //change font color datagridview
            this.DeviationDataGridView.Columns[9].DefaultCellStyle.ForeColor = Color.Goldenrod;

            var deviations = deviationModel.listPendingDeviation(n, m);
            var source = new BindingSource();
            source.DataSource = deviations;
            this.DeviationDataGridView.DataSource = source;


            this.approvedDev.Text = this.deviationModel.getApprovedDeviationNumber() + "";
            this.pendingDev.Text = this.deviationModel.getPendingDeviationNumber() + "";
            this.rejectedDev.Text = this.deviationModel.getRejectedDeviationNumber() + "";
            this.approvedExpired.Text = this.deviationModel.listApprovedExpiredDeviationNumber() + "";
        }

        //init Method
        private void init()
        {
            this.approvedDev.Text = this.deviationModel.getApprovedDeviationNumber() + "";
            this.pendingDev.Text = this.deviationModel.getPendingDeviationNumber() + "";
            this.rejectedDev.Text = this.deviationModel.getRejectedDeviationNumber() + "";
            this.approvedExpired.Text = this.deviationModel.listApprovedExpiredDeviationNumber() + "";

            var deviations = deviationModel.listPendingDeviation(n,m);
            var source = new BindingSource();
            source.DataSource = deviations;
            this.DeviationDataGridView.DataSource = source;

            this.language.SelectedIndex = 1;
        }

        //update list number
        private void setLabelDeviationNumber()
        {
            long deviationNumb = 0;
            if (this.choosenList == "green")
            {
                deviationNumb = deviationModel.getApprovedDeviationNumber();
            }
            else if (this.choosenList == "yellow")
            {
                deviationNumb = deviationModel.getPendingDeviationNumber();
            }
            else if (this.choosenList == "red")
            {
                deviationNumb = deviationModel.getRejectedDeviationNumber();
            }
            else if (this.choosenList == "gray")
            {
                deviationNumb = deviationModel.listApprovedExpiredDeviationNumber();
            }

            String label = "";
            if ((n * m - m) == 0)
            {
                label = "1-";
            }
            else
            {
                label = (n * m - m) + "-";
            }

            //***
            if ((n * m) > deviationNumb)
            {
                label = label + (deviationNumb - (n * m - m));
            }
            else
            {
                label = label + (n * m);
            }

            label = label + " Von " + deviationNumb;

            if (deviationNumb == 0)
            {
                this.listdeviationNumber.Text = "0-0 Von 0 ";
            }else
            {
                this.listdeviationNumber.Text = label;
            }

            //button disable if (devitionNumb/m <n)
            if ((deviationNumb / m) < n)
            {
                this.rightArrow.Enabled = false;
            }
            else
            {
                this.rightArrow.Enabled = true;
            }

            if (n == 1)
            {
                this.leftArrow.Enabled = false;
            }
            else
            {
                this.leftArrow.Enabled = true;
            }
        }


        //set lanague
        private void setLanguage()
        {
            LanguageModel languageModel = new LanguageModel();

            this.newDevaition.Text = languageModel.getString("lnewDeviation");
            this.deviationList.Text = languageModel.getString("ldeviationList");
            this.updateDeviation.Text = languageModel.getString("lupdate");

            this.addDeviation.Text = languageModel.getString("laddDeviation");
            this.editDeviation.Text = languageModel.getString("leditDeviation");
            this.closeDeviation.Text = languageModel.getString("lcloseDeviation");
            this.showDeviation.Text = languageModel.getString("lshowDeviation");
            this.sendMessage.Text = languageModel.getString("lremindGroup");


        }

        //
        private void saveDeviationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDeviation saveDeviation = new SaveDeviation("newDeviation", null, this);
            saveDeviation.Show();
        }

        private void saveApprovementGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            conn.Show();
        }

        private void listDeviationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviationList deviationList = new DeviationList();
            deviationList.Show();
        }

        private void blueDev_Click(object sender, EventArgs e)
        {

        }


        private void panel13_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void newDevaition_Click(object sender, EventArgs e)
        {
            SaveDeviation addDeviation = new SaveDeviation("newDeviation", null, this);
            addDeviation.Show();
        }

        private void deviationList_Click(object sender, EventArgs e)
        {
            DeviationList deviationList = new DeviationList();
            deviationList.Show();
        }

        //show approved deviation
        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            //reset n and m
            this.n = 1;
            this.m = 200;
            this.choosenList = "green";

            //change color
            this.DeviationDataGridView.Columns[9].DefaultCellStyle.ForeColor = Color.Green;

            var deviations = deviationModel.listApprovedDeviation(n,m);
            var source = new BindingSource();
            source.DataSource = deviations;
            this.DeviationDataGridView.DataSource = source;

            this.setLabelDeviationNumber();
        }

        //show pending devations
        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            //reset n and m
            this.n = 1;
            this.m = 200;
            this.choosenList = "yellow";

            //change color
            this.DeviationDataGridView.Columns[9].DefaultCellStyle.ForeColor = Color.Goldenrod;

            var deviations = deviationModel.listPendingDeviation(n,m);
            var source = new BindingSource();
            source.DataSource = deviations;
            this.DeviationDataGridView.DataSource = source;

            this.setLabelDeviationNumber();
        }

        //show rejected Deviations
        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            //reset n and m
            this.n = 1;
            this.m = 200;
            this.choosenList = "red";

            //change color
            this.DeviationDataGridView.Columns[9].DefaultCellStyle.ForeColor = Color.Red;

            var deviations = deviationModel.listRejectedDeviation(n,m);
            var source = new BindingSource();
            source.DataSource = deviations;
            this.DeviationDataGridView.DataSource = source;

            this.setLabelDeviationNumber();
        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        //update list
        private void button1_Click(object sender, EventArgs e)
        {
            this.updateDeviationList();
        }

        private void language_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String languageName = this.language.SelectedItem.ToString();
            if (languageName == "English")
            {
                LanguageName.languageName = "DeviationManager.Lang.language_en";
            }
            else if (languageName=="Deutsch")
            {
                LanguageName.languageName = "DeviationManager.Lang.language_de";
            }
            

            //set Language
            this.setLanguage();
        }

        //show deviation
        private void deviationAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageModel languageModel = new LanguageModel();
            if (this.DeviationDataGridView.CurrentRow != null)
            {
                String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
                Deviation deviation = deviationModel.getDeviationWithRef(deviationRef);
                //The user can update the deviation if signature attribut of the deviation has the user name
                if (deviation != null)
                {
                    //show Deviation
                    SaveDeviation saveDeviation = new SaveDeviation("showDeviation", null, this);
                    saveDeviation.showDeviation(deviation);
                }
                else
                {
                    MessageBox.Show(languageModel.getString("deviationNotExist"));
                }

            }
            else
            {
                MessageBox.Show(languageModel.getString("chooseDeviation"));
            }
        }

        //edit deviation
        private void deviationÜberarbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageModel languageModel = new LanguageModel();
            String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
            Deviation deviation = autorisation.canUpdateDeviation(deviationRef);
            //The user can update the deviation if signature attribut of the deviation has the user name
            if (deviation != null)
            {
                //dos the user choose the Deviation to update
                if (deviationRef != "" && deviationRef != null)
                {

                    //make sure that the deviation is closed
                    if (!deviationModel.isDeviationClosed(deviation))
                    {
                        //update Deviation
                        SaveDeviation saveDeviation = new SaveDeviation("updateDeviation", null, this);
                        saveDeviation.updateDeviation(deviation);
                    }
                    else
                    {
                        MessageBox.Show(languageModel.getString("deviationAlreadyClosed"), "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else
            {
                MessageBox.Show(languageModel.getString("notAllowedToUpdateItem"), "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //close deviation
        private void deviationSchliessenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageModel languageModel = new LanguageModel();
            if (this.DeviationDataGridView.CurrentRow != null)
            {
                String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
                if (deviationRef != "" || deviationRef != null)
                {
                    if (MessageBox.Show(languageModel.getString("alertCloseDeviation"), "Close Deviation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String result = deviationModel.closeDeviation(deviationRef);
                        if (result == "closed")
                        {
                            MessageBox.Show(languageModel.getString("deviationWasClosed"), "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {                           
                            MessageBox.Show(languageModel.getString("errorCloseDeviation"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        //remind Group
        private void gruppeErinnernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageModel languageModel = new LanguageModel();
            if (this.DeviationDataGridView.CurrentRow != null)
            {
                String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
                Deviation deviation = autorisation.canUpdateDeviation(deviationRef);
                if (deviation != null)
                {
                    //send email to Groups that they did not yet approve
                    var result = this.emailSender.sentEmailToGroups(deviation);
                    if (result == "sent")
                    {
                        MessageBox.Show(languageModel.getString("emailSent"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        //add deviation
        private void addDeviation_Click(object sender, EventArgs e)
        {
            SaveDeviation saveDeviation = new SaveDeviation("newDeviation", null, this);
            saveDeviation.Show();
        }

        //add deviation
        private void editDeviation_Click(object sender, EventArgs e)
        {
            LanguageModel languageModel = new LanguageModel();
            String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
            Deviation deviation = autorisation.canUpdateDeviation(deviationRef);
            //The user can update the deviation if signature attribut of the deviation has the user name
            if (deviation != null)
            {
                //dos the user choose the Deviation to update
                if (deviationRef != "" && deviationRef != null)
                {

                    //make sure that the deviation is closed
                    if (!deviationModel.isDeviationClosed(deviation))
                    {
                        //update Deviation
                        SaveDeviation saveDeviation = new SaveDeviation("updateDeviation", null, this);
                        saveDeviation.updateDeviation(deviation);
                    }
                    else
                    {
                        MessageBox.Show(languageModel.getString("notAllowedToChange"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            
            else
            {
                MessageBox.Show(languageModel.getString("notAllowedToUpdateItem"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        //close deviation
        private void closeDeviation_Click(object sender, EventArgs e)
        {
            LanguageModel languageModel = new LanguageModel();
            
            if (this.DeviationDataGridView.CurrentRow != null)
            {
                String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
                if (deviationRef != "" || deviationRef != null)
                {
                    if (MessageBox.Show(languageModel.getString("alertCloseDeviation"), "Close Deviation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String result = deviationModel.closeDeviation(deviationRef);
                        if (result == "closed")
                        {
                            MessageBox.Show(languageModel.getString("deviationWasClosed"), "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(languageModel.getString("errorCloseDeviation"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        //show deviation
        private void showDeviation_Click(object sender, EventArgs e)
        {
            LanguageModel languageModel = new LanguageModel();
            if (this.DeviationDataGridView.CurrentRow != null)
            {
                String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
                Deviation deviation = deviationModel.getDeviationWithRef(deviationRef);
                //The user can update the deviation if signature attribut of the deviation has the user name
                if (deviation != null)
                {
                    //show Deviation
                    SaveDeviation saveDeviation = new SaveDeviation("showDeviation", null, this);
                    saveDeviation.showDeviation(deviation);
                }
                else
                {
                    MessageBox.Show(languageModel.getString("deviationNotExist"));
                }

            }
            else
            {
                MessageBox.Show(languageModel.getString("chooseDeviation"));
            }
        }

        //remind Group
        private void sendMessage_Click(object sender, EventArgs e)
        {
            LanguageModel languageModel = new LanguageModel();
            if (this.DeviationDataGridView.CurrentRow != null)
            {
                String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
                Deviation deviation = deviationModel.getDeviationWithRef(deviationRef);
                if (deviation != null)
                {
                    //send email to Groups that they did not yet approve
                    var result = this.emailSender.sentEmailToGroups(deviation);
                    if (result == "sent")
                    {                       
                        MessageBox.Show(languageModel.getString("emailSent"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(result);
                    }
                }else
                {                  
                    MessageBox.Show(languageModel.getString("deviationNotExist"));
                }

            }
        }

        //Show deviation double click
        private void DeviationDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LanguageModel languageModel = new LanguageModel();
            if (this.DeviationDataGridView.CurrentRow != null)
            {
                String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
                Deviation deviation = deviationModel.getDeviationWithRef(deviationRef);
                //The user can update the deviation if signature attribut of the deviation has the user name
                if (deviation != null)
                {
                    //show Deviation
                    SaveDeviation saveDeviation = new SaveDeviation("showDeviation", null, this);
                    saveDeviation.showDeviation(deviation);
                }
                else
                {
                    MessageBox.Show(languageModel.getString("deviationNotExist"));
                }

            }
            else
            {
                MessageBox.Show(languageModel.getString("chooseDeviation"));
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var deviations = deviationModel.listApprovedDeviation(n + 1,m);
            if (this.choosenList == "green")
            {
                 deviations = deviationModel.listApprovedDeviation(n + 1, m);
            }
            else if (this.choosenList == "yellow")
            {
                deviations = deviationModel.listPendingDeviation(n + 1, m);
            }
            else if (this.choosenList == "red")
            {
                deviations = deviationModel.listRejectedDeviation(n + 1, m);
            }
            else if (this.choosenList == "gray")
            {
                deviations = deviationModel.listApprovedExpiredDeviation(n + 1, m);
            }


            if (deviations.Count == 0)
            {
                this.rightArrow.Enabled = false;
            }
            else
            {
                var source = new BindingSource();
                source.DataSource = deviations;
                this.DeviationDataGridView.DataSource = source;

                //increment n
                this.n = n + 1;

                //set Label for deviation number
                this.setLabelDeviationNumber();
            }
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            if (n > 1)
            {
                var deviations = deviationModel.listApprovedDeviation(n + 1, m);
                if (this.choosenList == "green")
                {
                    deviations = deviationModel.listApprovedDeviation(n + 1, m);
                }
                else if (this.choosenList == "yellow")
                {
                    deviations = deviationModel.listPendingDeviation(n + 1, m);
                }
                else if (this.choosenList == "red")
                {
                    deviations = deviationModel.listRejectedDeviation(n + 1, m);
                }
                else if (this.choosenList == "gray")
                {
                    deviations = deviationModel.listApprovedExpiredDeviation(n + 1, m);
                }

                if (deviations.Count == 0)
                {
                    this.leftArrow.Enabled = false;
                }
                else
                {
                    var source = new BindingSource();
                    source.DataSource = deviations;
                    this.DeviationDataGridView.DataSource = source;

                    //increment n
                    this.n = n - 1;

                    //set Label for deviation number
                    this.setLabelDeviationNumber();
                }
            }
        }

        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.Show();

        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void panel10_MouseClick(object sender, MouseEventArgs e)
        {
            //reset n and m
            this.n = 1;
            this.m = 200;
            this.choosenList = "gray";

            //change color
            this.DeviationDataGridView.Columns[9].DefaultCellStyle.ForeColor = Color.Gray;

            var deviations = deviationModel.listApprovedExpiredDeviation(n, m);
            var source = new BindingSource();
            source.DataSource = deviations;
            this.DeviationDataGridView.DataSource = source;

            this.setLabelDeviationNumber();
        }



        //___Class ______

    }
}
