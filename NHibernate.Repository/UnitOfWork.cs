using System.Threading.Tasks;
using NHibernate.Data.Persistence.DataContext;
using NHibernate.Repository.Repositories;

namespace NHibernate.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ISession _session;
        private ITransaction _transaction;

        public UnitOfWork(DataContext session)
        {
            _session = session.OpenSession();
            Cliente = new ClienteRepository(_session);
            Endereco = new EnderecoRepository(_session);
            Funcionario = new FuncionarioRepository(_session);
            Hotel = new HotelRepository(_session);
            Quarto = new QuartoRepository(_session);
            Reserva = new ReservaRepository(_session);
            Telefone = new TelefoneRepository(_session);
        }

        public IClienteRepository Cliente { get; }
        public IEnderecoRepository Endereco { get; }
        public IFuncionarioRepository Funcionario { get; }
        public IHotelRepository Hotel { get; }
        public IQuartoRepository Quarto { get; }
        public IReservaRepository Reserva { get; }
        public ITelefoneRepository Telefone { get; }

        public async Task SaveChangesAsync()
        {
            await _session.FlushAsync();
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
            await SaveChangesAsync();
            CloseSession();
        }
    }
}
