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
    public class ReservaService : IService<Reserva>
    {
        private readonly UnitOfWork _unitOfWork;

        public ReservaService(DataContext session)
        {
            _unitOfWork = new UnitOfWork(session);
        }

        public async Task<Reserva> GetAsync(int id)
        {
            return await _unitOfWork.Reserva.GetAsync(id);
        }

        public async Task<IQueryable<Reserva>> GetAllAsync()
        {
            return (await _unitOfWork.Reserva.GetAllAsync()).AsQueryable();
        }

        public async Task<IQueryable<Reserva>> FindAsync(Expression<Func<Reserva, bool>> predicate)
        {
            return (await _unitOfWork.Reserva.FindAsync(predicate)).AsQueryable();
        }

        public async Task AddAsync(Reserva model)
        {
            await _unitOfWork.Reserva.AddAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<Reserva> models)
        {
            await _unitOfWork.Reserva.AddRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Reserva model)
        {
            await _unitOfWork.Reserva.UpdateAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveAsync(Reserva model)
        {
            await _unitOfWork.Reserva.RemoveAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<Reserva> models)
        {
            await _unitOfWork.Reserva.RemoveRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
