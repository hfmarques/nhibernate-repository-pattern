using FluentNHibernate.Mapping;
using NHibernate.Core.Models;

namespace NHibernate.Data.Persistence.Mappings
{
    public class HotelMap : ClassMap<Hotel>
    {
        public HotelMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();

            Map(x => x.Nome);

            References(x => x.Endereco).Column("EnderecoId");

            HasMany(x => x.Quartos);
        }
    }
}
