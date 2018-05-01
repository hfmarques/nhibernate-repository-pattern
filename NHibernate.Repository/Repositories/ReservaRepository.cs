using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Core.Models;

namespace NHibernate.Repository.Repositories
{
    public class ReservaRepository : Repository<Reserva>, IReservaRepository
    {
        public ReservaRepository(ISession session) : base(session)
        {
        }
    }
}
