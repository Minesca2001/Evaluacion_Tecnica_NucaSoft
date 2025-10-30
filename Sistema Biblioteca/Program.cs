using Microsoft.EntityFrameworkCore;
using Sistema_Biblioteca.Context;
using Sistema_Biblioteca.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("ConexionBiblioteca");
builder.Services.AddDbContext<BibliotecaContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddControllers();

var app = builder.Build();

// Esta variable inicializa los datos automáticamente
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<BibliotecaContext>();
    DatosIniciales.CargarDatos(context);
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
