using Microsoft.EntityFrameworkCore;
using System;
using XoXo.Models;
using Microsoft.AspNetCore.Identity;

namespace XoXo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
     builder.Configuration.GetConnectionString("myconse")
      ));

                        builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<AppDbContext>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
                        app.UseAuthentication();;

            app.UseAuthorization();


                app.MapControllerRoute(
                  name: "area",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
          


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            //ÚÔÇä íÔÊÛá identity

            app.UseEndpoints(endpoint => endpoint.MapRazorPages());
            app.Run();
        }
    }
}