using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyWorkShop.AppData;
using MyWorkShop.Entities;
using MyWorkShop.Interfaces;
using MyWorkShop.Repository;
using MyWorkShop.Services;

namespace MyWorkShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //настройка соединения с бд
            services.AddDbContext<DbWorkShopContext>(options =>
            options.UseSqlServer(
            Configuration.GetConnectionString("DefaultConnection")));       //Строка соединения находится в .json

            services.AddTransient<IMainServices, MainServices>();
            
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IMaintenanceService, MaintenanceService>();
            services.AddTransient<IForumService, ForumService>();
            services.AddTransient<ITransactionLogService, TransactionLogService>();


            services.AddTransient<IGenericRepository<ShopProducts>, GenericRepository<ShopProducts>>();
            services.AddTransient<IGenericRepository<Files>, GenericRepository<Files>>();
            services.AddTransient<IGenericRepository<ShopServices>, GenericRepository<ShopServices>>();
            services.AddTransient<IGenericRepository<Forum>, GenericRepository<Forum>>();
            services.AddTransient<IGenericRepository<TransactionLog>, GenericRepository<TransactionLog>>();
            services.AddTransient<IGenericRepository<ServiceApplication>, GenericRepository<ServiceApplication>>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
