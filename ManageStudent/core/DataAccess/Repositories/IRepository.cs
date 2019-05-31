using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StudentAPI.core.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        #region GET
        // define function : Get with 4 feature such as get all , get all condition , get one Oject with id and condition
        IQueryable<T> GetAll();

        IQueryable<T> Fetch(Expression<Func<T, bool>> expression);

        Task<T> FetchFirstAsync(Expression<Func<T, bool>> expression);

        Task<T> GetByIdAsync(Guid Id);

        Task<ResponseModel> ExcuteSqlAsync(string sql);
        #endregion
        #region Insert

        // Insert one entity and list entity
        Task<ResponseModel> InsertAsync(T entity);

        Task<ResponseModel> InsertAsync(IEnumerable<T> entities);

        #endregion

    }
}