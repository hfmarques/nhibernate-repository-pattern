using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Core.Models;

namespace NHibernate.Repository.Repositories
{
    public class HotelRepository : Repository<Hotel>, IHotelRepository
    {
        public HotelRepository(ISession session) : base(session)
        {
        }
    }
}
