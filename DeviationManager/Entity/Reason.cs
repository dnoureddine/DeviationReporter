using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviationManager.Entity
{
    public class Reason
    {
        public virtual int reasonId { get; protected set; }
        public virtual String reason { get; set; }

        public virtual Deviation deviation { get; set; }

    }
}
