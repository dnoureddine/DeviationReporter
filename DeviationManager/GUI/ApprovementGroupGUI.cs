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
    public partial class ApprovementGroupGUI : Form
    {
        private DeviationModel deviationModel;

        public ApprovementGroupGUI()
        {
            InitializeComponent();

            deviationModel = new DeviationModel();

            //DataGridView Configuration
            this.DataViewConfiguration();

            //list approvement group
            this.showApprovementGroupList();
        }




        private void registerApprovementGroupe_Click(object sender, EventArgs e)
        {
            LanguageModel languageModel = new LanguageModel();
            if (this.isValidateFrom())
            {
                if (this.idGroupeApprovement.Text != "")
                {
                    //update Approment Group
                    int id = int.Parse(this.idGroupeApprovement.Text);
                    ApprovementGroup approvementGr = deviationModel.getApprovementGroup(id);

                    approvementGr.liblle = this.liblle.Text;
                    approvementGr.role = this.role.Text;
                    approvementGr.groupEmail = this.groupEmail.Text;

                    deviationModel.updateApprovementGroup(approvementGr);

                    MessageBox.Show(languageModel.getString("approvementUpdated"));

                    //reload the Approvement group list
                    this.showApprovementGroupList();
                }
                else
                {
                    //add new approvement Group
                    ApprovementGroup approvementGroup = new ApprovementGroup();
                    approvementGroup.liblle = this.liblle.Text;
                    approvementGroup.role = this.role.Text;
                    approvementGroup.groupEmail = this.groupEmail.Text;
                    deviationModel.addApprovementGroup(approvementGroup);

                    MessageBox.Show(languageModel.getString("approvementAdded"));

                    //reload the Approvement group list
                    this.showApprovementGroupList();
                }
            }
        }


        private void addNewApprovementGroup_Click(object sender, EventArgs e)
        {
            this.idGroupeApprovement.Text = "";
            this.liblle.Text = "";
            this.role.Text = "";
            this.groupEmail.Text = "";
        }

        private void approvementGroupsDataGridview_SelectionChanged(object sender, EventArgs e)
        {
            this.idGroupeApprovement.Text = this.approvementGroupsDataGridview.CurrentRow.Cells[0].Value.ToString();
            this.liblle.Text = this.approvementGroupsDataGridview.CurrentRow.Cells[1].Value.ToString();
            this.role.Text = this.approvementGroupsDataGridview.CurrentRow.Cells[2].Value.ToString();
            this.groupEmail.Text = this.approvementGroupsDataGridview.CurrentRow.Cells[3].Value.ToString();
        }

        private void deleteApprovementGroup_Click(object sender, EventArgs e)
        {
            LanguageModel languageModel = new LanguageModel(); 
            if (MessageBox.Show(languageModel.getString("alertDeleteApprovementGroup"), "?", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {

                if (this.idGroupeApprovement.Text != "")
                {
                    deviationModel.deleteApprovementGroup(Int32.Parse(this.idGroupeApprovement.Text));
                    MessageBox.Show(languageModel.getString("itemDeleted"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //reload the Approvement group list
                    this.showApprovementGroupList();
                }
                else
                {
                    MessageBox.Show(languageModel.getString("itemDeleteError"), "Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        /*****************************************************************************************************/

        //form validation
        private bool isValidateFrom()
        {
            LanguageModel languageModel = new LanguageModel();
            if (this.liblle.Text =="" || this.role.Text =="")
            {
                MessageBox.Show(languageModel.getString("invalidForm"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }


        //show Approvement group list
        private void showApprovementGroupList()
        {
            var approvementGroups = deviationModel.listApprovementGroup();

            var source = new BindingSource();
            source.DataSource = approvementGroups;
            this.approvementGroupsDataGridview.DataSource = source;
        }

       
        //DataGridViw Configuration
        private void DataViewConfiguration()
        {
            //fill Datagridview
            this.approvementGroupsDataGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //DataGridView OnlyRead
            this.approvementGroupsDataGridview.ReadOnly = true;

            //evit user to add new colums
            this.approvementGroupsDataGridview.AllowUserToAddRows = false;
        }

        

       

        /******____class *******/
    }
}
