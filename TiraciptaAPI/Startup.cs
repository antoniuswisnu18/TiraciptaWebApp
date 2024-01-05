using Microsoft.EntityFrameworkCore;
using TiraciptaAPI.Business_Logic.Repositories;
using TiraciptaAPI.Business_Logic.Services;
using TiraciptaAPI.Models;

namespace TiraciptaAPI
{
    public class Startup
    {
        public IConfiguration _configuration { get; }
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<ICustomerService,CustomerService>();
            services.AddScoped<ICustomerRepo,CustomerRepo>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepo, ProductRepo>();
            services.AddScoped<IPriceService, PriceService>();
            services.AddScoped<IPriceRepo, PriceRepo>();
            services.AddScoped<ISalesOrderRepo, SalesOrderRepo>();
            services.AddScoped<ISalesOrderService, SalesOrderService>();
            services.AddScoped<ISalesOrderInterfaceRepo, SalesOrderInterfaceRepo>();
            services.AddScoped<ISalesOrderInterfaceService, SalesOrderInterfaceService>();
            services.AddDbContext<DbTesWisnuContext>(
                options => options.UseSqlServer(_configuration["ConnectionStrings:DefaultConnection"])
                );
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAnyOriginPolicy",
                    builder => builder.AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader());
            });
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("AllowAnyOriginPolicy");
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
            app.MapGet("/", () =>
            {
                return "Hello World";
            });

            app.Run();
        }
    }
}
