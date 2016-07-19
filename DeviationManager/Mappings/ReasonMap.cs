using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using DeviationManager.Entity;

namespace DeviationManager.Mappings
{
    class ReasonMap : ClassMap<Reason>
    {

        public ReasonMap()
        {
            Id(x => x.reasonId);
            Map(x => x.reason);

            References(x => x.deviation);
        }
    }
}
