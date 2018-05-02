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
    public class QuartoService : IService<Quarto>
    {
        private readonly UnitOfWork _unitOfWork;

        public QuartoService(DataContext session)
        {
            _unitOfWork = new UnitOfWork(session);
        }

        public async Task<Quarto> GetAsync(int id)
        {
            return await _unitOfWork.Quarto.GetAsync(id);
        }

        public async Task<IQueryable<Quarto>> GetAllAsync()
        {
            return (await _unitOfWork.Quarto.GetAllAsync()).AsQueryable();
        }

        public async Task<IQueryable<Quarto>> FindAsync(Expression<Func<Quarto, bool>> predicate)
        {
            return (await _unitOfWork.Quarto.FindAsync(predicate)).AsQueryable();
        }

        public async Task AddAsync(Quarto model)
        {
            await _unitOfWork.Quarto.AddAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<Quarto> models)
        {
            await _unitOfWork.Quarto.AddRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Quarto model)
        {
            await _unitOfWork.Quarto.UpdateAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveAsync(Quarto model)
        {
            await _unitOfWork.Quarto.RemoveAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<Quarto> models)
        {
            await _unitOfWork.Quarto.RemoveRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
