using Microsoft.EntityFrameworkCore;
using PruebaTecnicaPG.Data;
using PruebaTecnicaPG.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuro EF en memoria
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("ClientesDB"));

//Agrego CORS para comunicacion entre componentes
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy.WithOrigins("http://localhost:59296")
            .AllowAnyMethod()
            .AllowAnyHeader());
});

var app = builder.Build();

//Uso politica de CORS
app.UseCors("AllowAngular");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//Creo los datos en memoria para pruebas
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    if (!context.Clientes.Any())
    {
        context.Clientes.AddRange(
                new Cliente { Id = 1, Nombre = "Juan Perez", Telefono = "56912345678", Pais = "Chile" },
                new Cliente { Id = 2, Nombre = "María Lopez", Telefono = "56987654321", Pais = "Chile" },
                new Cliente { Id = 3, Nombre = "Carlos Garcia", Telefono = "56911223344", Pais = "Chile" },
                new Cliente { Id = 4, Nombre = "Ana Fernandez", Telefono = "56955667788", Pais = "Chile" },
                new Cliente { Id = 5, Nombre = "Cristiano Ronaldo", Telefono = "56912345678", Pais = "Chile" },
                new Cliente { Id = 6, Nombre = "Charles Aranguiz", Telefono = "56987654321", Pais = "Chile" },
                new Cliente { Id = 7, Nombre = "Marco Aurelio", Telefono = "56911223344", Pais = "Chile" },
                new Cliente { Id = 8, Nombre = "Abbath Immortal", Telefono = "56955667788", Pais = "Chile" },
                 new Cliente { Id = 9, Nombre = "Kirk Hammett", Telefono = "56912345678", Pais = "Chile" },
                new Cliente { Id = 10, Nombre = "Magnus Carlsen", Telefono = "56987654321", Pais = "Chile" },
                new Cliente { Id = 11, Nombre = "Ritchie Blackmore", Telefono = "56911223344", Pais = "Chile" },
                new Cliente { Id = 12, Nombre = "Dave Mustaine", Telefono = "56912345678", Pais = "Chile" }
        );
        context.SaveChanges();
        Console.WriteLine("Datos insertados en la base de datos.");
    }
}

app.Run();


