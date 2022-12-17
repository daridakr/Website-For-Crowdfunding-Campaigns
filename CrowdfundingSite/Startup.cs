using CrowdfundingSite.CloudStorage;
using CrowdfundingSite.Domain;
using CrowdfundingSite.Domain.Entities;
using CrowdfundingSite.Domain.Repositories.Abstract;
using CrowdfundingSite.Domain.Repositories.EntityFramework;
using CrowdfundingSite.Service;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Owin.Logging;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingSite
{
    public class OStartup
    {
        public IConfiguration Configuration { get; }

        //��������� ������������ ����������
        public OStartup(IConfiguration configuration) => Configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // ���������� ������ �� appsettings.json
            /* ��������� ������ Project � ����� appsettings � config ������*/
            Configuration.Bind("Project", new Config());

            // ���������� ������ ���������� ���������� � �������� ��������
            services.AddTransient<I�ampaignItemsRepository, EF�ampaignItemsRepository>();
            services.AddTransient<IUsersRepository, EFUsersRepository>();
            services.AddTransient<INewsRepository, EFNewsRepository>();
            services.AddTransient<ICommentsRepository, EFCommentsRepository>();
            services.AddTransient<IBonusItemsRepository, EFBonusItemsRepository>();
            services.AddTransient<ITagsRepository, EFTagsRepository>();
            services.AddTransient<ISubjectsRepository, EFSubjectsRepository>();
            services.AddTransient<ICampaignImagesRepository, EFCampaignImagesRepository>();
            services.AddTransient<IRatingRepository, EFRatingRepository>();
            services.AddTransient<IUserService, UserService>();
            services.AddSingleton<ICloudStorage, CloudinaryStorage>();
            services.AddTransient<DataManager>();
            // � ������ ������ http ������� ����� ���� ������� ������� ������ �������� (������������)

            // ���������� �������� ��
            services.AddDbContext<Domain.DbContext>(x => x.UseSqlServer(Config.ConnectionString));

            // ����������� Identity �������
            services.AddIdentity<CrowdUser, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = true;
                options.SignIn.RequireConfirmedEmail = false;
            }).AddEntityFrameworkStores<Domain.DbContext>().AddDefaultTokenProviders();

            // ����������� authentication cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "CrowdAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });

            // ����������� �������� AdminArea ����������� ��� Admin area
            services.AddAuthorization(x =>
            {
                /* ��������� �������� � ��������� AdminArea, 
                 ������� ����������� � ���������� �� ������������ ���� �������������� */
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
                x.AddPolicy("UserArea", policy => { policy.RequireRole("user"); });
            });

            // ��������� ��������� ������������ � ������������� (MVC)
            services.AddControllersWithViews(x =>
            {
                // ���������� ����������, ��� ������� Admin �������� �������� AdminArea
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
                x.Conventions.Add(new AdminAreaAuthorization("User", "UserArea"));
            })
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
            // ������������� � asp.net core 3.0

            services.AddAuthentication()
                    //.AddFacebook(options =>
                    //{
                    //    options.AppId = Configuration["auth:facebook:appid"];
                    //    options.AppSecret = Configuration["auth:facebook:appsecret"];
                    //})
                    .AddGoogle(options =>
                    {
                        options.ClientId = "610094350472-3ta3u7pv420b37b0347h2empv6fsepgr.apps.googleusercontent.com";
                        options.ClientSecret = "fOQt8mn3lQJs10xyJTn2FLQq";
                        options.SignInScheme = IdentityConstants.ExternalScheme;
                    });
        }

        // ����������� ����������� middleware - ����������� ���������, ������� �������� �� ��������� �������
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /*
             ���������� middleware ��������������� � ������� ������� ���������� Run, Map � Use ������� IApplicationBuilder, 
             ������ ��������� ����� ���� ��������� ��� ��������� ����� (���������� inline ���������),
             ���� ����� ���� ������� � ��������� �����.

             ����� - ���������� ����������� middleware (app.UseXXX)
             */

            // ���� ���������� � �������� ���������� (��� �� ����������)
            if (env.IsDevelopment())
            {
                // �� ������� ���������� �� ������, ��� ������� ������
                /*����� ������� ��������� ��������� �� �������.
                 * �������� ��������� ������������ � ����� ���������� ��������� �������������� ������,
                 * ����� ���������� ��� ���������� �� �������*/
                app.UseDeveloperExceptionPage(); // ��������� ��������� ������
                // ���� � ������������ ���� ������ ���� ��������� �������� (������� �������� ������), �� ��������� ��
                app.UseMigrationsEndPoint();
            }
            else
            {
                // ���������� ������ ��� ������� �������������
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                // ��� ��������� ������������ ���������� ��������� ����������� ��������� ������ Strict-Transport-Security
                app.UseHsts();
            }

            // ���������� middleware
            // ��������� ������ HTTP
            app.UseStatusCodePages();
            // �������������� ��� ������� HTTP �� HTTPS
            app.UseHttpsRedirection();
            // ������������� ��������� ��������� ����������� ������
            app.UseStaticFiles();

            // ��������� ����������� ������������� ��������� ���� ���������� ����� ���������� ������� � ������������� ����������
            app.UseRouting(); // ��������� �������������

            // ������������� ��������� ��������������
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();


            // ������������� ������, ������� ����� �������������� => ���������� ��������
            app.UseEndpoints(endpoints => // ��������� EndpointMiddleware
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("user", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                //�������� �������� - default, ������� - �� ��������� ��� ����������� Home, ��� �������� Index, id - ������������
                //���� ������� ��� ����������� �� ������, �.�. site.com/ - ������� ��������
            });
        }
    }
}
