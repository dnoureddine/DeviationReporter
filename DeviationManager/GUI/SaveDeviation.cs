using DeviationManager.Entity;
using DeviationManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.IO;

namespace DeviationManager.GUI
{
    public partial class SaveDeviation : Form
    {
        private DeviationModel deviationModel;
        private String actionType;
        private Deviation deviation=null;
        private EmailSender emailSender;
        private DeviationList deviationList = null;
        private PrincipalWin principalWin = null;
        private LanguageModel languageModel;

        public SaveDeviation(String actionType, DeviationList deviationList, PrincipalWin principalWin)
        {
            InitializeComponent();
            deviationModel = new DeviationModel();
            emailSender = new EmailSender();
            languageModel = new LanguageModel();

            this.actionType = actionType;

            this.deviationList = deviationList;
            this.principalWin = principalWin;

            //set  language
            if (LanguageName.languageName != "DeviationManager.Lang.language_en")
            {
                this.setLanguage();
            }

            initialize();

            if (actionType == "newDeviation")
            {
                addApproval();
                setSignature();
                
                //approvement Table readonly
                this.approvementGroupDataGrid.ReadOnly = true;
                this.approvementGroupDataGrid.ForeColor = Color.Gray;
                
            }
            else
            {

                this.approvementLightMSG.Text = this.languageModel.getString("lapprovementLightGreenMsg");
                this.approvementLightMSG.ForeColor = Color.Green;
            }
        }


        //update deviation list on Principal and Deviationlist windows
        public void updateDeviationList()
        {
            if (this.deviationList != null)
            {
                this.deviationList.showDeviationList();
            }

            if (this.principalWin != null)
            {
                this.principalWin.updateDeviationList();
            }
        }

        /**************************************************************************************/

        //set language
        private void setLanguage()
        {
            
            this.laddNewDeviation.Text = languageModel.getString("laddNewDeviation");

            this.lDeviationInfo.Text = languageModel.getString("lDeviationInfo");
            this.ldeviationNo.Text = languageModel.getString("ldeviationNo");
            this.lrequestedBy.Text = languageModel.getString("lrequestedBy");
            this.lrisckCategroy.Text = languageModel.getString("lriskCategory");
            this.ldateCreation.Text = languageModel.getString("ldateCreation");
            this.lposition.Text = languageModel.getString("lposition");
            this.ldeviationType.Text = languageModel.getString("ldeviationType");
            this.ldescription.Text = languageModel.getString("ldescription");
            this.lothers.Text = languageModel.getString("");
            this.lsignature.Text = languageModel.getString("lsignature");
            this.lartabweichung.Text = languageModel.getString("lartabweichung");
            this.loptional.Text = "";

            this.ldetailDescOfDev.Text = languageModel.getString("ldetailDescOfDev"); 
            this.lstandardCondition.Text = languageModel.getString("lstandardCondition");
            this.ldetailRequestCondition.Text = languageModel.getString("ldetailRequestCondition");
            this.lmachine.Text = languageModel.getString("lmachine");
            this.lproduct.Text = languageModel.getString("lproduct");

            this.lwhyBox.Text = languageModel.getString("lwhyBox");
            this.lwhy1.Text = languageModel.getString("lwhy");
            this.lwhy2.Text = languageModel.getString("lwhy");
            this.lwhy3.Text = languageModel.getString("lwhy");
            this.lwhy4.Text = languageModel.getString("lwhy");
            this.lwhy5.Text = languageModel.getString("lwhy");

            this.lperiodDevation.Text = languageModel.getString("lperiodDevation");
            this.lperiodBegin.Text = languageModel.getString("lperiodBegin");
            this.lperiodEnd.Text = languageModel.getString("lperiodEnd");
            this.addDocument.Text = languageModel.getString("ladd");
            this.deleteDocument.Text = languageModel.getString("ldelete");
            //show digramms
            this.button1.Text = languageModel.getString("lshow");
            this.lAlternativeIdMethod.Text = languageModel.getString("lalternativeIdMethod");

            this.lapprovement.Text = languageModel.getString("lapprovement");
            this.lothers.Text = languageModel.getString("lothers");

            this.DeviationSave.Text = languageModel.getString("lsave");
            this.closeDeviation.Text = languageModel.getString("lclose");
            this.DeviationPrint.Text = languageModel.getString("lprint");
            this.button4.Text = languageModel.getString("lremindGroup");

            this.lOtherBox1.Text = languageModel.getString("lothersBox1");
            this.lOtherBox2.Text = languageModel.getString("lothersBox2");
            this.lOtherBox3.Text = languageModel.getString("lothersBox3");
            this.lOtherBox4.Text = languageModel.getString("lothersBox4");

            this.ldateb1.Text = languageModel.getString("ldate");
            this.lRequestedApprovedb1.Text = languageModel.getString("lrequestApproved");
            this.lRequestRejectedb1.Text = languageModel.getString("lrequestedRejected");
            this.lNameb1.Text = languageModel.getString("lname");
            this.lSigantureb1.Text = languageModel.getString("lsignature");
            this.lPositionb1.Text = languageModel.getString("lposition");

            this.lDateb2.Text = languageModel.getString("ldate");
            this.lRequestedApprovedb2.Text = languageModel.getString("lrequestApproved");
            this.lRequestRejectedb2.Text = languageModel.getString("lrequestedRejected");
            this.lNameb2.Text = languageModel.getString("lname");
            this.lSignatureb2.Text = languageModel.getString("lsignature");
            this.lPositionb2.Text = languageModel.getString("lposition");

            this.lDateb3.Text = languageModel.getString("ldate");
            this.lRequestApprovedb3.Text = languageModel.getString("lrequestApproved");
            this.lRequestRejectedb3.Text = languageModel.getString("lrequestedRejected");
            this.lNameb3.Text = languageModel.getString("lname");
            this.lSignatureb3.Text = languageModel.getString("lsignature");
            this.lPositionb3.Text = languageModel.getString("lposition");

            this.lDateb4.Text = languageModel.getString("ldate");
            this.lRequestApprovedb4.Text = languageModel.getString("lrequestApproved");
            this.lRequestRejected4.Text = languageModel.getString("lrequestedRejected");
            this.lNameb4.Text = languageModel.getString("lname");
            this.lSignatureb4.Text = languageModel.getString("lsignature");
            this.lPositionb4.Text = languageModel.getString("lposition");

            if (actionType == "newDeviation")
            {
                this.approvementLightMSG.Text = this.languageModel.getString("lapprovementLightRedMsg");
                this.approvementLightMSG.ForeColor = Color.Red;
            }
            
        }
        /************* add Approval to Approvement Group **********/

