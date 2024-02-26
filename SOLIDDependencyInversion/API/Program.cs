using API.Business;
using API.Data.Contexts;
using API.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<UserRepository>();
//builder.Services.AddScoped<StaticDbContext>();
builder.Services.AddScoped<IDbContext, MongoDbContext>();

builder.Services.AddScoped<TokenManager>();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.Run();
