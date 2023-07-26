using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repostories.Abstractions;
using YoutubeBlog.Data.Repostories.Concretes;

namespace YoutubeBlog.Data.Extensions
{
    public static class DataLayerExtension
    {
        //public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
        //{
        //    //her repositorye istek yolladiğimizde repository nesnesini getir
        //    services.AddScoped(typeof(IRepository<>), typeof(IRepository<>));

        //    services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
        //    return services;

        //}

        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }


    }
}
