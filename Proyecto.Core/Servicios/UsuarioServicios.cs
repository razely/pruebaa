using Proyecto.Core.Models;
using Proyecto.Core.Repos;

namespace Proyecto.Core.Servicios
{
    public class UsuarioServicios
    {
        private UsuarioRepo _usuarioRepo = new UsuarioRepo();

        public Usuario? IniciarSesion(string email, string pass)
        {
            return _usuarioRepo.ValidarLogin(email, pass);
        }

        public void RegistrarUsuario(Usuario usuario)
        {
            _usuarioRepo.Agregar(usuario);
        }

        public Usuario? ObtenerPorId(int idUsuario)
        {
            return _usuarioRepo.ObtenerPorId(idUsuario);
        }
    }
}