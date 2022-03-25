using AutoMapper;
using E_commerce.API.Data;
using E_commerce.API.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigins",
        policy =>
        {
            policy.WithOrigins(builder.Configuration["AllowedHosts"])
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MedicineContext>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("MedicineContext")));
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<MapperProfile>());
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseHttpsRedirection();

app.UseCors("AllowOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
