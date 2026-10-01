using Proyecto.Core.Servicios;
using Proyecto.Core.Models;

namespace MinimalAPI.Controladores
{
    public static class PlantillaEndpoints
    {
        public static void RegistrarEndpointsPlantilla(this WebApplication app)
        {
            var plantillaServicios = new PlantillaServicios();

            app.MapGet("/api/plantillas/usuario/{idUsuario:int}", (int idUsuario) =>
            {
                var plantilla = plantillaServicios.ObtenerPorUsuario(idUsuario);
                return plantilla is not null ? Results.Ok(plantilla) : Results.NotFound();
            });

            app.MapPost("/api/plantillas", (Plantilla plantilla) =>
            {
                plantillaServicios.CrearPlantilla(plantilla);
                return Results.Created($"/api/plantillas/{plantilla.IdPlantilla}", plantilla);
            });
        }
    }
}