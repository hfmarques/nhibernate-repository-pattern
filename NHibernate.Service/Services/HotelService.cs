using NHibernate.Core.Models;
using NHibernate.Data.Persistence.DataContext;
using NHibernate.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NHibernate.Service.Services
{
    public class HotelService
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

        public async Task<Hotel> AddAsync(Hotel model)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (_unitOfWork.Endereco.FindAsync(x =>
                        x.Cidade == model.Endereco.Cidade && x.Bairro == model.Endereco.Bairro &&
                        x.Complemento == model.Endereco.Complemento && x.Numero == model.Endereco.Numero &&
                        x.Rua == model.Endereco.Rua && x.Uf == model.Endereco.Uf).Result.FirstOrDefault() == null)
                    await _unitOfWork.Endereco.AddAsync(model.Endereco);

                foreach (var quarto in model.Quartos)
                {
                    await _unitOfWork.Quarto.AddAsync(quarto);
                }

                await _unitOfWork.Hotel.AddAsync(model);

                await _unitOfWork.CommitTransactionAsync();

                return model;
            }
            catch (Exception)
            {
                await _unitOfWork.RollBackTransactionAsync();
                throw;
            }
        }

        public async Task AddRangeAsync(IEnumerable<Hotel> models)
        {
            await _unitOfWork.Hotel.AddRangeAsync(models);

        }

        public async Task UpdateAsync(Hotel model)
        {
            await _unitOfWork.Hotel.UpdateAsync(model);

        }

        public async Task RemoveAsync(Hotel model)
        {
            await _unitOfWork.Hotel.RemoveAsync(model);

        }

        public async Task RemoveRangeAsync(IEnumerable<Hotel> models)
        {
            await _unitOfWork.Hotel.RemoveRangeAsync(models);

        }
    }
}
