using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviationManager.Entity
{
    public class User
    {
        public virtual String name { get; set; }
        public virtual String position { get; set; }
        public virtual String role { get; set; }
    }
}
