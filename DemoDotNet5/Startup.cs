using DemoDotNet5.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OA.Data;
using OA.Repo;
using OA.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5
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
            // Add DbContextPool thay vì DbContext để tăng hiệu năng
            services.AddDbContextPool<EShopDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DemoDotNet5ContextConnection"))
            );
            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<EShopDbContext>();

            // Đăng ký dịch vụ
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            // Đăng ký dịch vụ
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();

            services.AddControllersWithViews();
            services.AddRazorPages();

            // Đăng ký sử dụng Session
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                // Phiên hết hạn (Session Time out)
                options.IdleTimeout = TimeSpan.FromSeconds(100);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            // Setting Auto Mapper
            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews();

            // Setting Policy
            services.AddAuthorization(options =>
            {
                // Thêm Policy có quyền Administrator
                options.AddPolicy("Administrator", policyBuilder =>
                {
                    // Phải đăng nhập
                    policyBuilder.RequireAuthenticatedUser();
                    // Có vai trò là Administrator
                    policyBuilder.RequireRole("Administrator");
                    // Notes : Claim tức là những tính chất của Role

                });

                // Thêm policy có quyền ManagerStore
                options.AddPolicy("ManagerStore", policyBuilder =>
                {
                    policyBuilder.RequireAuthenticatedUser();
                    policyBuilder.RequireRole("Administrator", "||" , "ManagerStore");
                });

            });


            // Đăng ký dịch vụ sử dụng In-memory cache
            services.AddMvc();
            services.AddMemoryCache();
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
            app.UseStaticFiles();
            app.UseStatusCodePages(); // Thông báo lỗi từ 400 đến 599

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            // Đăng ký sử dụng session
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
