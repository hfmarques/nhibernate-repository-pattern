using NHibernate.Data.Persistence.DataContext;
using NHibernate.Repository.Repositories;
using System.Threading.Tasks;

namespace NHibernate.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ISession _session;
        private ITransaction _transaction;
        public IEnderecoRepository Endereco { get; }
        public IHotelRepository Hotel { get; }
        public IQuartoRepository Quarto { get; }

        public UnitOfWork(DataContext session)
        {
            _session = session.OpenSession();
            Endereco = new EnderecoRepository(_session);
            Hotel = new HotelRepository(_session);
            Quarto = new QuartoRepository(_session);
        }

        public void BeginTransaction()
        {
            _transaction = _session.BeginTransaction();
        }

        public async Task CommitTransactionAsync()
        {
            await _transaction.CommitAsync();
            CloseTransaction();
        }

        public async Task RollBackTransactionAsync()
        {
            await _transaction.RollbackAsync();
            CloseTransaction();
            CloseSession();
        }

        private void CloseTransaction()
        {
            _transaction.Dispose();
            _transaction = null;
        }

        private void CloseSession()
        {
            _session.Close();
            _session.Dispose();
            _session = null;
        }

        public async void Dispose()
        {
            if (_transaction != null)
            {
                await CommitTransactionAsync();
            }

            if (_session == null) return;
            CloseSession();
        }
    }
}
