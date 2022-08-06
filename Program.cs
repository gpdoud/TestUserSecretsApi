var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders().AddDebug().SetMinimumLevel(LogLevel.Trace);

var webapi = builder.Configuration["AppSettings:Webapi"];
var connstr = builder.Configuration["AppSettings:ConnStr"];
var dbuser = builder.Configuration["AppSettings:DbUser"];
var dbpassword = builder.Configuration["AppSettings:DbPassword"];
var connectionStr = new Microsoft.Data.SqlClient.SqlConnectionStringBuilder(connstr);
connectionStr.UserID = dbuser;
connectionStr.Password = dbpassword;
connectionStr.TrustServerCertificate = true;

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Logger.LogWarning($"webapi is {webapi}");
app.Logger.LogTrace($"connstr is {connstr}");
app.Logger.LogInformation($"connection string is {connectionStr.ToString()}");

app.Run();
