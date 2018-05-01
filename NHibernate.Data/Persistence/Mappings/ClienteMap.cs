using FluentNHibernate.Mapping;
using NHibernate.Core.Models;

namespace NHibernate.Data.Persistence.Mappings
{
    public class ClienteMap :  ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome);
            Map(x => x.Rg);
            Map(x => x.Telefones);
            Map(x => x.Endereco);
            Map(x => x.QuantidadeOcupacoes);
            Map(x => x.Hotel);
            Map(x => x.Reservas);
        }
    }
}
