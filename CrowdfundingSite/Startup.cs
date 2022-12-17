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

        //начальная конфигурация приложения
        public OStartup(IConfiguration configuration) => Configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // подключаем конфиг из appsettings.json
            /* связывает раздел Project в файле appsettings с config файлом*/
            Configuration.Bind("Project", new Config());

            // подключаем нужный функционал приложения в качестве сервисов
            services.AddTransient<IСampaignItemsRepository, EFСampaignItemsRepository>();
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
            // в рамках одного http запроса может быть создано сколько угодно объектов (репозиториев)

            // подключаем контекст БД
            services.AddDbContext<Domain.DbContext>(x => x.UseSqlServer(Config.ConnectionString));

            // настраиваем Identity систему
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

            // настраиваем authentication cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "CrowdAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });

            // настраиваем политику AdminArea авторизации для Admin area
            services.AddAuthorization(x =>
            {
                /* добавялем политику с названием AdminArea, 
                 которая заключается в требовании от пользователя роли администратора */
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
                x.AddPolicy("UserArea", policy => { policy.RequireRole("user"); });
            });

            // добавляем поддержку контроллеров и представлений (MVC)
            services.AddControllersWithViews(x =>
            {
                // добавление соглашения, для области Admin передаем политику AdminArea
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
                x.Conventions.Add(new AdminAreaAuthorization("User", "UserArea"));
            })
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
            // совместимость с asp.net core 3.0

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

        // Подключение компонентов middleware - компонентов конвейера, которые отвечают за обработку запроса
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /*
             Компоненты middleware конфигурируются с помощью методов расширений Run, Map и Use объекта IApplicationBuilder, 
             Каждый компонент может быть определен как анонимный метод (встроенный inline компонент),
             либо может быть вынесен в отдельный класс.

             Далее - добавление компонентов middleware (app.UseXXX)
             */

            // если приложение в процессе разработки (еще не развернуто)
            if (env.IsDevelopment())
            {
                // то выводим информацию об ошибке, при наличии ошибки
                /*метод выводит подробные сообщения об ошибках.
                 * подобные сообщения нежелательны и могут раскрывать некоторые чувствительные данные,
                 * когда приложение уже развернуто на сервере*/
                app.UseDeveloperExceptionPage(); // компонент обработки ошибок
                // если в используемой базе данных есть ожидающие миграции (системы контроля версий), то применяем их
                app.UseMigrationsEndPoint();
            }
            else
            {
                // обработчик ошибок для обычных пользователей
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                // для улучшения безопасности приложения добавляет специальный заголовок ответа Strict-Transport-Security
                app.UseHsts();
            }

            // компоненты middleware
            // обработка ошибок HTTP
            app.UseStatusCodePages();
            // перенаправляет все запросы HTTP на HTTPS
            app.UseHttpsRedirection();
            // предоставляет поддержку обработки статических файлов
            app.UseStaticFiles();

            // добавляем возможности маршрутизации благодаря чему приложение может соотносить запросы с определенными маршрутами
            app.UseRouting(); // компонент маршрутизации

            // предоставляет поддержку аутентификации
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();


            // устанавливаем адреса, которые будут обрабатываться => определяем маршруты
            app.UseEndpoints(endpoints => // Компонент EndpointMiddleware
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("user", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                //название маршрута - default, паттерн - по умолчанию для контроллера Home, для действия Index, id - необязателен
                //если сегмент для контроллера не пришёл, т.е. site.com/ - главная страница
            });
        }
    }
}
