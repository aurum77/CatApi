using CatApi.Persistence.Context;
using CatApi.Persistence;
using Microsoft.EntityFrameworkCore;
using CatApi.Application.Repositories;
using CatApi.Persistence.Repositories;
using CatApi.Application;
using CatApi.Application.Services;
using CatApi.Persistence.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddApplicationServices();
builder.Services.AddDbContext<CatApiDbContext>(options => options.UseNpgsql(Configuration.PostgreSQLConnectionString));
builder.Services.AddScoped<ICatWriteRepository, CatWriteRepository>();
builder.Services.AddScoped<ICatReadRepository, CatReadRepository>();
builder.Services.AddScoped<ICatService, CatService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
