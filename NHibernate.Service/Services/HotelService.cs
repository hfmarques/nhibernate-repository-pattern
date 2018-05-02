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
    public class HotelService : IService<Hotel>
    {
        private readonly UnitOfWork _unitOfWork;

        public HotelService(DataContext session)
        {
            _unitOfWork = new UnitOfWork(session);
        }

        public async Task<Hotel> GetAsync(int id)
        {
            return await _unitOfWork.Hotel.GetAsync(id);
        }

        public async Task<IQueryable<Hotel>> GetAllAsync()
        {
            return (await _unitOfWork.Hotel.GetAllAsync()).AsQueryable();
        }

        public async Task<IQueryable<Hotel>> FindAsync(Expression<Func<Hotel, bool>> predicate)
        {
            return (await _unitOfWork.Hotel.FindAsync(predicate)).AsQueryable();
        }

        public async Task AddAsync(Hotel model)
        {
            await _unitOfWork.Hotel.AddAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<Hotel> models)
        {
            await _unitOfWork.Hotel.AddRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Hotel model)
        {
            await _unitOfWork.Hotel.UpdateAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveAsync(Hotel model)
        {
            await _unitOfWork.Hotel.RemoveAsync(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<Hotel> models)
        {
            await _unitOfWork.Hotel.RemoveRangeAsync(models);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
