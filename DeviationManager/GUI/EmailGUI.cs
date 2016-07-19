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
    public partial class EmailGUI : Form
    {
        private Deviation deviation;
        private DeviationModel deviationModel;
        private SaveDeviation saveDeviation;
        private EmailSender emailSender;
        private LanguageModel languageModel;

        public EmailGUI(Deviation deviation, SaveDeviation saveDeviation)
        {
            InitializeComponent();
            this.deviation = deviation;
            this.saveDeviation = saveDeviation;
            this.deviationModel = new DeviationModel();
            emailSender = new EmailSender();
            languageModel = new LanguageModel();

            //generate email Content from deviation
            this.generateEmailContent();
        }


        //add deviation content to the email input
        private void generateEmailContent()
        {
            LanguageModel languageModel = new LanguageModel();
            String emailSubject = "";

            //generate email subject
            if (this.deviation.product !="")
            {
                emailSubject = languageModel.getString("emailSubjectNewDeviationProduct") + " " + this.deviation.product + " ";
            }

            if(this.deviation.anlage!="")
            {
                if (this.deviation.product != "")
                {
                    emailSubject = emailSubject + languageModel.getString("emailSubjectLine") + " " + this.deviation.anlage;
                }
                else
                {
                    emailSubject = languageModel.getString("emailSubjectNewDeviationLine") + " " + this.deviation.anlage;
                }
            }

            if (emailSubject == "")
            {
                emailSubject = languageModel.getString("lnewDeviation");
            }

            this.subject.AppendText(emailSubject);

            //generate the email body
            this.messageContent.AppendText("Sollvorgabe : \n\n");
            this.messageContent.AppendText(this.deviation.detailStandardCondition);

            this.messageContent.AppendText("\n\n\n");

            this.messageContent.AppendText("Istzustand : \n\n");
            this.messageContent.AppendText(this.deviation.detailRequestCondition);
        }
        

        /****************************** Event **************************************/
        private void sendMessage_Click(object sender, EventArgs e)
        {
            if (this.subject.Text != "" && this.messageContent.Text != "")
            {
                String result = this.emailSender.sendEmailToAllGroups(this.subject.Text, this.messageContent.Text);
                if (result == "sent")
                {
                    //Add the New deviation
                    this.deviationModel.addDeviation(this.deviation);

                    MessageBox.Show(this.languageModel.getString("deviationAdded"), "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.saveDeviation.Close();
                    this.Close();

                    //update deiation List on PrincipalWin or DeviationList forms
                    this.saveDeviation.updateDeviationList();
                }
                else
                {
                    MessageBox.Show(this.languageModel.getString("errorSendEmail"), "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show(this.languageModel.getString("inputsMissing"), "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void cancelSendEmail_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /*****_____class ****/
    }
}
