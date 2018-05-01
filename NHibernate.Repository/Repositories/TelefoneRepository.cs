using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Core.Models;

namespace NHibernate.Repository.Repositories
{
    public class TelefoneRepository : Repository<Telefone>, ITelefoneRepository
    {
        public TelefoneRepository(ISession session) : base(session)
        {
        }
    }
}
