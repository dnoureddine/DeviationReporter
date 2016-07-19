using DeviationManager.Entity;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviationManager.Mappings
{
    class ConnectionMap : ClassMap<Connection>
    {

        public ConnectionMap()
        {
            Id(x => x.id);
            Map(x => x.password);
            Map(x => x.userName);
        }

    }
}
