using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    options =>
    {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1.0",
                Title = "Api CI CD",
                Description = "Esta es una aplicacion que tiene un pipeline para integracion continua 2, el pipeline de publicacion se dispara al hacer un cambio en la rama 'main del proyecto' prueba con repositorio de Github",
                TermsOfService = new Uri("https://example.com/terms"),
                Contact = new OpenApiContact
                {
                    Name = "Example Contacto",
                    Url = new Uri("https://example.com/contact")
                },
                License = new OpenApiLicense
                {
                    Name = "Ejemplo de liciencia",
                    Url = new Uri("https://example.com/license")
                }
            });
        }
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
