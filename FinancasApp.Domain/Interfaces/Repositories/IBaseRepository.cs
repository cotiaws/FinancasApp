using FinancasApp.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity, TKey>
        where TEntity : class
    {
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);

        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<PageResult<TEntity>> GetAllAsync(int pageNumber, int pageSize);
        Task<TEntity?> GetByIdAsync(TKey id);
    }
}
