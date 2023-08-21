using DojoKitao.Data.Dados.Daos;
using DojoKitao.Data.Dados.Daos.EfCore;
using DojoKitao.Data.Services;
using DojoKitao.Data.Services.Handlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DojoKitaoContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DojoKitaoConnection")));

builder.Services.AddTransient<IAlunoDao, AlunoDao>();
builder.Services.AddTransient<IAulaDao, AulaDao>();
builder.Services.AddTransient<IAdminService, DefaultAdminService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
