using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.Repository
{
    public interface IRepository<TModel> where TModel : class
    {
        Task<TModel> GetAsync(int id);
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<IEnumerable<TModel>> FindAsync(Expression<Func<TModel, bool>> predicate);

        Task AddAsync(TModel model);
        Task AddRangeAsync(IEnumerable<TModel> models);

        Task UpdateAsync(TModel model);

        Task RemoveAsync(TModel model);
        Task RemoveRangeAsync(IEnumerable<TModel> models);
    }
}
