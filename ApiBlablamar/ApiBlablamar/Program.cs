using ApiBlablamar.Data;
using ApiBlablamar.Repositories;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Lee la cadena de conexión y registra el DbContext
string connectionString = builder.Configuration.GetConnectionString("SqlBlaBlaMar")!;
builder.Services.AddDbContext<BlaBlaMarContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<RepositoryEventos>();
builder.Services.AddScoped<RepositoryCaracteristicas>();
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();