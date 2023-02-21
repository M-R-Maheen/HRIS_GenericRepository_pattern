using HRIS.DatabaseContext;
using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected HRISdbContext hrisDbContext;

        internal DbSet<T> dbSet { get; set; }

        public GenericRepository(HRISdbContext dbContext)
        {
            this.hrisDbContext = dbContext;
            this.dbSet=this.hrisDbContext.Set<T>();
        }

        public virtual Task<bool> AddEntity(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }


        public virtual Task<List<T>> GetAllAsync()
        {
            return this.dbSet.ToListAsync();
        }


        public virtual Task<T> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> UpdateEntity(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
