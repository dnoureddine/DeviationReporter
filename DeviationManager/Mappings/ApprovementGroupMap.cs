using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using DeviationManager.Entity;

namespace DeviationManager.Mappings
{
    class ApprovementGroupMap : ClassMap<ApprovementGroup>
    {
        public ApprovementGroupMap()
        {

            Id(x => x.approvalId);
            Map(x => x.liblle);
            Map(x => x.role);
            Map(x => x.groupEmail);

            HasMany(x => x.approvements).Not.LazyLoad()
                .Cascade.All();
        }
    }
}
