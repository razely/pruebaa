using Proyecto.Core.Servicios;

namespace MinimalAPI.Controladores
{
    public static class JugadorEndpoints
    {
        public static void RegistrarEndpointsJugador(this WebApplication app)
        {
            var jugadorServicios = new JugadorServicios();

            app.MapGet("/api/jugadores", () => jugadorServicios.ObtenerTodos());

            app.MapGet("/api/jugadores/{id:int}", (int id) =>
            {
                var jugador = jugadorServicios.ObtenerPorId(id);
                return jugador is not null ? Results.Ok(jugador) : Results.NotFound();
            });
        }
    }
}