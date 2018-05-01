using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using NHibernate.Core.Models;

namespace NHibernate.Data.Persistence.Mappings
{
    public class FuncionarioMap : ClassMap<Funcionario>
    {
        public FuncionarioMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome);
            Map(x => x.Rg);
            Map(x => x.Telefones);
            Map(x => x.Endereco);
            Map(x => x.Setor);
            Map(x => x.Hotel);
        }
    }
}
