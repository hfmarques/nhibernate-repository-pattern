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
    public class EnderecoService : IService<Endereco>
    {
        private readonly UnitOfWork _unitOfWork;

        public EnderecoService(DataContext session)
        {
            _unitOfWork = new UnitOfWork(session);
        }

        public async Task<Endereco> GetAsync(int id)
        {
            return await _unitOfWork.Endereco.GetAsync(id);
        }

        public async Task<IQueryable<Endereco>> GetAllAsync()
        {
            return (await _unitOfWork.Endereco.GetAllAsync()).AsQueryable();
        }

        public async Task<IQueryable<Endereco>> FindAsync(Expression<Func<Endereco, bool>> predicate)
        {
            return (await _unitOfWork.Endereco.FindAsync(predicate)).AsQueryable();
        }

        public async Task AddAsync(Endereco model)
        {
            await _unitOfWork.Endereco.AddAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<Endereco> models)
        {
            await _unitOfWork.Endereco.AddRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Endereco model)
        {
            await _unitOfWork.Endereco.UpdateAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveAsync(Endereco model)
        {
            await _unitOfWork.Endereco.RemoveAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<Endereco> models)
        {
            await _unitOfWork.Endereco.RemoveRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
