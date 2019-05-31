using Microsoft.EntityFrameworkCore;
using StudentAPI.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StudentAPI.core.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected DatabaseContext _databaseContext;

        #region Constructor

        public Repository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        #endregion
        #region Get Data
        public IQueryable<T> Fetch(Expression<Func<T, bool>> expression)
        {
            return GetAll().Where(expression);
        }

        public IQueryable<T> GetAll()
        {
            return _databaseContext.Set<T>().OrderBy(s => s.Id);
        }

        public async Task<T> FetchFirstAsync(Expression<Func<T, bool>> expression)
        {
            return await GetAll().FirstOrDefaultAsync(expression);
        }

        public async Task<T> GetByIdAsync(Guid Id)
        {
            return await _databaseContext.Set<T>().FirstOrDefaultAsync(s => s.Id == Id);
        }

        public async Task<ResponseModel> ExcuteSqlAsync(string sql)
        {
            _databaseContext.Database.ExecuteSqlCommandAsync(sql);
            await _databaseContext.SaveChangesAsync();

            var response = new ResponseModel();
            response.HttpStatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }

        #endregion
        #region Insert Data

        public async Task<ResponseModel> InsertAsync(T entity)
        {
            var dbSet = _databaseContext.Set<T>();
            dbSet.Add(entity);
            await _databaseContext.SaveChangesAsync();

            var response = new ResponseModel();
            response.HttpStatusCode = System.Net.HttpStatusCode.OK;
            response.Data = entity;
            return response;
        }

        public async Task<ResponseModel> InsertAsync(IEnumerable<T> entities)
        {
            var dbSet = _databaseContext.Set<T>();
            foreach (T item in entities)
            {
                dbSet.Add(item);
            }
            await _databaseContext.SaveChangesAsync();

            var response = new ResponseModel();
            response.HttpStatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }

        #endregion


    }
}
