using DeviationManager.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace DeviationManager.Model
{
    public class EmailSender
    {

        private DeviationModel deviationModel;


        public EmailSender()
        {
            deviationModel = new DeviationModel();
        }



        private String sendEmail(String subject, String body, String[] receivers)
        {
            LanguageModel languageModel = new LanguageModel();
            try
            {
                //if Outlook is not open start it and wait
                Process[] pName = Process.GetProcessesByName("OUTLOOK");
                if (pName.Length == 0)
                {
                    // Open Outlook anew.
                    System.Diagnostics.Process.Start("OUTLOOK.EXE");
                    System.Threading.Thread.Sleep(2000);
                }

                //****
                Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
                Microsoft.Office.Interop.Outlook.MailItem mailItem = (Microsoft.Office.Interop.Outlook.MailItem)app.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

                //The email receiver
                //recipients
                Microsoft.Office.Interop.Outlook.Recipients recipients = mailItem.Recipients as Microsoft.Office.Interop.Outlook.Recipients;

                foreach (var email in receivers)
                {
                    recipients.Add(email);
                }

                mailItem.Subject = subject;
                mailItem.Body = body;

                mailItem.Send();

                return "sent";
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                if (ex.ErrorCode == -2147417846)
                {
                    return languageModel.getString("alertOutlookNotRunning");
                }
                else
                {
                    //return "Error, Email was Not sent";
                    return "sent";
                }
            }


        }


        //send eamil to All Groups Members
        public String sendEmailToAllGroups(String subject, String body)
        {
            String result = "sent";

            var groupsEmail = this.getGroupsEmail();
            foreach (var groupEmail in groupsEmail)
            {
                //get recipients  
                string[] tabEmails = groupEmail.Split(';');

                //send email to all recipients
                result = this.sendEmail(subject, body, tabEmails);
                 
            }


            return result;
        }


        //get Group emails
        private List<String> getGroupsEmail()
        {
            List<String> groupsEmail = new List<String>();

            var approvementGroups = deviationModel.listApprovementGroup();
            foreach (var approvementGr in approvementGroups)
            {
                groupsEmail.Add(approvementGr.groupEmail);

            }

            return groupsEmail.Distinct().ToList();
        }
        

        //send email to Groups who did not approved to reminf them
        public String sentEmailToGroups(Deviation deviation)
        {
            LanguageModel languageModel = new LanguageModel();
            String result = "sent";

            String subject = "Reminder / Erinnerung #" + deviation.deviationRef;
            String body = "Sehr geehrte Damen und Herren \n";
            body += "Es fehlen noch Unterschriften zu Abweichung #"+deviation.deviationRef + " \n \n";
            body += "Dear Ladies and Gentlemen, \n";
            body += "We are missing some Signatures at Deviation Report #" + deviation.deviationRef + "\n\n";
            body += "Mit freundlichen Grüßen/Best Regards";

            if (deviation != null)
            {
                var groupsEmail = this.getGroupsEmailNotApproved(deviation);
                foreach (var groupEmail in groupsEmail)
                {
                    if (groupEmail.Length > 0)
                    {
                        //get recipients  
                        string[] tabEmails = groupEmail.Split(';');

                        //send email to all recipients
                        result = this.sendEmail(subject, body, tabEmails);
                    }              
                }

            }
            else
            {
                result = languageModel.getString("deviationNotExist");
            }

            return result;
        }


        //get Approvement Group who did not approved
        private List<String> getGroupsEmailNotApproved(Deviation deviation)
        {
            List<String> groupsEmail = new List<String>();

            var approvements = deviation.approvements;
            foreach (var approvement in approvements)
            {
                if (approvement.name == "" || approvement.name==null)
                {
                    groupsEmail.Add(approvement.approvementGroup.groupEmail);
                }
            }

            return groupsEmail.Distinct().ToList();
        }



        //****____class ***/
    }
}
