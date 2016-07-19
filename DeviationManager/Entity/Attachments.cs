using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviationManager.Entity
{
    public class Attachments
    {
        public virtual int attachmentId { get; protected set; }
        public virtual String fileName { get; set; }
        public virtual String fileNameDb { get; set; }
        public virtual DateTime date { get; set; }
        public virtual String liblle { get; set; }

        public virtual Deviation deviation { get; set; }
    }
}
