using Pool.Core;
using Pool.Core.models;
using Pool.Core.Repositories;
using Pool.Core.Services;
using Pool.Data;
using Pool.Data.Repositories;
using Pool.Service;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();

builder.Services.AddScoped<IActivityService ,ActivityService>();
builder.Services.AddScoped<IActivityRepository, ActivityRepository>();

builder.Services.AddScoped<IGuideService , GuideService>();
builder.Services.AddScoped<IGuideRepository, GuideRepository>();

builder.Services.AddScoped<ISwimmerService , SwimmerService>();
builder.Services.AddScoped<ISwimmerRepository, SwimmerRepository>();


builder.Services.AddDbContext<DataContext>();
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

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
