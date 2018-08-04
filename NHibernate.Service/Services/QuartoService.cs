using NHibernate.Data.Persistence.DataContext;
using NHibernate.Repository;

namespace NHibernate.Service.Services
{
    public class QuartoService
    {
        private readonly UnitOfWork _unitOfWork;

        public QuartoService(DataContext session)
        {
            _unitOfWork = new UnitOfWork(session);
        }
    }
}
