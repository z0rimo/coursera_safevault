using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SafeVault;
using System.Data;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddAuthNAuthZ();

// Dapper/DB
builder.Services.AddScoped<IDbConnection>(_ => new SqlConnection(
    builder.Configuration.GetConnectionString("DefaultConnection")
));

builder.Services.AddScoped<UserRepository>();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
