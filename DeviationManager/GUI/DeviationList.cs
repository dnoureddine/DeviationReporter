using DeviationManager.Entity;
using DeviationManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviationManager.GUI
{
    public partial class DeviationList : Form
    {
        private DeviationModel deviationModel;
        private Autorisation autorisation;
        private EmailSender emailSender;
        private LanguageModel languageModel;

        private int n = 1;
        private int m = 200;

        public DeviationList()
        {
            InitializeComponent();

            deviationModel = new DeviationModel();
            autorisation = new Autorisation();
            emailSender = new EmailSender();
            languageModel = new LanguageModel();

            //DataGridViw Configuration
            this.DataViewConfiguration();

            //initilize 
            this.setLabelDeviationNumber();

            //init dates
            this.initdates();

            //show deviation list
            this.showDeviationList();

            //set  language
            if (LanguageName.languageName != "DeviationManager.Lang.language_en")
            {
                this.setLanguage();
            }

            this.DeviationDataGridView.Columns[9].DefaultCellStyle.ForeColor = Color.Blue;
        }


        //initialisation
        private void setLabelDeviationNumber()
        {
            long deviationNumb = deviationModel.getAllDeviationNumber();

            String label = "";
            if((n * m - m) == 0)
            {
                label = "1-";
            }else
            {
                label = (n * m - m) + "-";
            }

            //***
            if ((n * m) > deviationNumb)
            {
                label = label + (deviationNumb - (n * m - m));
            }else
            {
                label = label + (n * m);
            }

            label = label + " Von " + deviationNumb;

            this.listdeviationNumber.Text = label;

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

        //date initialisation
        private void initdates()
        {
            this.date1.Value = DateTime.Now;
            this.date2.Value = DateTime.Now;
        }

        //set the language
        private void setLanguage()
        {
            LanguageModel languageModel = new LanguageModel();

            this.lDeviationNO.Text = languageModel.getString("ldeviationNo");
            this.lRequestedBy.Text = languageModel.getString("lrequestedBy");
            this.lAnlage.Text = languageModel.getString("lmachine");
            this.lRiskCategory.Text = languageModel.getString("lriskCategory");
            this.lDeviationType.Text = languageModel.getString("ldeviationType");
            this.lProduct.Text = languageModel.getString("lproduct");
            this.lDate1.Text = languageModel.getString("ldate1");
            this.lDate2.Text = languageModel.getString("ldate2");
            this.lUseAllInputs.Text = languageModel.getString("luseAllInputs");
            this.lartabweichung.Text = languageModel.getString("lartabweichung");
            this.ldeviationFilterBox.Text = languageModel.getString("ldeviationFilterBox");

            this.deviationListUpdate.Text = languageModel.getString("lupdate");
            this.Filter.Text = languageModel.getString("lfilterDeviation");
            this.button1.Text = languageModel.getString("laddDeviation");
            this.button2.Text = languageModel.getString("leditDeviation");
            this.button3.Text = languageModel.getString("lcloseDeviation");
            this.showDeviation.Text = languageModel.getString("lshowDeviation");
            this.sendMessage.Text = languageModel.getString("lremindGroup");
        }

        //show Deviation List
        public  void showDeviationList()
        {
            var deviations = deviationModel.listDeviations(n,m);
            var source = new BindingSource();
            source.DataSource = deviations;
            this.DeviationDataGridView.DataSource = source;
        }

        //show deviations for one user
        public void showDeviationForOneUser(String username)
        {
            var deviations = deviationModel.filterDeviationByRequestedBy(username);
            var source = new BindingSource();
            source.DataSource = deviations;
            this.DeviationDataGridView.DataSource = source;

            this.Show();
        }

        //update  Deviation List
        private void updateDeviationList(IList<Deviation> listdeviations)
        {
            var source = new BindingSource();
            source.DataSource = listdeviations;
            this.DeviationDataGridView.DataSource = source;
        }

        //DataGridViw Configuration
        private void DataViewConfiguration()
        {
            //fill Datagridview
            this.DeviationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //DataGridView OnlyRead
            this.DeviationDataGridView.ReadOnly = true;

            //evit user to add new colums
            this.DeviationDataGridView.AllowUserToAddRows = false;
        }


        /*************************** Event **********************************************************************/
        private void addNewDeviation_Click(object sender, EventArgs e)
        {
            SaveDeviation saveDeviation = new SaveDeviation("newDeviation", this, null);
            saveDeviation.Show();
        }

        private void editDeviation_Click(object sender, EventArgs e)
        {
            String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
            Deviation deviation=autorisation.canUpdateDeviation(deviationRef);
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
                        SaveDeviation saveDeviation = new SaveDeviation("updateDeviation", this, null);
                        saveDeviation.updateDeviation(deviation);
                    }
                    else
                    {
                        MessageBox.Show(this.languageModel.getString("deviationAlreadyClosed"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else
            {
                MessageBox.Show(this.languageModel.getString("notAllowedToUpdateItem"), "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }


        //close Deviation
        private void closeDeviation_Click(object sender, EventArgs e)
        {
            if (this.DeviationDataGridView.CurrentRow != null)
            {
                String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
                if (deviationRef != "" || deviationRef != null)
                {
                    if (MessageBox.Show(this.languageModel.getString("alertCloseDeviation"), "Close Deviation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String result = deviationModel.closeDeviation(deviationRef);
                        if (result == "closed")
                        {
                            MessageBox.Show(this.languageModel.getString("deviationWasClosed"),"Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this.languageModel.getString("errorCloseDeviation"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
             
        }


        //Show Deviation
        private void showDeviation_Click(object sender, EventArgs e)
        {
            if (this.DeviationDataGridView.CurrentRow != null)
            {
                String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
                Deviation deviation = deviationModel.getDeviationWithRef(deviationRef);
               //The user can update the deviation if signature attribut of the deviation has the user name
                if (deviation != null)
                {
                    //show Deviation
                    SaveDeviation saveDeviation = new SaveDeviation("showDeviation", this, null);
                    saveDeviation.showDeviation(deviation);
                }
                else
                {
                    MessageBox.Show(this.languageModel.getString("deviationNotExist"));
                }

            }else
            {
                MessageBox.Show(this.languageModel.getString("chooseDeviation"));
            }
        }

        //search deviation using deviation ref
        private void deviationNO_TextChanged(object sender, EventArgs e)
        {
            if (this.likeSearch.Checked == false)
            {
                this.updateDeviationList(deviationModel.filterDeviationByRef(this.deviationNO.Text));
            }
        }

        //search deviation using requested by
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.likeSearch.Checked == false)
            {
                this.updateDeviationList(deviationModel.filterDeviationByRequestedBy(this.requestedBy.Text));
            }
        }

        //search deviation using rick category
        private void riskCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.likeSearch.Checked == false)
            {
                if (this.riskCategory.SelectedIndex != 0)
                {
                    this.updateDeviationList(deviationModel.filterDeviationByRiskCategory(this.riskCategory.SelectedItem.ToString()));
                }
                
            }
        }

        //search deviation using deviation type
        private void deviationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.likeSearch.Checked == false)
            {
                if (this.deviationType.SelectedIndex != 0)
                {
                    this.updateDeviationList(deviationModel.filterDeviationByDeviationType(this.deviationType.SelectedItem.ToString()));
                }
            }
        }

        //search deviation using all  properties
        private void Filter_Click(object sender, EventArgs e)
        {
           
            String deviationRef = this.deviationNO.Text;
            String requestedBy = this.requestedBy.Text;
            String deviationType = "";
            String deviationRiskCategory = "";
            String anlage = this.anlage.Text;
            String product = this.product.Text;
            DateTime date1 = this.date1.Value;
            DateTime date2 = this.date2.Value;

            if (this.riskCategory.SelectedItem != null)
            {
                deviationRiskCategory = this.riskCategory.SelectedItem.ToString();
            }
            if (this.deviationType.SelectedItem != null)
            {
                deviationType = this.deviationType.SelectedItem.ToString();
            }

            var deviations = deviationModel.filterDeviationByAll(deviationRef, requestedBy, deviationRiskCategory, deviationType, date1, date2,anlage,product);
            this.updateDeviationList(deviations);
        }


        //update deviations list
        private void deviationListUpdate_Click(object sender, EventArgs e)
        {
            //reset date1 and date2
            this.date1.Value = DateTime.Now;
            this.date2.Value = DateTime.Now;

            //update deviation list
            this.showDeviationList();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //searching by Anlage
        private void anlage_TextChanged(object sender, EventArgs e)
        {
            if (this.likeSearch.Checked == false)
            {
                this.updateDeviationList(deviationModel.filterDeviationByAnlage(this.anlage.Text));
            }
        }

        //searching by product
        private void product_TextChanged(object sender, EventArgs e)
        {
            if (this.likeSearch.Checked == false)
            {
                this.updateDeviationList(deviationModel.filterDeviationByPruduct(this.product.Text));
            }
        }


        //send email to groups who they 
        private void sendMessage_Click(object sender, EventArgs e)
        {
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
                        MessageBox.Show(this.languageModel.getString("emailSent"), "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }

        }

        //show deviation
        private void deviationAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.DeviationDataGridView.CurrentRow != null)
            {
                String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
                Deviation deviation = deviationModel.getDeviationWithRef(deviationRef);
                //The user can update the deviation if signature attribut of the deviation has the user name
                if (deviation != null)
                {
                    //show Deviation
                    SaveDeviation saveDeviation = new SaveDeviation("showDeviation", this, null);
                    saveDeviation.showDeviation(deviation);
                }
                else
                {
                    MessageBox.Show(this.languageModel.getString("deviationNotExist"));
                }

            }
            else
            {
                MessageBox.Show(this.languageModel.getString("chooseDeviation"));
            }
        }

        //edit deviation
        private void deviationÜberarbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                        SaveDeviation saveDeviation = new SaveDeviation("updateDeviation", this, null);
                        saveDeviation.updateDeviation(deviation);
                    }
                    else
                    {
                        MessageBox.Show(this.languageModel.getString("notAllowedToChange"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else
            {
                MessageBox.Show(this.languageModel.getString("notAllowedToUpdateItem"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //close deviation
        private void deviationSchliessenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.DeviationDataGridView.CurrentRow != null)
            {
                String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
                if (deviationRef != "" || deviationRef != null)
                {
                    if (MessageBox.Show(this.languageModel.getString("alertCloseDeviation"), "Close Deviation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String result = deviationModel.closeDeviation(deviationRef);
                        if (result == "closed")
                        {
                            MessageBox.Show(this.languageModel.getString("deviationWasClosed"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this.languageModel.getString("errorCloseDeviation"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        //remind group
        private void gruppeErinnernToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                        MessageBox.Show(this.languageModel.getString("emailSent"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        //right arrow
        private void rightArrow_Click(object sender, EventArgs e)
        {
            var deviations = deviationModel.listDeviations(n+1, m);
            if (deviations.Count == 0)
            {
                this.rightArrow.Enabled = false;
            }else
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

        //left arrow
        private void leftArrow_Click(object sender, EventArgs e)
        {
            if (n > 1)
            {
                var deviations = deviationModel.listDeviations(n - 1, m);
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

        //show deviation double click
        private void DeviationDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DeviationDataGridView.CurrentRow != null)
            {
                String deviationRef = this.DeviationDataGridView.CurrentRow.Cells[0].Value.ToString();
                Deviation deviation = deviationModel.getDeviationWithRef(deviationRef);
                //The user can update the deviation if signature attribut of the deviation has the user name
                if (deviation != null)
                {
                    //show Deviation
                    SaveDeviation saveDeviation = new SaveDeviation("showDeviation", this, null);
                    saveDeviation.showDeviation(deviation);
                }
                else
                {
                    MessageBox.Show(this.languageModel.getString("deviationNotExist"));
                }

            }
            else
            {
                MessageBox.Show(this.languageModel.getString("chooseDeviation"));
            }
        }

        /**___________class _____*****/

    }
}
