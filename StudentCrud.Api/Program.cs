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
builder.Services.AddTransient<IEventStoreRepository, EventStoreRepository>();

builder.Services.AddDbContext<StudentCrudEventStoreContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("StudentCrudEventStoreDb"),
            x => x.MigrationsAssembly("StudentCrud.Infraestructure")));

builder.Services.AddDbContext<StudentCrudReadModelContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("StudentCrudReadModelDb"),
            x => x.MigrationsAssembly("StudentCrud.Infraestructure")));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();
app.Run();