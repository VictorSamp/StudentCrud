using Microsoft.EntityFrameworkCore;
using StudentCrud.Domain.CommandHandlers;
using StudentCrud.Domain.Interfaces.CommandHandlers;
using StudentCrud.Domain.Interfaces.Repository;
using StudentCrud.Infraestructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ICreateStudentCommandHandler, CreateStudentCommandHandler>();
builder.Services.AddTransient<IStudentRepository, StudentRepository>();
builder.Services.AddDbContext<StudentCrudDbContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("StudentCrudWriteModel");
    options.UseSqlServer(connectionString, providerOptions => providerOptions.EnableRetryOnFailure());
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