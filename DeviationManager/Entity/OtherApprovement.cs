using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviationManager.Entity
{
    public class OtherApprovement
    {
        public String title { get;set;}
        public String selectYesNo { get; set; }
        public bool requestApproved { get; set; }
        public bool requestRejected { get; set; }
        public DateTime date { get; set; }
        public String nameApproval { get; set; }
        public String positionApproval { get; set; }
        public String signatureApproval { get; set; }

    }
}
