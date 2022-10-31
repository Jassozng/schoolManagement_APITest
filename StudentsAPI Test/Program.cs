using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using static StudentsAPI_Test.Models.IdentityModels;

var builder = WebApplication.CreateBuilder(args);

// Conn string retrieve
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("ApplicationContext")));


// Controllers
builder.Services.AddControllers();

// Swagger/OpenAPI config
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
