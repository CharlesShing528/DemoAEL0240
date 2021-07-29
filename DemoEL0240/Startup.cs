using DemoEL0240.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.FileProviders;
using System.IO;
using DemoEL0240.Data;

namespace DemoEL0240
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
            services.AddControllersWithViews();

            #region TempData Provider ��� Session�覡
            //services.AddControllersWithViews().AddSessionStateTempDataProvider();
            //services.AddSession();
            #endregion
            //�bDI Container�����UDeveloperOptions���O
            services.Configure<DeveloperOptions>(options =>
            Configuration.GetSection("Developer").Bind(options));

            services.AddDbContext<FriendContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("FriendContext")));

            services.AddDbContext<EmpBootstrapContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("EmpBootstrapContext")));

            services.AddDbContext<CardContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("CardContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            #region ContentRoot �M WebRoot ���|�վ�i�b 2.��Middleware  �]�w�R�A�ɥؿ�
            app.UseStaticFiles(); //for the wwwroot folder

            /*
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "StaticFilesLibrary"))
            });
            */
            #region �Υ[��RequestPath �ݩʳ]�w�u�v�ؿ��W�١G

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "StaticFilesLibrary")),
                RequestPath = "/StaticFiles"
            });
            #endregion
            #endregion

            // �ϥ� Endpoint ���I���Ѥ����n��
            app.UseRouting();

            app.UseAuthorization();
            #region TempData Provider ��� Session�覡
            //app.UseSession();
            #endregion
            app.UseEndpoints(endpoints =>
            {
                //Area註冊必須在default路由前面

                endpoints.MapControllerRoute(
                    name: "MyBlogs",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                #region ���ѩw�q
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                #endregion
            });
        }
    }
}
