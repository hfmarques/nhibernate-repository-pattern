using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Core.Models;

namespace NHibernate.Repository.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ISession session) : base(session)
        {
        }
    }
}
