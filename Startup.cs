using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using Assignment3.Authentication;
using Assignment3.Data;
using Assignment3.Services;


namespace Assignment3
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddHttpClient();
            services.AddHttpClient("webapi",client => {
                client.BaseAddress = new Uri(Configuration.GetSection("BaseAddress").Value);
            });
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAdultService,AdultService>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();


            services.AddAuthorization(options => {
                options.AddPolicy("SecurityLevel1", a =>
                a.RequireAuthenticatedUser().RequireClaim("Level", "1", "2"));

                options.AddPolicy("SecurityLevel2", a =>
                a.RequireAuthenticatedUser().RequireClaim("Level", "2"));
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}