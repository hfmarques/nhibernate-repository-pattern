using NHibernate.Data.Persistence.DataContext;
using NHibernate.Repository;

namespace NHibernate.Service.Services
{
    public class EnderecoService
    {
        private readonly UnitOfWork _unitOfWork;

        public EnderecoService(DataContext session)
        {
            _unitOfWork = new UnitOfWork(session);
        }
    }
}