        public void addApproval()
        {
            var approvementGroups = deviationModel.listApprovementGroup();
            foreach (var approvementGroup in approvementGroups)
            {
                this.approvementGroupDataGrid.Rows.Add(approvementGroup.approvalId,approvementGroup.liblle);
            }

            this.approvementGroupDataGrid.AllowUserToAddRows = false;

            /******** set deviation Number *****/
            this.deviationNO.Text = deviationModel.getDeviationNumber();
            this.deviationNO.Enabled = false;
        }


        /******* get user name to set siganture  and make signature field uneditable  ****/
        public void setSignature()
        {
            this.deviationSignature.Text = deviationModel.getUserNameFromActiveDirectory();
            this.deviationSignature.Enabled = false;

            String username = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName;
            this.requestedBy.Text = username;
        }


        /*******   get Other Approvement to print ****/
        public IList<OtherApprovement> getOtherApprovementToPrint(){

            OtherApprovement regionalQuality = new OtherApprovement
            {
                title = "REGIONAL QUALITY DIRECTOR APPROVAL:  REFER TO FTDS-BM-P-008  FOR REQUIREMENT",
                selectYesNo = this.yesNoReginal.Text,
                date=this.dateRegional.Value,
                positionApproval= this.positionRegional.Text,
                nameApproval=this.nameReginal.Text,
                signatureApproval=this.signatureRegional.Text,
                requestApproved=this.requestApprovedRegional.Checked,
                requestRejected=this.requestRejectedRegional.Checked
            };

            OtherApprovement productEng = new OtherApprovement
            {
                title = "PRODUCT ENGINEERING APPROVAL:  REFER TO FTDS-BM-P-008  FOR REQUIREMENT",
                selectYesNo = this.yesNoProductEng.Text,
                date = this.dateProductEng.Value,
                positionApproval = this.positionProductEng.Text,
                nameApproval = this.nameProductEng.Text,
                signatureApproval = this.signatureProductEng.Text,
                requestApproved = this.requestApprovedProductEng.Checked,
                requestRejected = this.requestRejectedProductEng.Checked
            };

            OtherApprovement ManufactEng = new OtherApprovement
            {
                title = "MANUFACTURING ENGINEERING APPROVAL:  REFER TO FTDS-BM-P-008  FOR REQUIREMENT",
                selectYesNo = this.yesNoManufactEng.Text,
                date = this.dateManufactEng.Value,
                positionApproval = this.positionManufactEng.Text,
                nameApproval = this.nameManufactEng.Text,
                signatureApproval = this.signatureManufactEng.Text,
                requestApproved = this.requestedApprovedManufactEng.Checked,
                requestRejected = this.requestRejectedManufactEng.Checked
            };

            OtherApprovement customer = new OtherApprovement
            {
                title = "CUSTOMER APPROVAL:  REFER TO FTDS-BM-P-008  FOR REQUIREMENT",
                selectYesNo = this.yesNoCustomer.Text,
                date = this.dateCustomer.Value,
                positionApproval = this.positionCustomer.Text,
                nameApproval = this.nameCustomer.Text,
                signatureApproval = this.signatureCustomer.Text,
                requestApproved = this.requestApprovedCustomer.Checked,
                requestRejected = this.requestRejectedCustomer.Checked
            };

            List<OtherApprovement> listOtherApprovement = new List<OtherApprovement>();
            listOtherApprovement.Add(regionalQuality);
            listOtherApprovement.Add(productEng);
            listOtherApprovement.Add(ManufactEng);
            listOtherApprovement.Add(customer);

            return listOtherApprovement;
        }


