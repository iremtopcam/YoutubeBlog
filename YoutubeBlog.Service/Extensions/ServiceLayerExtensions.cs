using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repostories.Abstractions;
using YoutubeBlog.Data.Repostories.Concretes;
using YoutubeBlog.Data.UnitOfWork;
using YoutubeBlog.Service.FluentValidations;
using YoutubeBlog.Service.Services.Abstractions;
using YoutubeBlog.Service.Services.Concrete;

namespace YoutubeBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService,_articleService>();
            services.AddScoped<ICategoryService,CategoryService>();
            services.AddAutoMapper(assembly);


            //services.AddControllersWithViews().AddFluentValidation(opt =>
            //   {
            //       opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
            //       opt.DisableDataAnnotationsValidation = true;
            //       opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
            //   });



            return services;
        }


    }
}
