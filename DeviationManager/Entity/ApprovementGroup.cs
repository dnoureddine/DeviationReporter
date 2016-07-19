using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DeviationManager.Entity
{
    public class ApprovementGroup
    {
        [Browsable(false)]
        public virtual int approvalId { get; protected set; }
        [Browsable(false)]
        public virtual String liblle { get; set; }
        [Browsable(false)]
        public virtual String role { get; set; }
        [Browsable(false)]
        public virtual String groupEmail { get; set; }

        [Browsable(false)]
        public virtual IList<Approvement> approvements { get; set; }

        //DataGRID label
        public virtual int ID
        {
            get
            {
                return approvalId;
            }

        }

        public virtual String Name {
            get
            {
                return liblle;
            }
            
       }

        public virtual String Role
        {
            get
            {
                return role;
            }

        }


        public virtual String GroupEmail
        {
            get
            {
                return groupEmail;
            }

        }

    

        /********************************************/
        public ApprovementGroup()
        {
            approvements = new List<Approvement>(); 
        }

    }
}
