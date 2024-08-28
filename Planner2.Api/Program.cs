using Microsoft.EntityFrameworkCore;
using Planner2.Data.DataContext;
using Planner2.Data.Repo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PlannerContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("Database")));

builder.Services.AddTransient<IUserRepo, UserRepo>();
//builder.Services.AddTransient<IUserCredentialsRepo, UserCredentialsRepo>();

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
