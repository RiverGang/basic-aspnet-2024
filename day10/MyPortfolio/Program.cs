using Microsoft.EntityFrameworkCore;
using MyPortfolio.Data;

namespace MyPortfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // DbContext 종속성 주입
            builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer( // <> 내부 내용 -> Data 폴더에서 정의한 클래스
                builder.Configuration.GetConnectionString("MyConnection") // appsettings.json에서 정의한 이름
                ));

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
                // URL패턴 : http://localhost:port/controller이름/action이름/[id](옵션)
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