        //create a Deviation object from Form inputs
        private Deviation getDeviationObject()
        {
            Deviation deviation = new Deviation();

            deviation.deviationRef = this.deviationNO.Text;
            deviation.deviationRiskCategory = this.riskCategory.Text;
            deviation.requestedBy = this.requestedBy.Text;
            deviation.position = this.position.Text;
            deviation.deviationType = this.deviationType.SelectedItem.ToString();
            deviation.describeOtherType = this.deviationDescription.Text;
            deviation.signature = this.deviationSignature.Text;
            deviation.detailStandardCondition = this.standardCondition.Text;
            deviation.detailRequestCondition = this.detailRequestedDeviation.Text;
            deviation.barcode = this.barcode.Text;
            deviation.anlage = this.anlage.Text;
            deviation.product = this.product.Text;
            if (this.actionType == "newDeviation")
            {
                deviation.status = "Pending";
            }

            DateTime deviationDateCreation = this.deviationDateCreation.Value;
            DateTime deviationTimeCreation = this.deviationTimeCreation.Value;
            deviation.dateCreation = new DateTime(deviationDateCreation.Year, deviationDateCreation.Month, deviationDateCreation.Day, deviationTimeCreation.Hour, deviationTimeCreation.Minute, deviationTimeCreation.Second);

            DateTime pFirstDate = this.pFirstDate.Value;
            DateTime pFirstTime = this.pFirstTime.Value;
            deviation.startDatePeriod = new DateTime(pFirstDate.Year, pFirstDate.Month, pFirstDate.Day, pFirstTime.Hour, pFirstTime.Minute, pFirstTime.Second);

            DateTime pSecondDate = this.pSecondDate.Value;
            DateTime pSecondTime = this.pSecondTime.Value;
            deviation.endDatePeriod = new DateTime(pSecondDate.Year, pSecondDate.Month, pSecondDate.Day, pSecondTime.Hour, pSecondTime.Minute, pSecondTime.Second);

            

            //add Reasons
            IList<Reason> listReasons = new List<Reason>();
            Reason reas1 = new Reason { reason = this.reason1.Text };
            Reason reas2 = new Reason { reason = this.reason2.Text };
            Reason reas3 = new Reason { reason = this.reason3.Text };
            Reason reas4 = new Reason { reason = this.reason4.Text };
            Reason reas5 = new Reason { reason = this.reason5.Text };
            listReasons.Add(reas1); listReasons.Add(reas2); listReasons.Add(reas3);
            listReasons.Add(reas4); listReasons.Add(reas5);
            deviation.reasons = listReasons;


            //add Approvement Groups
            IList<Approvement> listApprovements = new List<Approvement>();
            foreach (DataGridViewRow row in this.approvementGroupDataGrid.Rows)
            {
                int approvementGroupId =(int)row.Cells[0].Value;
                if (approvementGroupId != 0)
                {
                    ApprovementGroup approvementGroup = deviationModel.getApprovementGroup(approvementGroupId);
                    if (approvementGroup != null)
                    {
                        Approvement approvement = new Approvement();
                        approvement.approvementGroup = approvementGroup;
                        listApprovements.Add(approvement);
                    }
                }
            }

            deviation.approvements = listApprovements;


            //Add Attachments
            IList<Attachments> listAttachments = new List<Attachments>();
            foreach (DataGridViewRow  row in this.uploadFileDataGridView.Rows)
            {
                Attachments attachement = new Attachments();
                attachement.fileName = row.Cells[0].Value.ToString();
                attachement.fileNameDb = row.Cells[1].Value.ToString();
                attachement.date = DateTime.Now;
                if (row.Cells[3].Value != null)
                {
                    attachement.liblle = row.Cells[3].Value.ToString();
                }
                
                listAttachments.Add(attachement);
            }

            deviation.attachements = listAttachments;
                

            return deviation;
        }

