using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using NHibernate.Core.Models;

namespace NHibernate.Data.Persistence.Mappings
{
    public class ReservaMap : ClassMap<Reserva>
    {
        public ReservaMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Dia);
            Map(x => x.QuantidadeDias);
            Map(x => x.Quarto);
        }
    }
}
