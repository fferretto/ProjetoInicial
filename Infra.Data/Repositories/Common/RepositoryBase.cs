using Domain.Interface.Repository.Common;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Infra.Data.Repositories.Common
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity>
        where TEntity : class
    {
        protected ContextDB DbEstudo; 
        private readonly DbSet<TEntity> _dbSet;

        public RepositoryBase(ContextDB context)
        {
            DbEstudo = context;
            Connectionstring = context.ConnectionString;
            _dbSet = DbEstudo.Set<TEntity>();
        }

        protected DbSet<TEntity> DbSet
        {
            get { return _dbSet; }
        }

        protected virtual int GetInitialSeed()
        {
            return 0;
        }

        public string Connectionstring { get; }

        public void Dispose()
        {

                DbEstudo.Dispose();
        }

        public void Add(TEntity obj)
        {
                DbEstudo.Set<TEntity>().Add(obj);
                DbEstudo.SaveChanges();
        }
        public async void AddAsync(TEntity obj)
        {
                //DbEstudo.Set<TEntity>().Add(obj);
                DbEstudo.Entry(obj).State = EntityState.Added;
                await DbEstudo.SaveChangesAsync();
        }
        public IEnumerable<TEntity> ExecStoreProcedure(string procedure, params object[] parametros)
        {
            var dados = DbSet.FromSql(procedure, parametros);

            return dados;
        }


        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);

        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = DbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty.Trim());
            }
            return query.ToList();

        }

        public IEnumerable<TEntity> GetAll()
        {
                return DbEstudo.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
                return DbEstudo.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
                DbEstudo.Set<TEntity>().Remove(obj);
                DbEstudo.SaveChanges();
        }

        public void RemoveRanger(IEnumerable<TEntity> List)
        {
                DbEstudo.Set<TEntity>().RemoveRange(List);
        }

        public void Update(TEntity obj)
        {
                DbEstudo.Entry(obj).State = EntityState.Modified;
                DbEstudo.SaveChanges();


        }

    }
}