        //update deviation object
        private Deviation getDeviationObjectToUpdate()
        {
            if (this.deviation != null)
            {
                deviation.deviationRef = this.deviationNO.Text;
                deviation.deviationRiskCategory = this.riskCategory.Text;
                deviation.requestedBy = this.requestedBy.Text;
                deviation.position = this.position.Text;
                deviation.describeOtherType = this.deviationDescription.Text;
                deviation.signature = this.deviationSignature.Text;
                deviation.detailStandardCondition = this.standardCondition.Text;
                deviation.detailRequestCondition = this.detailRequestedDeviation.Text;
                deviation.barcode = this.barcode.Text;
                deviation.anlage = this.anlage.Text;
                deviation.product = this.product.Text;
                if (this.actionType == "newDeviation")
                {
                    deviation.status = "Pending";
                }

                if(this.deviationType.SelectedItem != null)
                {
                    deviation.deviationType = this.deviationType.SelectedItem.ToString();
                }

                DateTime deviationDateCreation = this.deviationDateCreation.Value;
                DateTime deviationTimeCreation = this.deviationTimeCreation.Value;
                deviation.dateCreation = new DateTime(deviationDateCreation.Year, deviationDateCreation.Month, deviationDateCreation.Day, deviationTimeCreation.Hour, deviationTimeCreation.Minute, deviationTimeCreation.Second);

                DateTime pFirstDate = this.pFirstDate.Value;
                DateTime pFirstTime = this.pFirstTime.Value;
                deviation.startDatePeriod = new DateTime(pFirstDate.Year, pFirstDate.Month, pFirstDate.Day, pFirstTime.Hour, pFirstTime.Minute, pFirstTime.Second);

                DateTime pSecondDate = this.pSecondDate.Value;
                DateTime pSecondTime = this.pSecondTime.Value;
                deviation.endDatePeriod = new DateTime(pSecondDate.Year, pSecondDate.Month, pSecondDate.Day, pSecondTime.Hour, pSecondTime.Minute, pSecondTime.Second);



                //add Reasons
                IList<Reason> listReasons = new List<Reason>();
                Reason reas1 = new Reason { reason = this.reason1.Text };
                Reason reas2 = new Reason { reason = this.reason2.Text };
                Reason reas3 = new Reason { reason = this.reason3.Text };
                Reason reas4 = new Reason { reason = this.reason4.Text };
                Reason reas5 = new Reason { reason = this.reason5.Text };
                listReasons.Add(reas1); listReasons.Add(reas2); listReasons.Add(reas3);
                listReasons.Add(reas4); listReasons.Add(reas5);
                deviation.reasons = listReasons;

            }

            return this.deviation;
        }

        //show form to update deviation
        public void updateDeviation(Deviation deviation)
        {
            this.deviationNO.Text = deviation.deviationRef;
            this.riskCategory.Text = deviation.deviationRiskCategory;           
            this.requestedBy.Text = deviation.requestedBy;
            this.deviationDateCreation.Value = (DateTime)deviation.dateCreation;
            this.deviationTimeCreation.Value = (DateTime)deviation.dateCreation;
            this.position.Text = deviation.position;
            this.deviationType.SelectedItem=deviation.deviationType;
            this.deviationSignature.Text=deviation.signature;
            this.standardCondition.Text=deviation.detailStandardCondition;
            this.detailRequestedDeviation.Text=deviation.detailRequestCondition;
            this.pFirstDate.Value = (DateTime)deviation.startDatePeriod;
            this.pFirstTime.Value = (DateTime) deviation.startDatePeriod;
            this.pSecondDate.Value=(DateTime)deviation.endDatePeriod;
            this.pSecondTime.Value = (DateTime)deviation.endDatePeriod; 
            this.deviationDescription.Text = deviation.describeOtherType;
            this.barcode.Text = deviation.barcode;
            this.anlage.Text = deviation.anlage;
            this.product.Text = deviation.product;


            //set Resons
            var reasons = deviation.reasons;
            this.reason1.Text = reasons.ElementAt<Reason>(0).reason;
            this.reason2.Text = reasons.ElementAt<Reason>(1).reason;
            this.reason3.Text = reasons.ElementAt<Reason>(2).reason;
            this.reason4.Text = reasons.ElementAt<Reason>(3).reason;
            this.reason5.Text = reasons.ElementAt<Reason>(4).reason;

            //set Attachments
            var attachements = deviation.attachements;
            foreach (var attachment in attachements)
            {
                this.uploadFileDataGridView.Rows.Add(attachment.fileName, attachment.fileNameDb, attachment.date.ToString(),attachment.liblle);
            }

            //set Approvement
            var approvements = deviation.approvements;
            foreach(var approvement in approvements){
                var approved = new CheckBox().Checked=approvement.approved;
                var rejected = new CheckBox().Checked=approvement.rejected;
                var signed = new CheckBox().Checked=approvement.signed;
                var date = "";
                if (approvement.date != null)
                {
                    date = approvement.date.Value.ToString();
                }

       
                this.approvementGroupDataGrid.Rows.Add(approvement.approvementId, approvement.approvementGroup.liblle, approvement.name, approved, rejected, signed, date,approvement.comment,this.languageModel.getString("lapprovementConfirm"));
            }


            this.deviation = deviation;
            this.deviationSignature.Enabled = false;
            this.deviationNO.Enabled = false;
            this.approvementGroupDataGrid.AllowUserToAddRows = false;
            this.Show();
        }


