using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Core.Models;

namespace NHibernate.Repository.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ISession session) : base(session)
        {
        }
    }
}
