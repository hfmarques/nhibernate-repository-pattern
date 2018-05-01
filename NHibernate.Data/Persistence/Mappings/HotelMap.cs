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
            Map(x => x.Telefones);
            Map(x => x.Endereco);
            Map(x => x.Pessoas);
            Map(x => x.Quartos);
        }
    }
}
