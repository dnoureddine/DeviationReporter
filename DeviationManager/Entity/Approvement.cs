using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviationManager.Entity
{
    public class Approvement
    {
        public virtual int approvementId { get; protected set; }
        public virtual String name { get; set; }
        public virtual Boolean approved { get; set; }
        public virtual Boolean rejected { get; set; }
        public virtual String comment { get; set; }
        public virtual Boolean signed { get; set; }
        public virtual DateTime? date { get; set; }

        public virtual Deviation deviation { get; set; }
        public virtual ApprovementGroup approvementGroup { get; set; }



    }
}
