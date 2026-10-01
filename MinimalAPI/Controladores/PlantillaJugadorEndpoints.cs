using Proyecto.Core.Servicios;
using Proyecto.Core.Models;

namespace MinimalAPI.Controladores
{
    public static class PlantillaJugadorEndpoints
    {
        public static void RegistrarEndpointsPlantillaJugador(this WebApplication app)
        {
            var plantillaJugadorServicios = new PlantillaJugadorServicios();

            app.MapGet("/api/plantillas/{idPlantilla:int}/jugadores", (int idPlantilla) =>
            {
                var jugadores = plantillaJugadorServicios.ObtenerPorPlantilla(idPlantilla);
                return Results.Ok(jugadores);
            });

            app.MapPost("/api/plantillajugador", (PlantillaJugador plantillaJugador) =>
            {
                plantillaJugadorServicios.AgregarJugadorAPlantilla(plantillaJugador);
                return Results.Ok(plantillaJugador);
            });
        }
    }
}