using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Core.Models;
using NHibernate.Data.Persistence.DataContext;
using NHibernate.Repository;

namespace NHibernate.Service.Services
{
    public class ClienteService : IService<Cliente>
    {
        private readonly UnitOfWork _unitOfWork;

        public ClienteService(DataContext session)
        {
            _unitOfWork = new UnitOfWork(session);
        }

        public async Task<Cliente> GetAsync(int id)
        {
            return await _unitOfWork.Cliente.GetAsync(id);
        }

        public async Task<IQueryable<Cliente>> GetAllAsync()
        {
            return (await _unitOfWork.Cliente.GetAllAsync()).AsQueryable();
        }

        public async Task<IQueryable<Cliente>> FindAsync(Expression<Func<Cliente, bool>> predicate)
        {
            return (await _unitOfWork.Cliente.FindAsync(predicate)).AsQueryable();
        }

        public async Task AddAsync(Cliente model)
        {
            await _unitOfWork.Cliente.AddAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<Cliente> models)
        {
            await _unitOfWork.Cliente.AddRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Cliente model)
        {
            await _unitOfWork.Cliente.UpdateAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveAsync(Cliente model)
        {
            await _unitOfWork.Cliente.RemoveAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<Cliente> models)
        {
            await _unitOfWork.Cliente.RemoveRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
