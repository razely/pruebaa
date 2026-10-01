using Proyecto.Core.Servicios;
using Proyecto.Core.Models;

namespace MinimalAPI.Controladores
{
    public static class UsuarioEndpoints
    {
        public static void RegistrarEndpointsUsuario(this WebApplication app)
        {
            var usuarioServicios = new UsuarioServicios();

            app.MapPost("/api/usuarios/login", (string email, string pass) =>
            {
                var usuario = usuarioServicios.IniciarSesion(email, pass);
                return usuario is not null ? Results.Ok(usuario) : Results.Unauthorized();
            });

            app.MapPost("/api/usuarios/registro", (Usuario usuario) =>
            {
                usuarioServicios.RegistrarUsuario(usuario);
                return Results.Created($"/api/usuarios/{usuario.IdUsuario}", usuario);
            });
        }
    }
}