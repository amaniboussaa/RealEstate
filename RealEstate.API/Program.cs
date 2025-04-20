using Microsoft.EntityFrameworkCore;
using RealEstate.Application.Interface;
using RealEstate.Application.Service;
using RealEstate.Domain.Interface;
using RealEstate.Infrastructure.Data;
using RealEstate.Infrastructure.Repository;


using RealEstate.Application;

var builder = WebApplication.CreateBuilder(args);
// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        policy =>
        {
            policy.WithOrigins("http://localhost:3000") 
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPropertyRepository, PropertyRepository>();
builder.Services.AddScoped<IPropertyService, PropertyService>();
builder.Services.AddDbContext<DataContext>();
var app = builder.Build();
// Enable CORS
app.UseCors("CorsPolicy");
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
