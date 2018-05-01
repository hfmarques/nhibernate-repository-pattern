using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using NHibernate.Linq;

namespace NHibernate.Repository
{
    public class Repository<TModel> : IRepository<TModel> where TModel : class
    {
        private readonly ISession _session;

        public Repository(ISession session)
        {
            _session = session;
        }

        public async Task<TModel> GetAsync(int id)
        {
            return await _session.GetAsync<TModel>(id);
        }

        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            return await _session.Query<TModel>().ToListAsync();
        }

        public async Task<IEnumerable<TModel>> FindAsync(Expression<Func<TModel, bool>> predicate)
        {
            return await _session.Query<TModel>().Where(predicate).ToListAsync();
        }

        public async Task AddAsync(TModel model)
        {
            await _session.SaveOrUpdateAsync(model);
        }

        public async Task AddRangeAsync(IEnumerable<TModel> models)
        {
            foreach (var model in models)
            {
                await AddAsync(model);
            }
        }

        public async Task UpdateAsync(TModel model)
        {
            await _session.SaveOrUpdateAsync(model);
        }

        public async Task RemoveAsync(TModel model)
        {
            await _session.DeleteAsync(model);
        }

        public async Task RemoveRangeAsync(IEnumerable<TModel> models)
        {
            foreach (var model in models)
            {
                await RemoveAsync(model);
            }
        }
    }
}
