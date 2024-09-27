using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

var builder = WebApplication.CreateBuilder(args);


//ConnectOracle String 1
builder.Services.AddDbContext<AuthenDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContextDb_1") ?? throw new InvalidOperationException("Connection string 'APIContext' not found.")));

//ConnectOracle String 2
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContextDb_2") ?? throw new InvalidOperationException("Connection string 'APIContext' not found.")));

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
