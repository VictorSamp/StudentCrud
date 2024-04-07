using Microsoft.EntityFrameworkCore;
using StudentCrud.Domain.Interfaces.Repository;
using StudentCrud.Infraestructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
builder.Services.AddTransient<IStudentRepository, StudentRepository>();

builder.Services.AddDbContext<StudentCrudDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("StudentCrudWriteModelDb"),
            x => x.MigrationsAssembly("StudentCrud.Infraestructure")));
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