using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using DeviationManager.Entity;

namespace DeviationManager.Mappings
{
    class ApprovementMap : ClassMap<Approvement>
    {

        public ApprovementMap()
        {
            Id(x => x.approvementId);
            Map(x => x.name);
            Map(x => x.approved);
            Map(x => x.rejected);
            Map(x => x.signed);
            Map(x => x.comment);
            Map(x => x.date);

            References(x => x.deviation);
            References(x => x.approvementGroup);
        }

    }
}
