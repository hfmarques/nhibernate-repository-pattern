using FluentNHibernate.Mapping;
using NHibernate.Core.Models;

namespace NHibernate.Data.Persistence.Mappings
{
    public class QuartoMap : ClassMap<Quarto>
    {
        public QuartoMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();

            Map(x => x.Cama);
            Map(x => x.Numero);
            Map(x => x.Ocupado);
            Map(x => x.Tipo);

            References(x => x.Hotel).Column("HotelId");
        }
    }
}
