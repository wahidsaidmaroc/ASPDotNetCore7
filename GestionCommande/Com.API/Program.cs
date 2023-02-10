global using Service;
using DAL.Data;
using Infrastructure;
using Infrastructure.SeedWorks;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var myconn = builder.Configuration.GetConnectionString("ConnectionStrings_DefaultConnection");


//La connection.
builder.Services.AddDbContextFactory<FormationOumdinAcademyContext>(options =>
options.UseSqlServer(myconn));



builder.Services.AddScoped<IClientService, ClientService>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

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
