using DeviationManager.Entity;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviationManager.Mappings
{
    class AttachmentsMap : ClassMap<Attachments>
    {

        public AttachmentsMap()
        {
            Id(x => x.attachmentId);
            Map(x => x.fileName);
            Map(x => x.fileNameDb);
            Map(x => x.date);
            Map(x => x.liblle);

            References(x => x.deviation);
        }
    }
}
