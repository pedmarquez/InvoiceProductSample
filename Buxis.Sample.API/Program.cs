using Buxis.Sample.API;
using Buxis.Sample.API.Services;
using Buxis.Sample.ApplicationCore.Interfaces;
using Buxis.Sample.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BuxiDbContext>(dbBuilder => dbBuilder.UseSqlServer(builder.Configuration.GetConnectionString("MiConnectionString")));

builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IInvoiceService, InvoiceService>();

builder.Services.AddHostedService<DbWorker>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
