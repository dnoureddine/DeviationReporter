using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviationManager.Entity
{
    public class Connection
    {
        public virtual int id  { get; protected set; }
        public virtual String password { get; set; }
        public virtual String userName { get; set; }
    }
}
