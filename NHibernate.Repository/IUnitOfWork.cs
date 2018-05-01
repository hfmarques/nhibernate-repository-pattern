using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Repository.Repositories;

namespace NHibernate.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IClienteRepository Cliente { get; }
        IEnderecoRepository Endereco { get; }
        IFuncionarioRepository Funcionario { get; }
        IHotelRepository Hotel { get; }
        IQuartoRepository Quarto { get; }
        IReservaRepository Reserva { get; }
        ITelefoneRepository Telefone { get; }
        Task SaveChangesAsync();
        void BeginTransaction();
        Task CommitTransactionAsync();
        Task RollBackTransactionAsync();
    }
}
