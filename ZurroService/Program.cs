using Microsoft.EntityFrameworkCore;
using ZurroService.Data;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ZurroDBContext>(opt => 
                                              opt.UseMySql(builder.Configuration.
                                              GetConnectionString(Info.Conexion),
                                              new MySqlServerVersion(new Version(Info.MySQLVersion))));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
