using TiraciptaAPI;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
startup.ConfigurationServices(builder.Services);

var app = builder.Build();
startup.Configure(app, builder.Environment);