        //show deviation
        public void showDeviation(Deviation deviation){

            this.updateDeviation(deviation);

            this.deviationSignature.Enabled = false;
            this.deviationNO.Enabled = false;
            this.approvementGroupDataGrid.AllowUserToAddRows = false;
            this.addDocument.Enabled = false;
            this.deleteDocument.Enabled = false;
            this.DeviationSave.Enabled = false;
            this.closeDeviation.Enabled = false;
            this.deviation = deviation;

            this.Show();

        }
       
        //validate deviation period
        private int validateDeviationPeriod()
        {
            DateTime pFirstDate = this.pFirstDate.Value;
            DateTime pFirstTime = this.pFirstTime.Value;
            DateTime pFirstDateTime = new DateTime(pFirstDate.Year, pFirstDate.Month, pFirstDate.Day, pFirstTime.Hour, pFirstTime.Minute, pFirstTime.Second);

            DateTime pSecondDate = this.pSecondDate.Value;
            DateTime pSecondTime = this.pSecondTime.Value;
            DateTime pSecondDateTime =  new DateTime(pSecondDate.Year, pSecondDate.Month, pSecondDate.Day, pSecondTime.Hour, pSecondTime.Minute, pSecondTime.Second);

            return DateTime.Compare(pFirstDateTime, pSecondDateTime);
        }
        //Approvement validation
        private String validateApprovement(DataGridViewRow row){

            String isValid = languageModel.getString("valid");

            if (row.Cells[2].Value==null)
            {
                isValid = languageModel.getString("inValid"); 
            }
            DataGridViewCheckBoxCell approved = (DataGridViewCheckBoxCell)row.Cells[3];
            DataGridViewCheckBoxCell rejected = (DataGridViewCheckBoxCell)row.Cells[4];

            if (((bool)approved.Value != true) && ((bool)rejected.Value != true))
            {
                if (isValid == languageModel.getString("valid"))
                {
                    isValid = " " + languageModel.getString("alertApprovedRejected");
                }
                else
                {
                    isValid = isValid + " " + languageModel.getString("alertApprovedRejected");
                }
            }
            //make sure that approved and Rejected are not both checked
            if (((bool)approved.Value == false) && ((bool)rejected.Value == false))
            {
                isValid = languageModel.getString("alertDeviationValidation");
            }

            return isValid;
        }
        /***********************    Events  **************************************************************************/

