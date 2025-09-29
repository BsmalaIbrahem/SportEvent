﻿using DataAccessLayer.Data;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DataAccessLayer.Repositories
{
    public class MainRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context; 

        public MainRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? includeChain = null,
            bool asNoTracking = false, int? skip = null, int? take = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool IsDeleted = false
        )
        {
            IQueryable<T> query = _context.Set<T>();
            query = query.Where(e => EF.Property<bool>(e, "IsDeleted") == IsDeleted);

            if (filter != null)
                query = query.Where(filter);

            if (includeChain != null)
                query = includeChain(query);

            if (asNoTracking)
                query = query.AsNoTracking();

            if (orderBy != null)
                query = orderBy(query);

            if (skip.HasValue && take.HasValue)
                query = query.Skip(skip.Value).Take(take.Value);

            return await query.ToListAsync();
        }

        public async Task<T?> GetOneAsync(
        Expression<Func<T, bool>>? filter = null,
        Func<IQueryable<T>, IIncludableQueryable<T, object>>? includeChain = null,
        bool asNoTracking = false,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool IsDeleted = false)
        {
            IQueryable<T> query = _context.Set<T>();
            query = query.Where(e => EF.Property<bool>(e, "IsDeleted") == IsDeleted);

            if (filter != null)
                query = query.Where(filter);

            if (includeChain != null)
                query = includeChain(query);

            if (asNoTracking)
                query = query.AsNoTracking();

            if (orderBy != null)
                query = orderBy(query);

            return await query.FirstOrDefaultAsync();
        }


        public async Task<int> CountAsync(Expression<Func<T, bool>>? expression = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includeChain = null)
        {
            var query = _context.Set<T>().AsQueryable();
            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (includeChain != null)
                query = includeChain(query);

            return await query.CountAsync();
        }

        public async Task AddAsync(T entity)
        {
            try
            {
                _context.Entry(entity).Property("CreatedAt").CurrentValue = DateTime.Now;
                await _context.Set<T>().AddAsync(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the entity.", ex);
            }

        }
        public void  Update(T entity)
        {
            try
            {
                _context.Entry(entity).Property("UpdatedAt").CurrentValue = DateTime.Now;
                _context.Entry(entity).State = EntityState.Modified;
                _context.Set<T>().Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while Updating the entity.", ex);
            }
        }
        public async Task DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var item = await _context.Set<T>().FirstOrDefaultAsync(expression);
            if (item == null)
            {
                throw new Exception("Entity not found.");
            }
            try
            {
                _context.Set<T>().Remove(item);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the entity.", ex);
            }
        }

        public async Task AddToArchiveAsync(Expression<Func<T, bool>> expression)
        {
            var item = await _context.Set<T>().FirstOrDefaultAsync(expression);
            if(item != null)
            {
                try
                {
                    _context.Entry(item).Property("IsDeleted").CurrentValue = true;
                    _context.Entry(item).Property("DeletedAt").CurrentValue = DateTime.Now;
                    _context.Set<T>().Update(item);
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while archiving the entity.", ex);
                }
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        
    }
}
