﻿using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.IRepositories
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetOneAsync(
         Expression<Func<T, bool>>? expression = null,
         Func<IQueryable<T>, IIncludableQueryable<T, object>>? includeChain = null,
         bool asNoTracking = false,
         Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool IsDeleted = false
    );
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? includeChain = null,
            bool asNoTracking = false, int? skip = null, int? take = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool IsDeleted = false);
        Task<int> CountAsync(Expression<Func<T, bool>>? expression = null);
        Task AddAsync(T entity);
        void Update(T entity);
        Task DeleteAsync(Expression<Func<T, bool>> expression);
        Task AddToArchiveAsync(Expression<Func<T, bool>> expression);
        Task SaveChangesAsync();
    }
}
