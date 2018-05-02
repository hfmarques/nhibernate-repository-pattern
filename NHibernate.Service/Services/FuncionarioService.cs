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
    public class FuncionarioService : IService<Funcionario>
    {
        private readonly UnitOfWork _unitOfWork;

        public FuncionarioService(DataContext session)
        {
            _unitOfWork = new UnitOfWork(session);
        }

        public async Task<Funcionario> GetAsync(int id)
        {
            return await _unitOfWork.Funcionario.GetAsync(id);
        }

        public async Task<IQueryable<Funcionario>> GetAllAsync()
        {
            return (await _unitOfWork.Funcionario.GetAllAsync()).AsQueryable();
        }

        public async Task<IQueryable<Funcionario>> FindAsync(Expression<Func<Funcionario, bool>> predicate)
        {
            return (await _unitOfWork.Funcionario.FindAsync(predicate)).AsQueryable();
        }

        public async Task AddAsync(Funcionario model)
        {
            await _unitOfWork.Funcionario.AddAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<Funcionario> models)
        {
            await _unitOfWork.Funcionario.AddRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Funcionario model)
        {
            await _unitOfWork.Funcionario.UpdateAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveAsync(Funcionario model)
        {
            await _unitOfWork.Funcionario.RemoveAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<Funcionario> models)
        {
            await _unitOfWork.Funcionario.RemoveRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
