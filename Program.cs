using Microsoft.EntityFrameworkCore;
using UnitOfWorkRepositoryPattern;
using UnitOfWorkRepositoryPattern.Context;
using UnitOfWorkRepositoryPattern.Interfaces.UnitOfWork;
using UnitOfWorkRepositoryPattern.UnitOfWorks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:SqlServer"]);
});

builder.Services.AddServiceRegistiration();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();
app.UseHttpsRedirection();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();

