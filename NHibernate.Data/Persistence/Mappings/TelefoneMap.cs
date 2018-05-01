using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using NHibernate.Core.Models;

namespace NHibernate.Data.Persistence.Mappings
{
    public class TelefoneMap : ClassMap<Telefone>
    {
        public TelefoneMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Ddd);
            Map(x => x.Numero);
        }
    }
}
