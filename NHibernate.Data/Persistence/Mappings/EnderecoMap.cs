using FluentNHibernate.Mapping;
using NHibernate.Core.Models;

namespace NHibernate.Data.Persistence.Mappings
{
    public class EnderecoMap : ClassMap<Endereco>
    {
        public EnderecoMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();

            Map(x => x.Complemento);
            Map(x => x.Numero);
            Map(x => x.Bairro);
            Map(x => x.Cep);
            Map(x => x.Cidade);
            Map(x => x.Uf);
            Map(x => x.Rua);
        }
    }
}
