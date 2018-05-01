using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Core.Models;

namespace NHibernate.Repository.Repositories
{
    public class QuartoRepository : Repository<Quarto>, IQuartoRepository
    {
        public QuartoRepository(ISession session) : base(session)
        {
        }
    }
}
