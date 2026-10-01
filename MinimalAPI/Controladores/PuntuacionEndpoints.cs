using Proyecto.Core.Servicios;

namespace MinimalAPI.Controladores
{
    public static class PuntuacionEndpoints
    {
        public static void RegistrarEndpointsPuntuacion(this WebApplication app)
        {
            var puntuacionServicios = new PuntuacionServicios();

            app.MapGet("/api/plantillas/{idPlantilla:int}/puntaje-total", (int idPlantilla) =>
            {
                var puntajeTotal = puntuacionServicios.CalcularPuntaje(idPlantilla);
                return Results.Ok(new { IdPlantilla = idPlantilla, PuntajeTotal = puntajeTotal });
            });
        }
    }
}