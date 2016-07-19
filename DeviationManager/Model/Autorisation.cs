using DeviationManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DeviationManager.Model
{
    public class Autorisation
    {

        private DeviationModel deviationModel;

        public Autorisation()
        {
            deviationModel = new DeviationModel();
        }


        //the USER cann update the Deviation if he WROTE IT: output: null if must not, Deviation object if is allowed
        public Deviation canUpdateDeviation(String deviationRef)
        {
            Deviation deviation = deviationModel.getDeviationWithRef(deviationRef);
            if (deviation.signature == deviationModel.getUserNameFromActiveDirectory())
            {
                return deviation;
            }
            else
            {
                return null;
            }
        }

        /******** make sure if the current user can create deviation ***/
        public bool canCreateDeviation(User user)
        {
            var approvementGroups = deviationModel.listApprovementGroup();
            bool canCreateDeviation = false;

            foreach (var approvementGroup in approvementGroups)
            {
                if (approvementGroup.role == user.role)
                {
                    canCreateDeviation = true;
                    break;
                }
            }

            return canCreateDeviation;
        }


        /***** make sure if the user is allowed to approve ****/
        public String cannApprove(int approvementId)
        {
            LanguageModel languageModel = new LanguageModel();
            String toApprove = "canApprove";

            Approvement approvement = deviationModel.getApprovement(approvementId);
            bool isAutorized = this.isAutorized(approvement.approvementGroup.role);

            if (approvement.deviation.status=="closed")
            {
                toApprove = languageModel.getString("deviationAlreadyClosed");
            }
            if (approvement.approved || approvement.rejected)
            {
                if (toApprove == "canApprove")
                {
                    toApprove = languageModel.getString("alertApprovementAlreadyDone"); ;
                }
                else
                {
                    toApprove = toApprove + ", " + languageModel.getString("alertApprovementAlreadyDone");
                }
                
            }
            
            if (approvement.deviation.endDatePeriod < DateTime.Now)
            {
                if (toApprove == "canApprove")
                {
                    toApprove = languageModel.getString("ldeviationexpiredChange"); 
                }
                else
                {
                    toApprove = toApprove+ ", "+languageModel.getString("ldeviationexpiredChange");
                }
            }

            //if the user is not autorized to approve
            if (!isAutorized)
            {
                toApprove = languageModel.getString("alertNoAccess");
            }
           
            return toApprove;
        }

        //make sure that the user has the role
        public bool isAutorized(String roles)
        {
            bool isAutorized = false;
            string[] tab = roles.Split(';');
            foreach (var role in tab)
            {
                try
                {
                    bool UserIsInGroup = new System.Security.Principal.WindowsPrincipal(new System.Security.Principal.WindowsIdentity(Environment.UserName)).IsInRole(role);
                    if (UserIsInGroup)
                    {
                        isAutorized = true;
                        break;
                    }

                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (System.Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {

                }

            }

            return isAutorized;
        }

        /**____ class   ****/
    }
}
