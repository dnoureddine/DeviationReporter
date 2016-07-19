using DeviationManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DeviationManager.Entity
{
    public class Deviation
    {

        [Browsable(false)]
        public virtual int deviationId { get; protected set; }

        [DisplayName("Abweichung Nr")]
        public virtual String deviationRef { get; set; }
        [Browsable(false)]
        public virtual String deviationRiskCategory { get; set; }
        [DisplayName("Erstellt von")]
        public virtual String requestedBy { get; set; }
        [DisplayName("Erstelldatum")]
        public virtual DateTime? dateCreation { get; set; }
        [Browsable(false)]
        public virtual String signature { get; set; }
        [Browsable(false)]
        public virtual String position { get; set; }
        [Browsable(false)]
        public virtual String deviationType { get; set; }
        [Browsable(false)]
        public virtual String describeOtherType { get; set; }
        [Browsable(false)]
        public virtual String detailRequestCondition { get; set; }
        [DisplayName("Abweichung von")]
        public virtual DateTime? startDatePeriod { get; set; }
        [DisplayName("Abweichung bis")]
        public virtual DateTime? endDatePeriod { get; set; }
        [Browsable(false)]
        public virtual String status { get; set; }
        [Browsable(false)]
        public virtual Boolean isPrinted { get; set; }
        [DisplayName("Geschlossen am")]
        public virtual DateTime? dateClosed { get; set; }
        [DisplayName("Produkt")]
        public virtual String product { get; set; }
        [DisplayName("Anlage")]
        public virtual String anlage { get; set; }
        [DisplayName("Sollvorgabe")]
        public virtual String detailStandardCondition { get; set; }
        [Browsable(false)]
        public virtual String barcode { get; set; }


        [Browsable(false)]
        public virtual IList<Reason> reasons { get;  set; }
        [Browsable(false)]
        public virtual IList<Approvement> approvements { get;  set; }
        [Browsable(false)]
        public virtual IList<Attachments> attachements { get; set; }


        [DisplayName("Freigabestatus")]
        public virtual String Freigabe
        {
            get
            {
                String isApproved = "Pending";
                bool isRejected = false;
                foreach (var approvement in approvements)
                {
                    if (approvement.rejected == true)
                    {
                        isRejected = true;
                        break;
                    }
                }


                 if (isRejected)
                {
                    isApproved = "Rejected";
                }
                else 
                {
                    bool approved = true;
                    foreach (var approvement in approvements)
                    {
                        if (approvement.approved == false)
                        {
                            approved = false;
                            break;
                        }
                    }

                    if (approved)
                    {
                        isApproved = "Approved";
                    }
                    else if (this.status == "closed")
                    {
                        isApproved = "Closed";
                    }
                }

                DateTime actualDate = DateTime.Now;

                if(isApproved == "Pending" && endDatePeriod >actualDate)
                {
                    isApproved = "In Bearbeitung";
                }
                else if(isApproved == "Pending" && endDatePeriod < actualDate)
                {
                    isApproved = "Abgelaufen & Unvolständig";
                }
                if (isApproved == "Closed")
                {
                    isApproved = "Gesperrt";
                }
                if (isApproved == "Rejected")
                {
                    isApproved = "Abgelehnt";
                }
                if (isApproved == "Approved")
                {
                    isApproved = "Freigegeben";
                }

                return isApproved;
            }
        }
        public Deviation()
        {
            reasons= new List<Reason>();
            approvements = new List<Approvement>();
            attachements = new List<Attachments>();

        }
    }
}
