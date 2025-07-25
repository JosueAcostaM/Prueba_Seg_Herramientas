using Sistema.API.Consumer;
using Modelos;
namespace MVC_Sistema
{
    public class Program
    {
        public static void Main (string[] args)
        {
            Crud<Usuario>.EndPoint = "https://localhost:7002/api/Usuarios";
            Crud<Tareas>.EndPoint = "https://localhost:7002/api/Tareas";
            Crud<Proyectos>.EndPoint = "https://localhost:7002/api/Proyectos";

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
                pattern: "{controller=Login}/{action=Registrar}/{id?}");

            app.Run();

        }
    }
}
