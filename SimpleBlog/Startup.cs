﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SimpleBlog.Dal.Abstract;
using SimpleBlog.Dal.Concrete.EntityFramework;
using SimpleBlog.Bll.Abstract;
using SimpleBlog.Bll.Concrete;

namespace SimpleBlog
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddScoped<IPostDal, EfPostDal>();
            services.AddScoped<IAuthorDal, EfAuthorDal>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService,CategoryManager >();
            services.AddScoped<IPostService, PostManager>();
            services.AddScoped<IAuthorService, AuthorManager>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(
                route => route.MapRoute(
                    name: "Default",
                    template: "{controller=base}/{action=index}/{id?}"
                ));
        }
    }
}
