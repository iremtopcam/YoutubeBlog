using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repostories.Abstractions;
using YoutubeBlog.Data.Repostories.Concretes;

namespace YoutubeBlog.Data.UnitOfWork
{
    public class UnitofWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;
        public UnitofWork(AppDbContext dbContext)
        { 
        
            this.dbContext = dbContext;
        
        }

        public async ValueTask DisposeAsync()
        {
            await dbContext.DisposeAsync();
        }

        public  int Save()
        {
           return dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new Repository<T>(dbContext);
        }
    }
}
