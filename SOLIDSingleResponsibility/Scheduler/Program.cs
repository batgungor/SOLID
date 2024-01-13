using Application.Infrastructure;
using Scheduler.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddApplicationLayer(builder.Configuration);
builder.Services.AddExternalServices(builder.Configuration);

var app = builder.Build();

app.Run();