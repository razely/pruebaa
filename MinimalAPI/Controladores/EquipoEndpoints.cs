using Proyecto.Core.Servicios;

namespace MinimalAPI.Controladores
{
    public static class EquipoEndpoints
    {
        public static void RegistrarEndpointsEquipo(this WebApplication app)
        {
            var equipoServicios = new EquipoServicios();

            app.MapGet("/api/equipos", () => equipoServicios.ObtenerTodos());

            app.MapGet("/api/equipos/{id:int}", (int id) =>
            {
                var equipo = equipoServicios.ObtenerPorId(id);
                return equipo is not null ? Results.Ok(equipo) : Results.NotFound();
            });
        }
    }
}