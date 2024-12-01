using Microsoft.EntityFrameworkCore;
using WRProyectoCompletoAPI.Data;


var builder = WebApplication.CreateBuilder(args);

// Register the correct DbContext to use SQL Server connection string
builder.Services.AddDbContext<WRProyectoCompletoAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WRproyectoCompletoContext")));

builder.Services.AddControllers();

// Add services for Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();