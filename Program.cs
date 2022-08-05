var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders().AddDebug();

var webapi = builder.Configuration["ConfigSettings:Webapi"];
var connstr = builder.Configuration["ConfigSettings:ConnStr"];

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Logger.LogWarning($"webapi is {webapi}");
app.Logger.LogInformation($"connstr is {connstr}");

app.Run();
