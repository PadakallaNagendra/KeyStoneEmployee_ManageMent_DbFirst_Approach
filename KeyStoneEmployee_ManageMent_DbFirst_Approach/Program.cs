using KeyStoneEmployee_ManageMent_BusinessObject.InterFace;
using KeyStoneEmployee_ManageMent_DataBaseLogic.DbConnect;
using KeyStoneEmployee_ManageMent_RepositaryLayer;
using KeyStoneEmployee_ManageMent_ServiceLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepositary, UserRegistationRepositary>();
builder.Services.AddScoped<IUserService, UserServiceLayer>();
builder.Services.AddDbContext<NagendraDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("NagendraConnection")));


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
