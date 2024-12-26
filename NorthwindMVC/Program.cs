using Microsoft.EntityFrameworkCore;
using NorthwindMVC.Repository;

namespace NorthwindMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //register dbcontext to services
            builder.Services.AddDbContext<NorthwindContext>(opts =>
            {
                opts.UseSqlServer(builder.Configuration["ConnectionStrings:NorthwindDS"]);
            });

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            //call populate data
            PopulateData.PopulateDatas(app);
            
            app.Run();
        }
    }
}