﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Trello.DataAccess.Context;
using Trollo.Entities.Repositories;

namespace Trello.DataAccess.Repositories
{
    internal class Repository<T> : IRepository<T>
    where T : class
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _context.Set<T>().AddAsync(entity, cancellationToken);
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
        {
            return await _context.Set<T>().AnyAsync(expression, cancellationToken);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().Where(expression).FirstOrDefaultAsync(cancellationToken);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().AsNoTracking().Where(expression).AsQueryable();
        }

        public void Remove(T entity)
        {
            _context.Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
