using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Core.Entitites;
using YoutubeBlog.Data.Repostories.Abstractions;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.UnitOfWork
{
     public  interface IUnitOfWork :IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T:class,IEntityBase,new();

        Task<int> SaveAsync();
        int Save();

    }
}
