using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CORE_PROJE
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
            services.AddControllersWithViews().AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<PortfolioValidator>());
            //services.AddScoped(typeof( IGenericRepository<>),typeof( GenericRepository<>));
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IAboutRepository, AboutRepository>();
            //services.AddScoped<IContactRepository, ContactRepository>();
            //services.AddScoped<IExperienceRepository, ExperienceRepository>();
            //services.AddScoped<IFeatureRepository, FeatureRepository>();
            //services.AddScoped<IMessageRepository, MessageRepository>();
            //services.AddScoped<IPortfolioRepository, PortfolioRepository>();
            //services.AddScoped<IServiceRepository, ServiceRepository>();
            //services.AddScoped<ISkillRepository, SkillRepository>();
            //services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();
            //services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            //services.AddScoped<IToDoListRepository, ToDoListRepository>();
            //services.AddScoped<IAnnouncementRepository, AnnouncementRepository>();
            //services.AddScoped<IWriterMessageRepository, WriterMessageRepository>();
            //services.AddScoped<IWriterUserRepository, WriterUserRepository>();
            //services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            //services.AddScoped<IFeatureService, FeatureService>();
            //services.AddScoped<IAboutService, AboutService>();
            //services.AddScoped<IContactService, ContactService>();
            //services.AddScoped<IExperienceService, ExperienceService>();
            //services.AddScoped<IMessageService, MessageService>();
            //services.AddScoped<IPortfolioService, PortfolioService>();
            //services.AddScoped<IServiceService, ServiceService>();
            //services.AddScoped<ISkillService, SkillService>();
            //services.AddScoped<ISocialMediaService, SocialMediaService>();
            //services.AddScoped<ITestimonialService, TestimonialService>();
            //services.AddScoped<IToDoListService, ToDoListManager>();
            //services.AddScoped<IAnnouncementService, AnnouncementService>();
            //services.AddScoped<IWriterMessageService, WriterMessageService>();
            //services.AddScoped<IWriterUserService, WriterUserService>();

           
            services.AddDbContext<Context>(x =>
            {
                x.UseSqlServer(Configuration.GetConnectionString("SqlConnection"), option =>
                {
                    option.MigrationsAssembly(Assembly.GetAssembly(typeof(Context)).GetName().Name);
                });
            });
            services.AddIdentity<WriterUser, WriterRole>().AddEntityFrameworkStores<Context>();

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                            .RequireAuthenticatedUser()
                            .Build();
                config.Filters.Add(new AuthorizeFilter(policy));

            });

            services.AddMvc();
            //services.AddAuthentication(
            //    CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(x =>
            //    {
            //        x.LoginPath = "/AdminLogin/Index/";
            //    });

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(100);
                options.AccessDeniedPath = "/ErrorPage/Index/";
                options.LoginPath = "/Writer/Login/Index/";
            });
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
            }
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404/");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
                );
            });
        }
    }
}
