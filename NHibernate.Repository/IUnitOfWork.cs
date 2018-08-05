using System;
using System.Threading.Tasks;

namespace NHibernate.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        Task CommitTransactionAsync();
        Task RollBackTransactionAsync();
    }
}