        private void saveDeviation_Click(object sender, EventArgs e)
        {         
            FormValidation formValidation = new FormValidation();
            bool requestedBy = formValidation.isTextBoxNotNull(this.requestedBy, errorProvider1);
            bool reason1 = formValidation.isTextBoxNotNull(this.reason1, errorProvider1);
            bool reason2 = formValidation.isTextBoxNotNull(this.reason2, errorProvider1);
            bool position = formValidation.isTextBoxNotNull(this.position, errorProvider1);
            bool standardCondition = formValidation.isTextBoxNotNull(this.standardCondition, errorProvider1);
            bool detailRequestedDevV = formValidation.isTextBoxNotNull(this.detailRequestedDeviation, errorProvider1);
            bool deviationType = formValidation.istDeviationTypeChoosed(this.deviationType, errorProvider1);
            bool product = formValidation.isTextBoxNotNull(this.product, errorProvider1);
            bool anlage = formValidation.isTextBoxNotNull(this.anlage, errorProvider1);
            int compareDeviationPeriod = this.validateDeviationPeriod();

            bool deviationTypeDescription = true;

            
            if(this.deviationType.SelectedItem != null)
            {
                if (this.deviationType.SelectedItem.ToString() == languageModel.getString("misc"))
                {
                    if (this.deviationDescription.Text == "")
                    {
                        deviationTypeDescription = formValidation.isTextBoxNotNull(this.deviationDescription, errorProvider1);
                    }
                }
            }
            

            if (anlage && product && reason1 && reason2 && requestedBy && position && standardCondition && detailRequestedDevV && deviationType && compareDeviationPeriod != 0 && compareDeviationPeriod < 0)
            {
                Deviation deviation = this.getDeviationObject();
                if (this.actionType == "newDeviation")
                {
                  
                    //add a new Deviation
                    //verify if the user is one of the Group
                    //redirect the user to se the email content
                    EmailGUI emailGUI = new EmailGUI(deviation, this);
                    emailGUI.Show();
                }
                else
                {
                    //update DEVIATION
                    // before updating verify the Autorisation
                    if (this.deviation != null)
                    {
                        deviationModel.updateDeviation(this.getDeviationObjectToUpdate());
                        MessageBox.Show(this.languageModel.getString("deviationupdated"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                
                    }
               
                }
                
            }
            else
            {
                MessageBox.Show(this.languageModel.getString("formInputsNotValid"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (compareDeviationPeriod == 0)
                {
                    MessageBox.Show(this.languageModel.getString("deviationPeriodNull"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (compareDeviationPeriod > 0)
                {
                    MessageBox.Show(this.languageModel.getString("deviationNegativePeriod"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //initialize form
        private void initialize()
        {
            this.yesNoReginal.SelectedIndex = 1;
            this.yesNoProductEng.SelectedIndex = 1;
            this.yesNoManufactEng.SelectedIndex = 1;
            this.yesNoCustomer.SelectedIndex = 1;
            this.deviationType.SelectedIndex = 0;
            this.deviationType.Items[0] = this.languageModel.getString("lselectItem");

            //language
            Assembly a = Assembly.Load("DeviationManager");
            ResourceManager rm = new ResourceManager("DeviationManager.Lang.language_en", a);

        }

        //***__ __***
        private void requestedBy_GotFocus(object sender, EventArgs e)
        {

            this.errorProvider1.SetError(this.requestedBy, "");
        }

        private void position_GotFocus(object sender, EventArgs e)
        {

            this.errorProvider1.SetError(this.position, "");
        }

        private void reason1_GotFocus(object sender, EventArgs e)
        {

            this.errorProvider1.SetError(this.reason1, "");
        }


        private void standardCondition_GotFocus(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.standardCondition, "");
        }

        private void detailRequestedDeviation_GotFocus(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.detailRequestedDeviation, "");
        }

        private void deviationType_SelectedValueChanged(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.deviationType, "");
        }

        //Close Deviation
        private void closeDeviation_Click(object sender, EventArgs e)
        {
            String deviationRef = this.deviationNO.Text;
            if (deviationRef != "" || deviationRef != null)
            {
                if (MessageBox.Show(this.languageModel.getString("alertCloseDeviation"), this.languageModel.getString("lcloseDeviation"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (deviationModel.closeDeviation(deviationRef) == null)
                    {
                        MessageBox.Show(this.languageModel.getString("deviationNotExist"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        //Add diagrams 
        private void addDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                String fileName = fileDialog.SafeFileName;
                String filePath = fileDialog.FileName;

                this.uploadFileDataGridView.Rows.Add(fileName, filePath, DateTime.Now.ToString());
                   
            } 
        }

        //private void downloadDocument_Click(object sender, EventArgs e)
        //{
           
        //    if (this.uploadFileDataGridView.CurrentRow != null)
        //    {
        //        FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
        //        folderBrowser.Description="Choose A Directory To Save You File";

        //        if (folderBrowser.ShowDialog() == DialogResult.OK)
        //        {
        //            String saveDirectory = folderBrowser.SelectedPath;
        //            String fileSave = this.uploadFileDataGridView.CurrentRow.Cells[1].Value.ToString();
        //            UploadFile uploadFile = new UploadFile("u288026726", "alter6+");

        //            String result = uploadFile.DownloadFileFTP("ftp://31.170.165.123/" + fileSave, saveDirectory+"/"+fileSave);
        //            if (result == "downloaded")
        //            {
        //                MessageBox.Show("File Downloaded !", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                //show the file 
        //                Process.Start(saveDirectory + "/" + fileSave);
        //            }
        //            else
        //            {
        //                MessageBox.Show(result, "Infos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }

        //    }
        //}

        //show diagramms of deviation in other Win
        private void button1_Click(object sender, EventArgs e)
        {
           
            ShowDiagramms showDiagramm = new ShowDiagramms(this.uploadFileDataGridView);
            showDiagramm.Show();
        }

        //delete An Attachement
        private void deleteDocument_Click(object sender, EventArgs e)
        {
            if (this.uploadFileDataGridView.CurrentRow != null)
            {
                if (MessageBox.Show(this.languageModel.getString("alertDeleteAttachment"), this.languageModel.getString("deleteDeviation"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String filePath = this.uploadFileDataGridView.CurrentRow.Cells[1].Value.ToString();

                    //delete File in DB
                    deviationModel.deleteAttachment(filePath);

                    //remove from DataGridView
                    this.uploadFileDataGridView.Rows.RemoveAt(this.uploadFileDataGridView.CurrentRow.Index);

                    MessageBox.Show(this.languageModel.getString("fileRemovedFromList"));


                }

            }
        }


        //make the approvement
        private void approvementGroupDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (this.actionType == "newDeviation")
            {
                MessageBox.Show(this.languageModel.getString("alertSaveDeviationFirst"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (e.ColumnIndex == 8)
                {
                    //Get The Approvement ID
                    var approvementID = (int)this.approvementGroupDataGrid.Rows[e.RowIndex].Cells[0].Value;
                    String approvementValidation = this.validateApprovement((DataGridViewRow)this.approvementGroupDataGrid.Rows[e.RowIndex]);
                    if (approvementValidation == this.languageModel.getString("valid"))
                    {
                        //make Sure that the user has the Right to set Approvement
                        Autorisation aut = new Autorisation();
                        String toApprove = aut.cannApprove(approvementID);
                        if (toApprove == "canApprove")
                        {
                            //make the Approvement
                            Approvement approvement = deviationModel.getApprovement(approvementID);
                            if (approvement != null) {
                                approvement.name = this.approvementGroupDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                                approvement.approved = (bool)this.approvementGroupDataGrid.Rows[e.RowIndex].Cells[3].Value;
                                approvement.rejected = (bool)this.approvementGroupDataGrid.Rows[e.RowIndex].Cells[4].Value;
                                approvement.signed = (bool)this.approvementGroupDataGrid.Rows[e.RowIndex].Cells[5].Value;
                                approvement.date = DateTime.Now;
                                if (this.approvementGroupDataGrid.Rows[e.RowIndex].Cells[7].Value != null)
                                {
                                    approvement.comment = this.approvementGroupDataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                                }

                                deviationModel.updateApprovement(approvement);
                                MessageBox.Show(this.languageModel.getString("approvementDone"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show(this.languageModel.getString("actionFailed") + ". " + toApprove, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this.languageModel.getString("inputsRequired") + "." + approvementValidation, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                //__ok for approvement
                DataGridViewRow row = (DataGridViewRow)this.approvementGroupDataGrid.Rows[e.RowIndex];

                DataGridViewCheckBoxCell approved = (DataGridViewCheckBoxCell)row.Cells[3];
                DataGridViewCheckBoxCell rejected = (DataGridViewCheckBoxCell)row.Cells[4];

                if (e.ColumnIndex == 3)
                {
                    if (((bool)approved.Value == false) && ((bool)rejected.Value == true))
                    {
                        MessageBox.Show(this.languageModel.getString("alertApprovedRejected"));

                        //interupt checking approved checkbox
                        this.approvementGroupDataGrid.CancelEdit();
                    }
              
                }

                if (e.ColumnIndex == 4)
                {
                    if (((bool)approved.Value == true) && ((bool)rejected.Value == false))
                    {
                        MessageBox.Show(this.languageModel.getString("alertApprovedRejected"));

                        //interupt checking approved checkbox
                        this.approvementGroupDataGrid.CancelEdit();
                    }

                }

                if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
                {
                   if (((bool)approved.Value == false) && ((bool)rejected.Value == false))
                    {
                        //set Username
                        if (actionType != "newDeviation")
                        {
                            String userWinName = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName;
                            this.approvementGroupDataGrid.Rows[e.RowIndex].Cells[2].Value = userWinName;
                        }

                    }

                }

            }
           
        }


        //Print Deviation
        private void DeviationPrint_Click(object sender, EventArgs e)
        {
            if (this.actionType == "newDeviation")
            {
                MessageBox.Show(this.languageModel.getString("alertSaveDeviationFirst"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                folderBrowser.Description = this.languageModel.getString("saveFileDialog");

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    var pdfGenerator = new PDFDeviationGenerator(25, 25, 45, 45);
                    String filePath = folderBrowser.SelectedPath;
                    IList<OtherApprovement> otherApprovements = this.getOtherApprovementToPrint();
                    String fileSave = pdfGenerator.createPdfDeviation(this.deviation, otherApprovements, filePath);

                    Process.Start(fileSave);

                }
            }
        }

        // choose risk category 
        private void riskCategory_Click(object sender, EventArgs e)
        {
            RiskMatrix riskMatrix = new RiskMatrix(this.riskCategory);
            riskMatrix.ShowDialog();
            riskCategory.Focus();
        }


        //Remind Groups
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (this.actionType == "newDeviation")
            {
                MessageBox.Show(this.languageModel.getString("alertSaveDeviationFirst"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Deviation deviation = deviationModel.getDeviationWithRef(this.deviationNO.Text);
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

        //if  the type of deviation is Sontiges, mqke sure that Description is not  null
        private void deviationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.deviationType.SelectedItem.ToString() == this.languageModel.getString("misc")) {
                this.deviationDescription.BackColor = Color.Red;
                this.deviationDescription.Focus();
            }else
            {
                this.deviationDescription.BackColor = Color.White;
                this.standardCondition.Focus();
            }

        }

        private void deviationDescription_TextChanged(object sender, EventArgs e)
        {
            if(this.deviationDescription.Text == "")
            {
                this.deviationDescription.BackColor = Color.Red;
            }
            else
            {
                this.deviationDescription.BackColor = Color.White;
            }
        }

        //open File double click
        private void uploadFileDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.uploadFileDataGridView.CurrentRow != null)
            {
                String filePath = this.uploadFileDataGridView.CurrentRow.Cells[1].Value.ToString();
                if (File.Exists(filePath))
                {

                    try
                    {
                        Process.Start(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }else
                {
                    MessageBox.Show(this.languageModel.getString("fileNotExist"));
                }

            }
            else
            {
                MessageBox.Show(this.languageModel.getString("selectLine"));
            }
        }

        private void btn_BigEq_Click(object sender, EventArgs e)
        {
            if (this.standardCondition.Enabled == true)
            {
                this.standardCondition.Text += " ≥ ";
                this.standardCondition.Focus();
                this.standardCondition.SelectionStart = this.standardCondition.Text.Length;
            }
        }

        private void btn_PlusMinus_Click(object sender, EventArgs e)
        {
            if (this.standardCondition.Enabled == true)
            {
                this.standardCondition.Text += " ± ";
                this.standardCondition.Focus();
                this.standardCondition.SelectionStart = this.standardCondition.Text.Length;
            }
        }

        private void btn_Average_Click(object sender, EventArgs e)
        {
            if (this.standardCondition.Enabled == true)
            {
                this.standardCondition.Text += " Ø ";
                this.standardCondition.Focus();
                this.standardCondition.SelectionStart = this.standardCondition.Text.Length;
            }
        }

        private void btn_LeEq_Click(object sender, EventArgs e)
        {
            if (this.standardCondition.Enabled == true)
            {
                this.standardCondition.Text += " ≤ ";
                this.standardCondition.Focus();
                this.standardCondition.SelectionStart = this.standardCondition.Text.Length;
            }
        }

        private void btn_PlusMinus_DetailRequestCondition_Click(object sender, EventArgs e)
        {
            if (this.detailRequestedDeviation.Enabled == true)
            {
                this.detailRequestedDeviation.Text += " ± ";
                this.detailRequestedDeviation.Focus();
                this.detailRequestedDeviation.SelectionStart = this.detailRequestedDeviation.Text.Length;
            }
        }

        private void btn_Average_DetailRequestCondition_Click(object sender, EventArgs e)
        {
            if (this.detailRequestedDeviation.Enabled == true)
            {
                this.detailRequestedDeviation.Text += " Ø ";
                this.detailRequestedDeviation.Focus();
                this.detailRequestedDeviation.SelectionStart = this.detailRequestedDeviation.Text.Length;
            }
        }

        private void btn_BigEq_DetailRequestCondition_Click(object sender, EventArgs e)
        {
            if (this.detailRequestedDeviation.Enabled == true)
            {
                this.detailRequestedDeviation.Text += " ≥ ";
                this.detailRequestedDeviation.Focus();
                this.detailRequestedDeviation.SelectionStart = this.detailRequestedDeviation.Text.Length;
            }
        }

        private void btn_LeEq_DetailRequestCondition_Click(object sender, EventArgs e)
        {
            if (this.detailRequestedDeviation.Enabled == true)
            {
                this.detailRequestedDeviation.Text += " ≤ ";
                this.detailRequestedDeviation.Focus();
                this.detailRequestedDeviation.SelectionStart = this.detailRequestedDeviation.Text.Length;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             MessageBox.Show(this.languageModel.getString("lriskMatrixInfo"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void anlage_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.anlage, "");
        }

        private void product_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.product, "");
        }

        private void reason2_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.reason2, "");
        }




        /******_____class ***/

    }
}
