
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IRepository<TEntity,TEntityId> where TEntity : class
{
   
     IQueryable<TEntity> GetQueryable(bool asNoTracking = true);

    Task<ICollection<TEntity>> GetAllAsync(bool asNoTracking = true);


}