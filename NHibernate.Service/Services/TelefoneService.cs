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
    public class TelefoneService : IService<Telefone>
    {
        private readonly UnitOfWork _unitOfWork;

        public TelefoneService(DataContext session)
        {
            _unitOfWork = new UnitOfWork(session);
        }

        public async Task<Telefone> GetAsync(int id)
        {
            return await _unitOfWork.Telefone.GetAsync(id);
        }

        public async Task<IQueryable<Telefone>> GetAllAsync()
        {
            return (await _unitOfWork.Telefone.GetAllAsync()).AsQueryable();
        }

        public async Task<IQueryable<Telefone>> FindAsync(Expression<Func<Telefone, bool>> predicate)
        {
            return (await _unitOfWork.Telefone.FindAsync(predicate)).AsQueryable();
        }

        public async Task AddAsync(Telefone model)
        {
            await _unitOfWork.Telefone.AddAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<Telefone> models)
        {
            await _unitOfWork.Telefone.AddRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Telefone model)
        {
            await _unitOfWork.Telefone.UpdateAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveAsync(Telefone model)
        {
            await _unitOfWork.Telefone.RemoveAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<Telefone> models)
        {
            await _unitOfWork.Telefone.RemoveRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
