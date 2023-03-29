
namespace proofConceptWeb

{
    using Microsoft.EntityFrameworkCore;
    using proofConceptDB.Context;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            Microsoft.Extensions.Configuration.ConfigurationManager configuration = builder.Configuration;

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<proofConceptContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MainConnectionString"), op =>
                    op.CommandTimeout(Convert.ToInt32(configuration.GetSection("SqlTimeout").Value)));
            });

            //add services:
            //builder.services.addscoped<>();


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

            app.Run();

            proofConceptDB.Data.AppDbInitializer.Seed(app);

        }
    }
}