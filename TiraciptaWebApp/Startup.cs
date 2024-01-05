using TiraciptaWebApp.BusinessLogic;

namespace TiraciptaWebApp
{
    public class Startup
    {
        public IConfiguration _configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureService(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<ICustomerServiceApp, CustomerServiceApp>();
            services.AddScoped<ISalesOrderServiceApp, SalesOrderServiceApp>();
            services.AddScoped<IProductServiceApp, ProductServiceApp>();
            services.AddScoped<IPriceServiceApp, PriceServiceApp>();
            services.AddScoped<ISalesOrderInterfaceServiceApp, SalesOrderInterfaceServiceApp>();
            services.AddHttpClient("TiraciptaAPI",
                client =>
                {
                    client.BaseAddress = new Uri("http://localhost:5188");
                });
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
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
                pattern: "{controller=SalesOrderApp}/{action=CreateSalesOrder}/{id?}");

            app.Run();

        }
    }
}
